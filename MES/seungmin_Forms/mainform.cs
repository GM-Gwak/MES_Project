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
using FontAwesome.Sharp;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace MES
{
    public partial class mainform : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        static string mes;

        private Socket socket;
        private Thread receiveThread;
        private Thread waitThread;

        private Form currentChildForm;
        private int borderSize = 2;
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public mainform()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(98, 102, 244); //border color
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderBtn);
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
            waitThread = new Thread(wait);
            waitThread.IsBackground = true;
            waitThread.Start();

            cmd.CommandText = $"SELECT user_name FROM login WHERE id = '{mes}'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_name = rdr["user_name"].ToString();
            name_label.Text = work_name.ToString();
        }
        private void Receive()
        {
            while (true)
            {
                byte[] recvBytes = new byte[1024];
                socket.Receive(recvBytes);
                string txt = Encoding.UTF8.GetString(recvBytes, 0, recvBytes.Length);
                string[] str = txt.Split(',');
                label6.Text = str[0];
                label7.Text = str[1];

            }
        }
        private void wait()
        {
            try
            {
                //1.소켓만들기
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //2.연결
                IPAddress address = IPAddress.Parse("192.168.0.17");
                EndPoint serverEP = new IPEndPoint(address, 9001);

                socket.Connect(serverEP);
                MessageBox.Show("연결됨");
                socket.Send(Encoding.UTF8.GetBytes("2"));
                receiveThread = new Thread(Receive);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
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
                name_label.Visible = false;
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
                name_label.Visible = true;
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
        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 71, 80);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
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
        public mainform(string data)
        {
            InitializeComponent();

            mes = data;
        }

        private void 품질관리_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color1);
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
            //ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new StockManagement());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = Encoding.UTF8.GetBytes("1");
            socket.Send(sendBytes);
        }
        //11111
        private void iconButton1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }
    }
}
