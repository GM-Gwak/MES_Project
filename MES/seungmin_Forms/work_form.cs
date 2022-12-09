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
    public partial class work_form : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleDataReader rdr;
        static string mes_id;
        private Form currentChildForm;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        public work_form()
        {
            InitializeComponent();
        }

        public work_form(string data)
        {
            InitializeComponent();

            mes_id = data;
        }

        private void work_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = $"SELECT mbname FROM member WHERE mbId = '{mes_id}'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            name_label.Text = rdr["mbname"].ToString();

            adapt.SelectCommand = new OracleCommand("select * from workorder where wostat = 'P' order by woid", conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            work_grid.DataSource = ds.Tables[0].DefaultView;
            work_grid.Columns[2].Width = 130;

            cmd.CommandText = "select sum(woplanqty) from workorder where wostat ='P'";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            woplanqty_value.Text = rdr["sum(woplanqty)"].ToString();

            cmd.CommandText = $"select sum(woplanqty) from workorder where wostat='E' and woendtime = '{DateTime.Now.ToString("yyyy-MM-dd")}'";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr["sum(woplanqty)"].ToString() == "") { woprodqty_value.Text = "null";}
            else { woprodqty_value.Text = rdr["sum(woplanqty)"].ToString();}
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            work_main_panel.Controls.Add(childForm);
            work_main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lot1_form());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                currentChildForm.Close();
            }
            catch (Exception)
            {

            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lot2_form());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lot3_form());
        }
    }
}
