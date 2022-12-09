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

        public Lot1_form()
        {
            InitializeComponent();
        }

        private void workorder_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            adapt.SelectCommand = new OracleCommand("select lotid as LotId,woid as 작업지시ID,lotcreatetime as Lot생성시간,lotstarttime as Lot시작시간, " +
                                                    "lotendtime as Lot종료시간,lotstat as Lot상태,lotqty as Lot실적, wcid as 작업장ID, mbno as 작업담당자 " +
                                                    "from lot where substr(lotid,8,1) ='1'and lotstat='P' order by lotid", conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            work_grid.DataSource = ds.Tables[0].DefaultView;
            work_grid.Columns[2].Width = 130;
        }
    }
}
