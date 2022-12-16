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

        private string start_time = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
        private string now_time = DateTime.Now.ToString("yyyy-MM-dd");

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

        public void grid_view()
        {
            adapt.SelectCommand = new OracleCommand(main_query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            work_grid.DataSource = ds.Tables[0].DefaultView;
            work_grid.Columns[2].Width = 130;
            work_grid.Columns[4].Width = 130;
            work_grid.Columns[5].Width = 130;
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

            grid_view();

            cmd.CommandText = "select sum(woplanqty) from workorder";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            woplanqty_value.Text = rdr["sum(woplanqty)"].ToString();

            cmd.CommandText = $"select sum(woplanqty) from workorder where wostat='E' and woendtime = '{DateTime.Now.ToString("yyyy-MM-dd")}'";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr["sum(woplanqty)"].ToString() == "") { woprodqty_value.Text = "null";}
            else { woprodqty_value.Text = rdr["sum(woplanqty)"].ToString();}

            Start_password.mbname = name_label.Text;

            cmd.CommandText = $"SELECT sum(woplanqty) FROM workorder where wostarttime like '{now_time}%'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            woplanqty_value.Text = rdr["sum(woplanqty)"].ToString();
            //test
            woprodqty_value.Text = "13699";
            wofaulty_value.Text = "40";

            work_chart();
        }

        public void work_chart() {
            string main_query = "select sum(woprodqty), woendtime,pmname from workorder w join pdmaster pd on(w.pmid= pd.pmid) where pmname like";
            // 차트
            chart1.Series["고기만두"].Points.Clear();
            chart1.Series["김치만두"].Points.Clear();
            chart1.Series["갈비만두"].Points.Clear();
            chart1.Series["계획 수량"].Points.Clear();

            cmd.CommandText = $"select woendtime, sum(woplanqty), pmname from workorder w join pdmaster pd on(w.pmid = pd.pmid) group by woendtime, pmname";
            OracleDataReader sum1 = cmd.ExecuteReader();
            while (sum1.Read())
            {
                chart1.Series["계획 수량"].Points.AddXY(sum1["woendtime"].ToString(), Int32.Parse(sum1["sum(woplanqty)"].ToString()));
            }
            cmd.CommandText = main_query + $" '고기%' and woendtime between '{start_time}' and '{now_time}' group by woendtime,pmname";
            OracleDataReader sum2 = cmd.ExecuteReader();
            while (sum2.Read())
            {
                chart1.Series["고기만두"].Points.Add(Int32.Parse(sum2["sum(woprodqty)"].ToString()));
            }
            cmd.CommandText = main_query + $" '김치%' and woendtime between '{start_time}' and '{now_time}' group by woendtime,pmname";
            OracleDataReader sum3 = cmd.ExecuteReader();
            while (sum3.Read())
            {
                chart1.Series["김치만두"].Points.Add(Int32.Parse(sum3["sum(woprodqty)"].ToString()));
            }
            cmd.CommandText = main_query + $" '갈비%' and woendtime between '{start_time}' and '{now_time}' group by woendtime,pmname";
            OracleDataReader sum4 = cmd.ExecuteReader();
            while (sum4.Read())
            {
                chart1.Series["갈비만두"].Points.Add(Int32.Parse(sum4["sum(woprodqty)"].ToString()));
            }
            cmd.ExecuteNonQuery();
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

        private void work_main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VIEW_Click(object sender, EventArgs e)
        {
            grid_view();
        }
    }
}
