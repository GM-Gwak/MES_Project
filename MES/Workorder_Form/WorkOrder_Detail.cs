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

namespace MES.Workorder_Form
{
    public partial class WorkOrder_Detail : Form
    {
        static public string wo_num;
        static public string wo_pmname;
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        public WorkOrder_Detail()
        {
            InitializeComponent();
        }

        private void WorkOrder_Detail_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            string main_query = string.Empty;

            string[] lot = new string[4];
            string[] pmid = new string[4];

            int i = 0;
            cmd.CommandText = $"select * from pdmaster where pmname like '%{wo_pmname}%' order by pmid";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                pmid[i] = rdr["pmid"] as string;
                textBox1.AppendText(pmid[i]);
                i++;
            }

            cmd.CommandText = $"select L.lotid from lot L, workorder W where L.woid = W.woid and w.woid = '{wo_num}'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            i = 0;
            while (rdr.Read())
            {
                lot[i] = rdr["lotid"] as string;
                textBox1.AppendText(lot[i]);
                i++;
            }

            string query = $"select L.LOTID LOT번호, " +
                            "L.WCID 작업장번호, " +
                            "PD.PMNAME 제품명, " +
                            "L.LOTSTAT 작업상태, " +
                            "L.MBNO 담당자명, " +
                            "L.LOTSTARTTIME 시작시간, " +
                            "L.LOTENDTIME 종료시간, " +
                            "L.LOTQTY 생산량, " +
                            "F.FAQTY 불량수량 " +
                            "from LOT L, Faulty F, PDMaster PD, workorder W where W.woid = L.woid and L.LOTID = F.LOTID(+) and ";

            main_query =
            query + $"l.lotid = '{lot[0]}' and pd.pmid = '{pmid[0]}'" +

            " union " +

            query + $"l.lotid = '{lot[1]}' and pd.pmid = '{pmid[1]}'" +

            " union " +

            query + $"l.lotid = '{lot[2]}' and pd.pmid = '{pmid[2]}'" +

            " union " +

            query + $"l.lotid = '{lot[3]}' and pd.pmid = '{pmid[3]}'";

            adapt.SelectCommand = new OracleCommand(main_query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
