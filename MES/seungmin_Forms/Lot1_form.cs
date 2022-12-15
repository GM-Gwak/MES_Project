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

        static string[] test_str = new string[3] { "pme01", "pki01", "pri01" };
        static string next_order_woid;
        static string next_order_pmid;
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

        private void workorder_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            string query = $"select L.LOTID, L.WOID, L.LOTCREATETIME 생성시간, L.LOTSTARTTIME 시작시간, L.LOTENDTIME 종료시간, L.LOTSTAT 상태, W.WOPLANQTY 수량, L.LOTQTY 실적, L.WCID 작업장명, L.MBNO 담당자명, P.PMNAME 제품명 " +
                $"from lot L, Workorder W, PDMASTER P where SUBSTR(LOTID, 8, 1) = '1' and L.WOID = W.WOID and W.PMID = P.PMID order by WOID";
            adapt.SelectCommand = new OracleCommand(query, conn);
            DataSet ds1 = new DataSet();
            adapt.Fill(ds1);
            work_grid.DataSource = ds1.Tables[0].DefaultView;
            work_grid.Columns[1].Width = 130;
            work_grid.Columns[2].Width = 130;
            work_grid.Columns[10].Width = 130;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pme_bom.Length; i++)
            {
                cmd.CommandText = $"select stqty from stock where stdate = (select min(stdate) from stock where pmid = '{pme_bom[i]}') and pmid = '{pme_bom[i]}' and rownum = 1 order by stid";
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == false)
                {
                    MessageBox.Show("재고가 부족합니다.");
                    return;
                }
            }

            // 선택한 행의 WOID를 읽고, 그에 해당하는 워크오더의 시작시간 추가
            cmd.CommandText = $"update workorder set wostarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wostat = 'S' where woid = '{work_grid.SelectedRows[0].Cells[1].Value.ToString()}'";
            cmd.ExecuteNonQuery();

            // 선택한 행 업데이트
            cmd.CommandText = $"update lot set lotstarttime = to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), wcid = 'wc001', lotstat = 'S' where lotid = '{work_grid.SelectedRows[0].Cells[0].Value.ToString()}'";
            cmd.ExecuteNonQuery();

            // 선택한 행의 계획수량, PMID, WOID를 저장
            cmd.CommandText = $"select W.PMID from Workorder W, LOT L where W.WOID = L.WOID and W.WOID = '{work_grid.SelectedRows[0].Cells[1].Value.ToString()}' and rownum = 1";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            next_order_pmid = rdr["PMID"] as string;
            next_order_woid = work_grid.SelectedRows[0].Cells[1].Value.ToString();
            next_order_planqty = Int32.Parse(work_grid.SelectedRows[0].Cells[6].Value.ToString());
            next_lotid = work_grid.SelectedRows[0].Cells[0].Value.ToString();

            MessageBox.Show("작업장1이 가동 시작되었습니다.");


        }

        private void LINE_VIEW1_Click(object sender, EventArgs e)
        {

        }
    }
}
