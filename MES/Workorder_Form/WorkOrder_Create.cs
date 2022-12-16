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

namespace MES.Workorder_Form
{
    public partial class WorkOrder_Create : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);



        public WorkOrder_Create()
        {
            InitializeComponent();
        }

        private void Workorder_Create_Load(object sender, EventArgs e)
        {
        }
        public void OK_Func()
        {
            try
            {

                if (PD.Text == "" || PD.Text == null)
                {
                    MessageBox.Show("품목을 선택하세요.");
                    PD.Focus();
                    PD.Select();
                    return;
                }

                if (EA.Text == "" || EA.Text == null)
                {
                    MessageBox.Show("수량을 입력하세요.");
                    EA.Focus();
                    EA.Select();
                    return;
                }

                if (Int32.Parse(EA.Text) < Int32.Parse("100") || Int32.Parse(EA.Text) > Int32.Parse("10000"))
                {
                    MessageBox.Show("수량이 너무 크거나 작습니다.");
                    EA.Focus();
                    EA.SelectAll();
                    return;
                }
                
                if (EA.Text.All(char.IsDigit) == false)
                {
                    MessageBox.Show("수량이 적합하지 않습니다.");
                    EA.Focus();
                    EA.SelectAll();
                    return;
                }

                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = $"insert into WorkOrder values" +
                $"('wo'||trim(to_char(WorkOrder_seq.nextval,'00000')), " +
                $"'{PD.Text}', " +
                $"'P', " +
                $"null, " +
                $"null, " +
                $"{EA.Text}, " +
                $"null, " +
                $"25, " +
                $"10)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Commit";
                cmd.ExecuteNonQuery();


                cmd.CommandText = $"insert into LOT values" +
                $"('l' || to_char(sysdate, 'yymmdd') || 1 || trim(to_char(LOT_seq.nextval, '0000')), " +
                $"(select max(woid) from workorder), " +
                $"to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), " +
                $"null, " +
                $"null, " +
                $"'P', " +
                $"null, " +
                $"null, " +
                $"null)";
                cmd.ExecuteNonQuery();

                for (int i = 2; i < 5; i++)
                {
                    cmd.CommandText = $"insert into LOT values" +
                    $"('l' || to_char(sysdate, 'yymmdd') || {i} || trim(to_char(LOT_seq.currval, '0000')), " +
                    $"(select max(woid) from workorder), " +
                    $"to_char(sysdate, 'yyyy-mm-dd hh24:mi:ss'), " +
                    $"null, " +
                    $"null, " +
                    $"'P', " +
                    $"null, " +
                    $"null, " +
                    $"null)";

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("완료");
                cmd.CommandText = "Commit";
                cmd.ExecuteNonQuery();

                this.Close();

                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void ok_Click_1(object sender, EventArgs e)
        {
            OK_Func();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void WO_LABEL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PD_SelectedIndexChanged(object sender, EventArgs e)
        {
            EA.Focus();
        }

        private void EA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ok.Focus();
            }
        }
    }
}