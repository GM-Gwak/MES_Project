using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.seungmin_Forms
{
    public partial class Lot1_form : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleDataReader rdr;
        mainform main = new mainform();

        string FT;
        string MB_ID;
        static bool move1 = false;

        string query = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자ID, P.PMNAME 제품명 " +
        $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '1' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";

        static string[] test_str = new string[3] { "pme01", "pki01", "pri01" };
        static string next_order_woid;
        static string next_order_pmid;
        static string stat;
        static string day;
        static string tem;
        static string hum;
        static int next_order_planqty;
        string next_lotid;

        // 재고 13개
        string[] pme_bom = { "mds01", "mon01", "mch01", "mca01", "mgo01", "mpo01", "mss01", "msu01", "mpe01", "msa01", "mga01", "mbc01", "mcn01" };

        string[] pki_bom = { "mds01", "mon01", "mch01", "mca01", "mgo01", "mpo01", "mss01", "msu01", "mpe01", "msa01", "mga01", "mbc01", "mki01" };

        string[] pri_bom = { "mds01", "mon01", "mch01", "mca01", "mgo01", "mpo01", "mss01", "msu01", "mpe01", "msa01", "mga01", "mgs01", "mpu01" };

        static double stock_qty;
        static double stock_qty_in;

        public Lot1_form()
        {
            InitializeComponent();
        }


        public void grid_view()
        {
            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds1 = new DataSet();
            adapt.Fill(ds1);
            LOT1_grid.DataSource = ds1.Tables[0].DefaultView;
            LOT1_grid.Columns[2].Width = 130;
            LOT1_grid.Columns[3].Width = 130;
            LOT1_grid.Columns[4].Width = 130;
        }


        private void workorder_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            grid_view();
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // 작동중인지 검사
            if (move1 == true || LOT1_grid.SelectedRows[0].Cells[5].Value.ToString() == "S")
            {
                MessageBox.Show("현재 다른 작업이 진행중입니다. 다시 확인해주세요.");
                return;
            }

            else if (move1 == false && stat == "P" && day == "")
            {
                for (int i = 0; i < pme_bom.Length; i++)
                {
                    cmd.CommandText = $"select stqty from stock where stdate = (select min(stdate) from stock where pmid = '{pme_bom[i]}') and pmid = '{pme_bom[i]}' and rownum = 1 order by stid";
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == false)
                    {
                        MessageBox.Show("재고가 부족합니다.");
                        break;
                    }
                }

                Start_password password = new Start_password();
                password.ShowDialog();

                FT = Start_password.password_FT;
                MB_ID = Start_password.ID;

                if (FT == "F")
                {
                    MessageBox.Show("비밀번호가 정확하지 않습니다.");
                    return;
                }
                else if (FT == "N")
                {
                    return;
                }

                // 선택한 행의 WOID를 읽고, 그에 해당하는 워크오더의 시작시간 추가
                cmd.CommandText = $"update workorder set wostarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wostat = 'S', WCNOWTEM = '{tem}', WCNOWHUM = '{hum}' where woid = '{next_order_woid}'";
                cmd.ExecuteNonQuery();

                // 선택한 행 업데이트 (LOT 업데이트)
                cmd.CommandText = $"update lot set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc001', lotstat = 'S', MBNO = '{MB_ID}' where lotid = '{next_lotid}'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("작업장1이 가동 시작되었습니다!");


                //고기만두
                if (next_order_pmid == "pme01")
                {
                    for (int i = 0; i < pme_bom.Length; i++)
                    {
                        // 재고확인 (제일 오래된 재고)
                        cmd.CommandText = $"select stqty from stock where stdate = (select min(stdate) from stock where pmid = '{pme_bom[i]}') and pmid = '{pme_bom[i]}' and rownum = 1 order by stid";
                        cmd.ExecuteNonQuery();
                        rdr = cmd.ExecuteReader();
                        rdr.Read();
                        stock_qty = rdr.GetDouble(0);

                        // 들어가는 재료 확인
                        cmd.CommandText = $"select bomqty from bom where pmid = '{pme_bom[i]}' and bomname = '고기만두'";
                        cmd.ExecuteNonQuery();
                        rdr = cmd.ExecuteReader();
                        rdr.Read();
                        stock_qty_in = rdr.GetDouble(0) * (next_order_planqty / 100);

                        // 제일 오래된 재고가 들어가는 재고보다 많을 시
                        if (stock_qty > stock_qty_in)
                        {
                            cmd.CommandText = $"update stock " +
                                $"set stqty = stqty - {stock_qty_in} " +
                                $"where pmid = '{pme_bom[i]}' and stdate = " +
                                $"(select stdate from stock where pmid = '{pme_bom[i]}' and stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pme_bom[i]}'))";
                            cmd.ExecuteNonQuery();
                        }
                        else if (stock_qty == stock_qty_in)
                        {
                            cmd.CommandText = $"delete stock where stid = " +
                                $"(select stid from stock where stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pme_bom[i]}'))";
                            cmd.ExecuteNonQuery();
                        }

                        // 제일 오래된 재고가 들어가는 재고보다 적을 시
                        else
                        {
                            // 오래된 재고를 쓰고 남은 수
                            double re_stock_qty = stock_qty_in - stock_qty;

                            // 오래된 재고삭제
                            cmd.CommandText = $"delete stock where stid = " +
                                $"(select stid from stock where stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pme_bom[i]}') and pmid = '{pme_bom[i]}')";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = $"commit";
                            cmd.ExecuteNonQuery();

                            // 남은 수를 재고에서 빼기
                            cmd.CommandText = $"update stock " +
                                $"set stqty = stqty - {re_stock_qty} " +
                                $"where stdate = " +
                                $"(select stdate from stock where stdate = " +
                                $"(select stdate from stock where pmid = '{pme_bom[i]}' and stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pme_bom[i]}'))) " +
                                $"and pmid = '{pme_bom[i]}'";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                //김치만두
                if (next_order_pmid == "pki01")
                {
                    for (int i = 0; i < pme_bom.Length; i++)
                    {
                        // 재고확인 (제일 오래된 재고)
                        cmd.CommandText = $"select stqty from stock where stdate = (select min(stdate) from stock where pmid = '{pki_bom[i]}') and pmid = '{pki_bom[i]}' and rownum = 1 order by stid";
                        cmd.ExecuteNonQuery();
                        rdr = cmd.ExecuteReader();
                        rdr.Read();
                        stock_qty = rdr.GetDouble(0);

                        // 들어가는 재료 확인
                        cmd.CommandText = $"select bomqty from bom where pmid = '{pki_bom[i]}' and bomname = '고기만두'";
                        cmd.ExecuteNonQuery();
                        rdr = cmd.ExecuteReader();
                        rdr.Read();
                        stock_qty_in = rdr.GetDouble(0) * (next_order_planqty / 100);

                        // 제일 오래된 재고가 들어가는 재고보다 많을 시
                        if (stock_qty > stock_qty_in)
                        {
                            cmd.CommandText = $"update stock " +
                                $"set stqty = stqty - {stock_qty_in} " +
                                $"where pmid = '{pki_bom[i]}' and stdate = " +
                                $"(select stdate from stock where pmid = '{pki_bom[i]}' and stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pki_bom[i]}'))";
                            cmd.ExecuteNonQuery();
                        }
                        else if (stock_qty == stock_qty_in)
                        {
                            cmd.CommandText = $"delete stock where stid = " +
                                $"(select stid from stock where stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pki_bom[i]}'))";
                            cmd.ExecuteNonQuery();
                        }

                        // 제일 오래된 재고가 들어가는 재고보다 적을 시
                        else
                        {
                            // 오래된 재고를 쓰고 남은 수
                            double re_stock_qty = stock_qty_in - stock_qty;

                            // 오래된 재고삭제
                            cmd.CommandText = $"delete stock where stid = " +
                                $"(select stid from stock where stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pki_bom[i]}') and pmid = '{pki_bom[i]}')";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = $"commit";
                            cmd.ExecuteNonQuery();

                            // 남은 수를 재고에서 빼기
                            cmd.CommandText = $"update stock " +
                                $"set stqty = stqty - {re_stock_qty} " +
                                $"where stdate = " +
                                $"(select stdate from stock where stdate = " +
                                $"(select stdate from stock where pmid = '{pki_bom[i]}' and stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pki_bom[i]}'))) " +
                                $"and pmid = '{pki_bom[i]}'";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                //갈비만두
                if (next_order_pmid == "pri01")
                {
                    for (int i = 0; i < pme_bom.Length; i++)
                    {
                        // 재고확인 (제일 오래된 재고)
                        cmd.CommandText = $"select stqty from stock where stdate = (select min(stdate) from stock where pmid = '{pri_bom[i]}') and pmid = '{pri_bom[i]}' and rownum = 1 order by stid";
                        cmd.ExecuteNonQuery();
                        rdr = cmd.ExecuteReader();
                        rdr.Read();
                        stock_qty = rdr.GetDouble(0);

                        //textBox1.AppendText(stock_qty.ToString() + "\r\n");

                        // 들어가는 재료 확인
                        cmd.CommandText = $"select bomqty from bom where pmid = '{pri_bom[i]}' and bomname = '갈비만두'";
                        cmd.ExecuteNonQuery();
                        rdr = cmd.ExecuteReader();
                        rdr.Read();
                        stock_qty_in = rdr.GetDouble(0) * (next_order_planqty / 100);

                        //textBox1.AppendText(stock_qty_in.ToString() + "\r\n");

                        // 제일 오래된 재고가 들어가는 재고보다 많을 시
                        if (stock_qty > stock_qty_in)
                        {
                            cmd.CommandText = $"update stock " +
                                $"set stqty = stqty - {stock_qty_in} " +
                                $"where pmid = '{pri_bom[i]}' and stdate = " +
                                $"(select stdate from stock where pmid = '{pri_bom[i]}' and stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pri_bom[i]}'))";
                            cmd.ExecuteNonQuery();
                        }
                        else if (stock_qty == stock_qty_in)
                        {
                            cmd.CommandText = $"delete stock where stid = " +
                                $"(select stid from stock where stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pri_bom[i]}'))";
                            cmd.ExecuteNonQuery();
                        }

                        // 제일 오래된 재고가 들어가는 재고보다 적을 시
                        else
                        {
                            // 오래된 재고를 쓰고 남은 수
                            double re_stock_qty = stock_qty_in - stock_qty;

                            // 오래된 재고삭제
                            cmd.CommandText = $"delete stock where stid = " +
                                $"(select stid from stock where stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pri_bom[i]}') and pmid = '{pri_bom[i]}')";
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = $"commit";
                            cmd.ExecuteNonQuery();

                            // 남은 수를 재고에서 빼기
                            cmd.CommandText = $"update stock " +
                                $"set stqty = stqty - {re_stock_qty} " +
                                $"where stdate = " +
                                $"(select stdate from stock where stdate = " +
                                $"(select stdate from stock where pmid = '{pri_bom[i]}' and stdate = " +
                                $"(select min(stdate) from stock where pmid = '{pri_bom[i]}'))) " +
                                $"and pmid = '{pri_bom[i]}'";
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                move1 = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }

            else if (stat == "P" && day != "")
            {
                cmd.CommandText = $"update lot set lotstat = 'S' where lotid = '{next_lotid}'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("재 가동 되었습니다.");
                move1 = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
        }
            

    private void LINE_VIEW1_Click(object sender, EventArgs e)
        {
            grid_view();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (move1 == true || stat == "S")
            {
                cmd.CommandText = $"update lot set lotstat = 'P' where lotid = '{next_lotid}'";
                cmd.ExecuteNonQuery();
                move1 = false;
                MessageBox.Show("공정이 중단되었습니다.");
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
            else
            {
                MessageBox.Show("중단할 수 없거나, 진행중인 작업이 없습니다.");
                return;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (move1 == true || stat == "S")
            {
                cmd.CommandText = $"update lot set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), lotqty = '{next_order_planqty}', lotstat = 'E' where lotid = '{next_lotid}'";
                cmd.ExecuteNonQuery();
                move1 = false;
                MessageBox.Show("작업이 종료되었습니다.");
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
            else
            {
                MessageBox.Show("종료할 수 없거나, 진행중인 작업이 없습니다.");
                return;
            }
        }

        private void work_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// 선택한 행의 계획수량, PMID, WOID를 저장
            cmd.CommandText = $"select W.PMID from Workorder W, LOT L where W.WOID = L.WOID and W.WOID = '{LOT1_grid.SelectedRows[0].Cells[1].Value.ToString()}' and rownum = 1";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            next_order_pmid = rdr["PMID"] as string;

            next_order_woid = LOT1_grid.SelectedRows[0].Cells[1].Value.ToString();
            next_order_planqty = Int32.Parse(LOT1_grid.SelectedRows[0].Cells[6].Value.ToString());
            next_lotid = LOT1_grid.SelectedRows[0].Cells[0].Value.ToString();
            stat = LOT1_grid.SelectedRows[0].Cells[5].Value.ToString();
            day = LOT1_grid.SelectedRows[0].Cells[3].Value.ToString();

            cmd.CommandText = $"select WCOPTIMALTEM, WCOPTIMALHUM from workcd where wcid = 'wc001'";
            rdr = cmd.ExecuteReader();
            rdr.Read();

            tem = rdr["WCOPTIMALTEM"] as string;
            hum = rdr["WCOPTIMALHUM"] as string;


            textBox1.Text = $" [ 선택한 LOT = {next_lotid} ] " +
                $"[ 선택한 WOID = {next_order_woid} ] " +
                $"[ 선택한 수량 = {next_order_planqty} ] " +
                $"[ 선택한 pmid = {next_order_pmid} ]" +
                $"[ 선택한 상태 = {stat} ] " +
                $"[ 선택한 날짜 = {day} ] " +
                $"[ 선택한 온도 = {tem} ] " +
                $"[ 선택한 습도 = {hum} ]";
        }
    }
}

