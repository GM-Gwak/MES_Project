using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.seungmin_Forms
{
    public partial class worck : Form
    {
        static string mes_name;

        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleDataReader rdr;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        public worck()
        {
            InitializeComponent();
        }
        public worck(string data)
        {
            InitializeComponent();
            mes_name = data;
        }

        private void worck_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            //cmd.CommandText = $"SELECT mbname FROM member WHERE mbId = '{mes_name}'";
            //cmd.ExecuteNonQuery();
            //rdr = cmd.ExecuteReader();
            //rdr.Read();
            //string work_name = rdr["mbname"].ToString();
            //work_label.Text = work_name.ToString();

            adapt.SelectCommand = new OracleCommand("select * from workorder where wostat = 'P'", conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            WO_GRID.DataSource = ds.Tables[0].DefaultView;

            WO_GRID.Columns[2].Width = 130;

            cmd.CommandText = $"select sum(woplanqty) from workorder where wostat = 'P'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_name = rdr["sum(woplanqty)"].ToString();
            label4.Text = work_name.ToString();

            cmd.CommandText = $"select sum(woprodqty) from workorder where woendtime = '2022-12-08'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_day = rdr["sum(woprodqty)"].ToString();
            label6.Text = work_day.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
