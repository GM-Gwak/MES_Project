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
    public partial class test : Form
    {
        mainform main = new mainform();
        //public EventHandler work1;
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        public test()
        {
            InitializeComponent();
        }
        public test(object form)       //생성자를 하나 더 만듦
        {
            InitializeComponent();

            main = (mainform)form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //main.work_cd1();
            //work1.Invoke(null, EventArgs.Empty);
        }

        private void test_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            //mainform main = new mainform();
            //work1 += new EventHandler(main.work_cd1);
        }
    }
}
