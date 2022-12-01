using System;
using System.Collections.Generic;
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
    public partial class Login : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr ;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        static string id_text;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        private void Login_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = $"SELECT id,password,grade FROM login WHERE id = '{txtuser.Text}' and password = '{txtPassworld.Text}'";
                cmd.ExecuteNonQuery();
                rdr = cmd.ExecuteReader();
                rdr.Read();

                string grade = rdr["grade"].ToString();
                string id_text = rdr["id"].ToString();
                if (grade == "manager")   // 관리자 페이지 전환
                {
                    this.Visible = false;   // 현재 폼 보이지 않게 하기
                    mainform mainform = new mainform(id_text);
                    mainform.ShowDialog(); // 폼 전환
                }
            }
            catch (Exception)
            {
                MessageBox.Show("계정을 확인해주세요.");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "UserId")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "UserId";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassworld_Enter(object sender, EventArgs e)
        {
            if (txtPassworld.Text == "UserPassworld")
            {
                txtPassworld.Text = "";
                txtPassworld.ForeColor = Color.LightGray;
                txtPassworld.UseSystemPasswordChar = true;
            }
        }

        private void txtPassworld_Leave(object sender, EventArgs e)
        {
            if (txtPassworld.Text == "")
            {
                txtPassworld.Text = "UserPassworld";
                txtPassworld.ForeColor = Color.LightGray;
                txtPassworld.UseSystemPasswordChar = false;
            }
        }
    }
}
