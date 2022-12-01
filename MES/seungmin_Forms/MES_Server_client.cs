using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES.seungmin_Forms
{
    public partial class MES_Server_client : Form
    {
        private Socket socket;
        private Thread receiveThread;
        private Thread waitThread;

        public MES_Server_client()
        {
            InitializeComponent();
        }

        private void Receive()
        {
            while (true)
            {
                byte[] recvBytes = new byte[1024];
                socket.Receive(recvBytes);
                string txt = Encoding.UTF8.GetString(recvBytes, 0, recvBytes.Length);
                string[] str = txt.Split(',');
                label1.Text = str[0];
                label2.Text = str[1];

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

        private void MES_Server_client_Load(object sender, EventArgs e)
        {
            waitThread = new Thread(wait);
            waitThread.IsBackground = true;
            waitThread.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = Encoding.UTF8.GetBytes("1");
            socket.Send(sendBytes);
        }
    }
}
