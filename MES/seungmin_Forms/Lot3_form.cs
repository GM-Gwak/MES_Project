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
    public partial class Lot3_form : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleDataReader rdr;
        Random rand = new Random();

        string FT;
        string MB_ID;
        static bool move1 = false;

        string query = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자ID, P.PMNAME 제품명 " +
        $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '3' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";

        static string[] test_str = new string[3] { "pme01", "pki01", "pri01" };
        static string next_order_woid;
        static string next_order_pmid;
        static string stat;
        static string day;
        static string tem;
        static string hum;
        static int next_order_planqty;
        string next_lotid;
        static int faulty;

        public Lot3_form()
        {
            InitializeComponent();
        }

        private void Lot3_form_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            grid_view();

            pictureBox5.Visible = false;
            pictureBox3.Visible = false;
        }
        public void grid_view()
        {
            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds1 = new DataSet();
            adapt.Fill(ds1);
            LOT3_grid.DataSource = ds1.Tables[0].DefaultView;
            LOT3_grid.Columns[2].Width = 130;
            LOT3_grid.Columns[3].Width = 130;
            LOT3_grid.Columns[4].Width = 130;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (move1 == true || LOT3_grid.SelectedRows[0].Cells[5].Value.ToString() == "S")
            {
                MessageBox.Show("현재 다른 작업이 진행중입니다. 다시 확인해주세요.");
                return;
            }

            else if (move1 == false && stat == "P" && day == "")
            {
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

                MessageBox.Show("작업장3이 가동 시작되었습니다!");
                move1 = true;
                pictureBox5.Visible = true;
                pictureBox3.Visible = true;
            }
            else if (stat == "P" && day != "")
            {
                cmd.CommandText = $"update lot set lotstat = 'S' where lotid = '{next_lotid}'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("재 가동 되었습니다.");
                move1 = true;
                pictureBox5.Visible = true;
                pictureBox3.Visible = true;
            }
        }
        private void iconButton4_Click(object sender, EventArgs e)
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
                pictureBox3.Visible = false;
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
                faulty = rand.Next(1, 5);
                MessageBox.Show(faulty.ToString());

                cmd.CommandText = $"update lot set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), lotqty = '{next_order_planqty - faulty}', lotstat = 'E' where lotid = '{next_lotid}'";
                cmd.ExecuteNonQuery();
                move1 = false;
                MessageBox.Show("작업이 종료되었습니다.");
                pictureBox5.Visible = false;
                pictureBox3.Visible = false;

                int OX = rand.Next(1, 2);

                if (OX == 1)
                {
                    cmd.CommandText = $"insert into faulty values ('f0002', '{next_lotid}', '{faulty}')";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = $"insert into faulty values ('f0003', '{next_lotid}', '{faulty}')";
                    cmd.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("종료할 수 없거나, 진행중인 작업이 없습니다.");
                return;
            }
        }

        private void LOT3_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //// 선택한 행의 계획수량, PMID, WOID를 저장
            cmd.CommandText = $"select W.PMID from Workorder W, LOT L where W.WOID = L.WOID and W.WOID = '{LOT3_grid.SelectedRows[0].Cells[1].Value.ToString()}' and rownum = 1";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            next_order_pmid = rdr["PMID"] as string;

            next_order_woid = LOT3_grid.SelectedRows[0].Cells[1].Value.ToString();
            next_order_planqty = Int32.Parse(LOT3_grid.SelectedRows[0].Cells[6].Value.ToString());
            next_lotid = LOT3_grid.SelectedRows[0].Cells[0].Value.ToString();
            stat = LOT3_grid.SelectedRows[0].Cells[5].Value.ToString();
            day = LOT3_grid.SelectedRows[0].Cells[3].Value.ToString();

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
