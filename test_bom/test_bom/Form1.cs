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

namespace test_bom
{
    public partial class Form1 : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleDataReader rdr;

        string main_query = "select distinct(w.WoId) 작업지시ID," +
            "PMName 제품명," +
            "LotCreateTime 지시일," +
            "WoStat 작업상태," +
            "WoStartTime 시작시간," +
            "WoEndTime 종료시간," +
            "WoPlanQty 계획수량," +
            "WoProdQty 실적," +
            "WcNowTem 현재온도," +
            "WcNowHum 현재습도" +
            " from workorder w, PdMaster m, LOT l where w.PMId = m.PMId and w.WoId = l.WoId order by w.WoId";



        int test_int = 1000;
        static string[] test_str = new string[3] { "pme01", "pki01", "pri01" };
        static string next_order_woid;
        static string next_order_pmid;
        static int next_order_planqty;
        string[] next_lotid = new string[4];

        // 재고 13개
        string[] pme_bom = {"mds01", "mon01", "mch01", "mca01", "mgo01", "mpo01", "mss01", "msu01", 
                            "mpe01", "msa01", "mga01", "mbc01", "mcn01"};

        string[] pki_bom = {"mds01", "mon01", "mch01", "mca01", "mgo01", "mpo01", "mss01", "msu01",
                            "mpe01", "msa01", "mga01", "mbc01", "mki01"};

        string[] pri_bom = {"mds01", "mon01", "mch01", "mca01", "mgo01", "mpo01", "mss01", "msu01",
                            "mpe01", "msa01", "mga01", "mgs01", "mpu01"};

        static double stock_qty;
        static double stock_qty_in;

        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // 다음 작업지시 저장
        //    cmd.CommandText = $"select * from workorder " +
        //        $" where woid = (select min(woid) from workorder where wostarttime is null)";
        //    cmd.ExecuteNonQuery();

        //    rdr = cmd.ExecuteReader();
        //    rdr.Read();
        //    next_order_woid = rdr["woid"].ToString();
        //    next_order_pmid = rdr["pmid"].ToString();
        //    next_order_planqty = Int32.Parse(rdr["woplanqty"].ToString());
        //    MessageBox.Show(next_order_woid);
        //    MessageBox.Show(next_order_pmid);
        //    MessageBox.Show(next_order_planqty.ToString());

        //    // 다음 작업지시 랏 번호 저장
        //    int i = 0;
        //    cmd.CommandText = $"select* from lot " +
        //        $"where woid = (select min(woid) from workorder where wostarttime is null) " +
        //        $"order by lotid";
        //    cmd.ExecuteNonQuery();
        //    rdr = cmd.ExecuteReader();
        //    while (rdr.Read())
        //    {
        //        next_lotid[i] = rdr["lotid"].ToString();
        //        i++;
        //    }
        //    MessageBox.Show(next_lotid[0]);
        //    MessageBox.Show(next_lotid[1]);
        //    MessageBox.Show(next_lotid[2]);
        //    MessageBox.Show(next_lotid[3]);
        //}

        public void load()
        {
            // 작업지시 뷰
            adapt.SelectCommand = new OracleCommand(main_query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            WO_GRID.DataSource = ds.Tables[0].DefaultView;
            WO_GRID.Columns[2].Width = 130;


            // 각 작업장별 뷰
            string query = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자명, P.PMNAME 제품명 " +
                $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '1' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";
            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds1 = new DataSet();
            adapt.Fill(ds1);
            WC001.DataSource = ds1.Tables[0].DefaultView;
            WC001.Columns[1].Width = 130;
            WC001.Columns[2].Width = 130;
            WC001.Columns[10].Width = 130;

            string query2 = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자명, P.PMNAME 제품명 " +
                $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '2' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";
            adapt.SelectCommand = new OracleCommand(query2, conn);
            DataSet ds2 = new DataSet();
            adapt.Fill(ds2);
            WC002.DataSource = ds2.Tables[0].DefaultView;
            WC002.Columns[1].Width = 130;
            WC002.Columns[2].Width = 130;
            WC002.Columns[10].Width = 130;

            string query3 = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자명, P.PMNAME 제품명 " +
                $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '3' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";
            adapt.SelectCommand = new OracleCommand(query3, conn);
            DataSet ds3 = new DataSet();
            adapt.Fill(ds3);
            WC003.DataSource = ds3.Tables[0].DefaultView;
            WC003.Columns[1].Width = 130;
            WC003.Columns[2].Width = 130;
            WC003.Columns[10].Width = 130;

            string query4 = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자명, P.PMNAME 제품명 " +
                $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '4' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";
            adapt.SelectCommand = new OracleCommand(query4, conn);
            DataSet ds4 = new DataSet();
            adapt.Fill(ds4);
            WC004.DataSource = ds4.Tables[0].DefaultView;
            WC004.Columns[1].Width = 130;
            WC004.Columns[2].Width = 130;
            WC004.Columns[10].Width = 130;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            conn.Open();
            cmd.Connection = conn;
            load();
  
        }

        // #작업장1# 현재 작업지시와 현재 작지 랏1 업데이트
        private void start_1_Click(object sender, EventArgs e)
        {
            // 선택한 행의 WOID를 읽고, 그에 해당하는 워크오더의 시작시간 추가
            cmd.CommandText = $"update workorder set wostarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') where woid = '{WC001.SelectedRows[0].Cells[1].Value.ToString()}'";
            cmd.ExecuteNonQuery();

            // 선택한 행 업데이트
            cmd.CommandText = $"update lot set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc001' where lotid = '{WC001.SelectedRows[0].Cells[0].Value.ToString()}'";
            cmd.ExecuteNonQuery();

            // 선택한 행의 계획수량, PMID, WOID를 저장
            cmd.CommandText = $"select W.PMID from Workorder W, LOT L where W.WOID = L.WOID and W.WOID = '{WC001.SelectedRows[0].Cells[1].Value.ToString()}' and rownum = 1";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            next_order_pmid = rdr["PMID"] as string;
            next_order_woid = WC001.SelectedRows[0].Cells[1].Value.ToString();
            next_order_planqty = Int32.Parse(WC001.SelectedRows[0].Cells[6].Value.ToString());
            MessageBox.Show("작업장1이 가동 시작되었습니다.");

            WC001_N.Text = $"{WC001.SelectedRows[0].Cells[1].Value.ToString()} 진행중..";


            // 고기만두
            if (next_order_pmid == "pme01")
            {
                for (int i = 0; i < pme_bom.Length; i++)
                {
                    // 재고확인 (제일 오래된 재고)
                    cmd.CommandText = $"select stqty from stock where stdate = " +
                        $"(select min(stdate) from stock where pmid = '{pme_bom[i]}') and pmid = '{pme_bom[i]}'";
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    stock_qty = rdr.GetDouble(0);
                    MessageBox.Show(stock_qty.ToString());

                    // 들어가는 재료 확인
                    cmd.CommandText = $"select bomqty from bom where pmid = '{pme_bom[i]}' and bomname = '고기만두'";
                    cmd.ExecuteNonQuery();
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    stock_qty_in = rdr.GetDouble(0) * (next_order_planqty / 100);
                    MessageBox.Show(stock_qty_in.ToString());

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
                    MessageBox.Show(pme_bom[i]);
                }
            }
        }

        private void end_1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), lotqty = {next_order_planqty} where lotid = '{next_lotid[0]}'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("작업이 종료되었습니다.");
        }


        // #작업장2# 현재 작업지시와 현재 작지 랏2 업데이트
        private void start_2_Click(object sender, EventArgs e)
        {
            // 선택한 행 업데이트
            cmd.CommandText = $"update lot set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc002' where lotid = '{WC002.SelectedRows[0].Cells[0].Value.ToString()}'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("작업2이 가동 시작되었습니다.");

            WC002_N.Text = $"{WC002.SelectedRows[0].Cells[1].Value.ToString()} 진행중..";
        }

        private void end_2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
            $"set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
            $"where lotid = '{next_lotid[1]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업2이 종료되었습니다.");
        }

        // #작업장3# 현재 작업지시와 현재 작지 랏3 업데이트
        private void start_3_Click(object sender, EventArgs e)
        {
            // 선택한 행 업데이트
            cmd.CommandText = $"update lot set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc003' where lotid = '{WC003.SelectedRows[0].Cells[0].Value.ToString()}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업장3이 가동 시작되었습니다.");

            WC003_N.Text = $"{WC003.SelectedRows[0].Cells[1].Value.ToString()} 진행중..";
        }

        private void end_3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
                $"set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
                $"where lotid = '{next_lotid[2]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업3이 종료되었습니다.");
        }

        // #작업장4# 현재 작업지시와 현재 작지 랏4 업데이트
        private void start_4_Click(object sender, EventArgs e)
        {
            // 선택한 행 업데이트
            cmd.CommandText = $"update lot set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc001' where lotid = '{WC004.SelectedRows[0].Cells[0].Value.ToString()}'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("작업장4이 가동 시작되었습니다.");

            WC004_N.Text = $"{WC004.SelectedRows[0].Cells[1].Value.ToString()} 진행중..";
        }

        private void end_4_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
                $"set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
                $"where lotid = '{next_lotid[3]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업4이 종료되었습니다.");

            cmd.CommandText = $"update workorder " +
                $"set woendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
                $"where woid = '{next_order_woid}'";
            cmd.ExecuteNonQuery();
        }

        private void WC001_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cmd.CommandText = $"select W.PMID from Workorder W, LOT L where W.WOID = L.WOID and W.WOID = '{WC001.SelectedRows[0].Cells[1].Value.ToString()}' and rownum = 1";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            next_order_pmid = rdr["PMID"] as string;

            textBox1.Text = $" [ 선택한 LOT = {WC001.SelectedRows[0].Cells[0].Value.ToString()} ] [ 선택한 WOID = {WC001.SelectedRows[0].Cells[1].Value.ToString()} ] [ 선택한 수량 = {Int32.Parse(WC001.SelectedRows[0].Cells[6].Value.ToString())} ] [ 선택한 PMID = {next_order_pmid} ]";

        }

        private void WC002_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = $" [ 선택한 LOT = {WC002.SelectedRows[0].Cells[0].Value.ToString()} ] [ 선택한 WOID = {WC002.SelectedRows[0].Cells[1].Value.ToString()} ] [ 선택한 수량 = {Int32.Parse(WC002.SelectedRows[0].Cells[6].Value.ToString())} ]";
        }

        private void WC003_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = $" [ 선택한 LOT = {WC003.SelectedRows[0].Cells[0].Value.ToString()} ] [ 선택한 WOID = {WC003.SelectedRows[0].Cells[1].Value.ToString()} ] [ 선택한 수량 = {Int32.Parse(WC003.SelectedRows[0].Cells[6].Value.ToString())} ]";
        }

        private void WC004_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = $" [ 선택한 LOT = {WC004.SelectedRows[0].Cells[0].Value.ToString()} ] [ 선택한 WOID = {WC004.SelectedRows[0].Cells[1].Value.ToString()} ] [ 선택한 수량 = {Int32.Parse(WC004.SelectedRows[0].Cells[6].Value.ToString())} ]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}

/*  다음 작업지시번호 가져오기    string woid = 
 select min(woid) from workorder where wostarttime is null;
 */

/* 다음 작업지시 pmid 가져오기 (무슨만두인지)  stirng pmid = pme01
 select pmid from workorder 
where woid = (select min(woid) from workorder where wostarttime is null);
 */

/* 다음 작업지시 목표수량 가져오기  int test
 select woplanqty from workorder 
where woid = (select min(woid) from workorder where wostarttime is null);
 */


/* 작업지시 시작시간 넣기.
update workorder
set wostarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss')
where woid = (select min(woid) from workorder where wostarttime is null);
 */

/* 랏에도 시간넣기
 
 */


// pmi에 따라 재고 수정하기
/* 고기만두 (pme01)

update stock
set stqty = stqty - (1.15 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mds01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mon01');

update stock
set stqty = stqty - (0.5 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mch01');

update stock
set stqty = stqty - (0.5 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mca01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mgo01');

update stock
set stqty = stqty - (1.75 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpo01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mss01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'msu01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpe01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'msa01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mga01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mbc01');

update stock
set stqty = stqty - (0.1 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mcn01');

 */


/* 김치만두 (pki01)

update stock
set stqty = stqty - (1.15 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mds01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mon01');

update stock
set stqty = stqty - (0.5 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mch01');

update stock
set stqty = stqty - (0.5 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mca01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mgo01');

update stock
set stqty = stqty - (1.0 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpo01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mss01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'msu01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpe01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'msa01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mga01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mbc01');

update stock
set stqty = stqty - (0.85 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mki01');

 */



/* 갈비만두 (pri01)

update stock
set stqty = stqty - (1.15 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mds01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mon01');

update stock
set stqty = stqty - (0.5 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mch01');

update stock
set stqty = stqty - (0.5 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mca01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mgo01');

update stock
set stqty = stqty - (1.75 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpo01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mss01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'msu01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpe01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'msa01');

update stock
set stqty = stqty - (0.05 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mga01');

update stock
set stqty = stqty - (0.1 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mgs01');

update stock
set stqty = stqty - (0.25 * 갯수 / 100);
where stdate = (select min(stdate) from stock where pmid = 'mpu01');

 */


