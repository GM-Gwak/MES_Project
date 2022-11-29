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
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr ;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        public StockManagement()
        {
            InitializeComponent();
            
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            //hello world;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Stock_ViewDetail showForm2 = new Stock_ViewDetail();
            showForm2.ShowDialog();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Stock_Receiving showForm3 = new Stock_Receiving();
            showForm3.ShowDialog();
        }
    }
}
