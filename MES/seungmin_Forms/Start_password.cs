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
    public partial class Start_password : Form
    {
        OracleDataReader rdr;
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        static public bool password_FT;
        static public string ID = Lot1_form.ID;
        string password;

        public Start_password()
        {
            InitializeComponent();
        }
        private void Start_password_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            Password_box.Text = ID;
            cmd.CommandText = $"select MBPW from Member where Mbname = '{ID}'";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            password = rdr["MBPW"] as string;
            MessageBox.Show(password);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (Password_box.Text == password)
            {
                MessageBox.Show("확인되었습니다.");
                password_FT = true;
            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다. 다시 입력해주세요.");
                password_FT = false;
                return;
            }
        }
    }
}
