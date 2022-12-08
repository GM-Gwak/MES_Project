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

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pme_bom.Length; i++)
            {
                cmd.CommandText = $"select bomqty from bom where pmid = '{pme_bom[i]}' and bomname = '고기만두'";
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                Double id = rdr.GetDouble(0) * 10;
                MessageBox.Show(pme_bom[i] + " = " + id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 다음 작업지시 저장
            cmd.CommandText = $"select * from workorder " +
                $" where woid = (select min(woid) from workorder where wostarttime is null)";
            cmd.ExecuteNonQuery();

            rdr = cmd.ExecuteReader();
            rdr.Read();
            next_order_woid = rdr["woid"].ToString();
            next_order_pmid = rdr["pmid"].ToString();
            next_order_planqty = Int32.Parse(rdr["woplanqty"].ToString());
            MessageBox.Show(next_order_woid);
            MessageBox.Show(next_order_pmid);
            MessageBox.Show(next_order_planqty.ToString());

            // 다음 작업지시 랏 번호 저장
            int i = 0;
            cmd.CommandText = $"select* from lot " +
                $"where woid = (select min(woid) from workorder where wostarttime is null) " +
                $"order by lotid";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                next_lotid[i] = rdr["lotid"].ToString();
                i++;
            }
            MessageBox.Show(next_lotid[0]);
            MessageBox.Show(next_lotid[1]);
            MessageBox.Show(next_lotid[2]);
            MessageBox.Show(next_lotid[3]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
        }

        // 작업지시와 랏1에 시작시간 넣기
        private void start_1_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update workorder " +
                $"set wostarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
                $"where woid = '{next_order_woid}'";
            cmd.ExecuteNonQuery();

            cmd.CommandText = $"update lot " +
                $"set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc001' " +
                $"where lotid = '{next_lotid[0]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업1이 시작되었습니다.");


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
            cmd.CommandText = $"update lot " +
                $"set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), lotqty = {next_order_planqty} " +
                $"where lotid = '{next_lotid[0]}'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("작업1이 종료되었습니다.");
        }


        private void start_2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
                $"set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc002' " +
                $"where lotid = '{next_lotid[1]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업2이 시작되었습니다.");
        }

        private void end_2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
            $"set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
            $"where lotid = '{next_lotid[1]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업2이 종료되었습니다.");
        }

        private void start_3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
                $"set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc003' " +
                $"where lotid = '{next_lotid[2]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업3이 시작되었습니다.");
        }

        private void end_3_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
                $"set lotendtime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss') " +
                $"where lotid = '{next_lotid[2]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업3이 종료되었습니다.");
        }

        private void start_4_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"update lot " +
                $"set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc004' " +
                $"where lotid = '{next_lotid[3]}'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("작업4이 시작되었습니다.");
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


