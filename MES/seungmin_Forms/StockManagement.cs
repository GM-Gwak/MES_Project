using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Oracle.ManagedDataAccess.Client;

namespace MES
{
    public partial class StockManagement : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr ;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        public StockManagement()
        {
            InitializeComponent();
            
        }

        private void StockManagement_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string A = "select PD.PMName as 재고명, SUM(s.StQty) as 수량, PD.PMUnit as 단위 from PdMaster PD join Stock S on PD.PMid = S.PMId " +
                       "GROUP BY PD.PMName, PD.PMUnit order by PMUnit desc";

            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = new OracleCommand(A, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void ST_View_Click(object sender, EventArgs e)
        {
            string A = "select PD.PMName as 재고명, SUM(s.StQty) as 수량, PD.PMUnit as 단위 from PdMaster PD join Stock S on PD.PMid = S.PMId " +
           "GROUP BY PD.PMName, PD.PMUnit order by PMUnit desc";

            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = new OracleCommand(A, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void ST_Add_Click(object sender, EventArgs e)
        {
            Stock_Receiving showForm3 = new Stock_Receiving();
            showForm3.ShowDialog();
        }

        private void ST_Detail_Click(object sender, EventArgs e)
        {
            Stock_ViewDetail showForm2 = new Stock_ViewDetail();
            showForm2.ShowDialog();
        }
    }
}
