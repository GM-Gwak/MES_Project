using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES.seungmin_Forms;
namespace MES
{
    public partial class mainform : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        private Form currentChildForm;
        private int borderSize = 2;

        public mainform()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(98, 102, 244); //border color
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void mainform_Load(object sender, EventArgs e)
        {
            timer1.Start();
            conn.Open();
            cmd.Connection = conn;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu(); // Sliding Menu
        }
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)  // Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                label1.Visible = false;
                time_label.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else // Expand menu
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                time_label.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }

        private void 품질관리_Click(object sender, EventArgs e)
        {
            OpenChildForm(new faulty());
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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StockManagement());
        }
    }
}
