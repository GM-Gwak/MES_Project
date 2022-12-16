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
        private string start_time = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
        private string now_time = DateTime.Now.ToString("yyyy-MM-dd");


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

            name_label.Text = rdr["mbname"].ToString();
            string work_name = rdr["mbname"].ToString();

            name_label.Text = work_name.ToString();

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

            main_faulty_chart();
            main_stock_pd();
            main_stock_m();
            
        }
        //생산현황 작업장1 원형 프로그래스바
        public void work_cd1()
        {
            cmd.CommandText = $"SELECT wcstat FROM workcd where wcid = 'wc001'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_cd = rdr["wcstat"].ToString();

            if (work_cd == "P" || work_cd == "N")
            {
                process1.Style = ProgressBarStyle.Blocks;
                process1.ProgressColor = Color.Red;
                process1.Text = "정지";
            }
            else if (work_cd == "O")
            {
                process1.Style = ProgressBarStyle.Marquee;
                process1.ProgressColor = Color.Green;
                process1.Text = "가동 중..";
            }
        }

        //생산현황 작업장2 원형 프로그래스바
        public void work_cd2()
        {
            cmd.CommandText = $"SELECT wcstat FROM workcd where wcid = 'wc002'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_cd2 = rdr["wcstat"].ToString();

            if (work_cd2 == "P" || work_cd2 == "N")
            {
                process2.Style = ProgressBarStyle.Blocks;
                process2.ProgressColor = Color.Red;
                process2.Text = "정지";
            }
            else if (work_cd2 == "O")
            {
                process2.Style = ProgressBarStyle.Marquee;
                process2.ProgressColor = Color.Green;
                process2.Text = "가동 중..";
            }
        }
        //생산현황 작업장3 원형 프로그래스바
        public void work_cd3()
        {
            cmd.CommandText = $"SELECT wcstat FROM workcd where wcid = 'wc003'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_cd3 = rdr["wcstat"].ToString();

            if (work_cd3 == "P" || work_cd3 == "N")
            {
                process3.Style = ProgressBarStyle.Blocks;
                process3.ProgressColor = Color.Red;
                process3.Text = "정지";
            }
            else if (work_cd3 == "O")
            {
                process3.Style = ProgressBarStyle.Marquee;
                process3.ProgressColor = Color.Green;
                process3.Text = "가동 중..";
            }
        }
        //생산현황 작업장4 원형 프로그래스바
        public void work_cd4()
        {
            cmd.CommandText = $"SELECT wcstat FROM workcd where wcid = 'wc004'";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            string work_cd4 = rdr["wcstat"].ToString();

            if (work_cd4 == "P" || work_cd4 == "N")
            {
                process4.Style = ProgressBarStyle.Blocks;
                process4.ProgressColor = Color.Red;
                process4.Text = "정지";
            }
            else if (work_cd4 == "O")
            {
                process4.Style = ProgressBarStyle.Marquee;
                process4.ProgressColor = Color.Green;
                process4.Text = "가동 중..";
            }
        }
        
        //재고현황 완제품
        public void main_stock_pd()
        {
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
        }
        //재고현황 원재료
        public void main_stock_m()
        {
            string[] stock_stqty = new string[16];
            string[] pmname = new string[16];
            int[] bom = new int[16] { 500, 10, 85, 10, 25, 10000, 25, 5, 11500, 50, 50, 50, 50, 25, 2500, 5000 };
            int cnt = 0;
            cmd.CommandText = $"select pd.pmname,sum(stqty) from stock s join pdmaster pd on s.pmid = pd.pmid " +
                              $"where s.pmid like 'm%' group by pd.pmname order by pd.pmname";
            cmd.ExecuteNonQuery();
            rdr = cmd.ExecuteReader();
            int n = 0;
            while (rdr.Read())
            {
                stock_stqty[n] = rdr["sum(stqty)"].ToString();
                pmname[n] = rdr["pmname"].ToString();
                n++;
            }
            string[] stock_name = new string[16];
            for (int i = 0; i < bom.Length; i++)
            {
                if (Double.Parse(stock_stqty[i]) < bom[i])
                {
                    stock_name[cnt] = pmname[i];
                    cnt++;
                }
                else if (cnt == 4)
                {
                    break;
                }
            }
            if (stock_name[0] != null)
            {
                Stock_name1.Text = $"{stock_name[0]} : 재고 부족";
            }
            if (stock_name[1] != null)
            {
                Stock_name2.Text = $"{stock_name[1]} : 재고 부족";
            }
            if (stock_name[2] != null)
            {
                Stock_name3.Text = $"{stock_name[2]} : 재고 부족";
            }
            if (stock_name[3] != null)
            {
                Stock_name4.Text = $"{stock_name[3]} : 재고 부족";
            }
            
        }

        public void main_faulty_chart()
        {
            string faulty_query = "select sum(woprodqty), woendtime,pmname from workorder w join pdmaster pd on(w.pmid= pd.pmid) where pmname like";
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
                string test = str[2];

                cmd.CommandText = $"update workcd set WCOPTIMALTEM = '{str[0]}', WCOPTIMALHUM = '{str[1]}' where wcid = 'wc001'";
                //cmd.CommandText = "commit";
                cmd.ExecuteNonQuery();
                //온습도 센서 값
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
                IPAddress address = IPAddress.Parse("192.168.0.2");
                EndPoint serverEP = new IPEndPoint(address, 9001);

                socket.Connect(serverEP);
                MessageBox.Show("연결되었습니다.");
                socket.Send(Encoding.UTF8.GetBytes("2"));
                receiveThread = new Thread(Receive);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("서버와 연결되지 못하였습니다.");
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
        }
        

        private void QualityManagement_Click(object sender, EventArgs e)
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

        private void StockManagement_Click(object sender, EventArgs e)
        {
           ;
            OpenChildForm(new StockManagement());
        }

        private void WorkOrder_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new WorkOrder());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = Encoding.UTF8.GetBytes("1");
            socket.Send(sendBytes);
        }
        
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Monitoring_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new Monitoring());
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = Encoding.UTF8.GetBytes("1");
            socket.Send(sendBytes);
           
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new test());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            work_cd1();
            work_cd2();
            work_cd3();
            work_cd4();
        }
    }
}
