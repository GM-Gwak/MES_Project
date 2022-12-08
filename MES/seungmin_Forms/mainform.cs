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
using MES.Workorder_Form;
using MES.UI;

namespace MES
{
    public partial class mainform : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleDataReader rdr2;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        static string mes;

        private Socket socket;
        private Thread receiveThread;
        private Thread waitThread;
        private Thread pdThread;
        private Form currentChildForm;
        private int borderSize = 2;
       
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private string start_time = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
        private string now_time = DateTime.Now.ToString("yyyy-MM-dd");
        private int WoPlanQty = 0;

        public mainform()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize); //border size
            this.BackColor = Color.FromArgb(98, 102, 244); //border color
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        public mainform(string data)
        {
            InitializeComponent();

            mes = data;
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

            cmd.CommandText = $"SELECT mbname FROM member WHERE mbId = '{mes}'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_name = rdr["mbname"].ToString();
            name_label.Text = work_name.ToString();

            string[] stqty = new string[3];
            cmd.CommandText = $"SELECT sum(stqty) FROM stock s join pdmaster pd on s.pmid = pd.pmid WHERE s.pmid like 'p%' group by pmname";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                stqty[i] = rdr["sum(stqty)"].ToString();
                i++;
            }
            Meat.Text = stqty[0];
            Kimchi.Text = stqty[1];
            Galbi.Text = stqty[2];


            // 불량수량 라벨
            cmd.CommandText = $"select sum(faqty), faname from faulty f join faultymaster m on(f.faid = m.faid) group by faname";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr["faname"].ToString() == "재단 상태 불량")
                {
                    foundation_label.Text = rdr["sum(faqty)"].ToString();
                }
                else if (rdr["faname"].ToString() == "익힘 상태 불량")
                {
                    cook_label.Text = rdr["sum(faqty)"].ToString();
                }
                else if (rdr["faname"].ToString() == "중금속 불량")
                {
                    metal_label.Text = rdr["sum(faqty)"].ToString();
                }
                else if (rdr["faname"].ToString() == "무게 불량")
                {
                    weight_label.Text = rdr["sum(faqty)"].ToString();
                }
            }

            waitThread = new Thread(wait);
            waitThread.IsBackground = true;
            waitThread.Start();

            pdThread = new Thread(work_cd1);
            pdThread.IsBackground = true;
            pdThread.Start();

            main_faulty_chart();
            main_stock();
            //work_cd1();
            
        }
        public void work_cd1()
        {

           
            

        }
        public void main_stock()
        {
            string[] stock_stqty = new string[16];
            cmd.CommandText = $"select pd.pmname,sum(stqty) from stock s join pdmaster pd on s.pmid = pd.pmid where s.pmid like 'm%' group by pd.pmname order by pd.pmname";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            int n = 0;
            while (rdr.Read())
            {
                stock_stqty[n++] = rdr["sum(stqty)"].ToString();
            }

            string[] pmname = new string[16];
            string[] bomqty = new string[16];
            cmd.CommandText = $"select distinct pmname, bomqty from bom b join pdmaster pd on b.pmid = pd.pmid order by bomqty";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            int k = 0;
            while (rdr.Read())
            {
                pmname[k] = rdr["pmname"].ToString();
                bomqty[k] = rdr["bomqty"].ToString();
                //MessageBox.Show(pmname[k], bomqty[k]);
                k++;    
            }
            
            for(int i = 0; i < 16; i++)
            {
                
            }
            
        }

        public void main_faulty_chart()
        {
            string faulty_query = "select sum(woprodqty), woendtime,pmname from workorder w join pdmaster pd on(w.pmid= pd.pmid) where pmname like";
            // 차트
            chart1.Series["고기만두"].Points.Clear();
            chart1.Series["김치만두"].Points.Clear();
            chart1.Series["갈비만두"].Points.Clear();
            chart1.Series["예측치"].Points.Clear();

            cmd.CommandText = $"select woendtime, sum(woplanqty), pmname from workorder w join pdmaster pd on(w.pmid = pd.pmid) group by woendtime, pmname";
            OracleDataReader sum1 = cmd.ExecuteReader();
            while (sum1.Read())
            {
                chart1.Series["예측치"].Points.AddXY(sum1["woendtime"].ToString(), Int32.Parse(sum1["sum(woplanqty)"].ToString()));
            }
            cmd.CommandText = faulty_query + $" '고기%' and woendtime between '{start_time}' and '{now_time}' group by woendtime,pmname";
            OracleDataReader sum2 = cmd.ExecuteReader();
            while (sum2.Read())
            {
                chart1.Series["고기만두"].Points.Add(Int32.Parse(sum2["sum(woprodqty)"].ToString()));
            }
            cmd.CommandText = faulty_query + $" '김치%' and woendtime between '{start_time}' and '{now_time}' group by woendtime,pmname";
            OracleDataReader sum3 = cmd.ExecuteReader();
            while (sum3.Read())
            {
                chart1.Series["김치만두"].Points.Add(Int32.Parse(sum3["sum(woprodqty)"].ToString()));
            }
            cmd.CommandText = faulty_query+$" '갈비%' and woendtime between '{start_time}' and '{now_time}' group by woendtime,pmname";
            OracleDataReader sum4 = cmd.ExecuteReader();
            while (sum4.Read())
            {
                chart1.Series["갈비만두"].Points.Add(Int32.Parse(sum4["sum(woprodqty)"].ToString()));
            }
            cmd.ExecuteNonQuery();
            
        }

        private void Receive()
        {
            while (true)
            {
                byte[] recvBytes = new byte[1024];
                socket.Receive(recvBytes);
                string txt = Encoding.UTF8.GetString(recvBytes, 0, recvBytes.Length);
                string[] str = txt.Split(',');
                if (Temp.InvokeRequired == true)
                {
                    Temp.Invoke(new MethodInvoker(delegate { Temp.Text = str[0]; }));
                    Hum.Invoke(new MethodInvoker(delegate { Hum.Text = str[1]; }));
                }
                else
                {
                    Temp.Text = str[0];
                    Hum.Text = str[1];
                }
                

            }
        }
        private void wait()
        {
            try
            {
                //1.소켓만들기
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //2.연결
                IPAddress address = IPAddress.Parse("192.168.0.4");
                EndPoint serverEP = new IPEndPoint(address, 9001);

                socket.Connect(serverEP);
                MessageBox.Show("연결되었습니다.");
                socket.Send(Encoding.UTF8.GetBytes("2"));
                receiveThread = new Thread(Receive);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버와 연결되지 못하였습니다.");
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
            //ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new WorkOrder());
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
            try
            {
                currentChildForm.Close();
            }
            catch(Exception)
            {
                
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Monitoring());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = Encoding.UTF8.GetBytes("1");
            socket.Send(sendBytes);
        }

        
    }
}
