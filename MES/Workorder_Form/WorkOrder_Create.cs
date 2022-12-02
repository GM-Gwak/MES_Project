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

namespace MES.Workorder_Form
{
    public partial class WorkOrder_Create : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        public WorkOrder_Create()
        {
            InitializeComponent();
        }

        private void Workorder_Create_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
        }
        private void ok_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"insert into WorkOrder values" +
               $"('Wo'||trim(to_char(WorkOrder_seq.nextval,'00000')), " +
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
            $"('L' || to_char(sysdate, 'yymmdd') || 1 || trim(to_char(LOT_seq.nextval, '0000')), " +
            $"(select max(woid) from workorder), " +
            $"to_char(sysdate, 'yyyy-mm-dd-hh24:mi:ss'), " +
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
                    $"('L' || to_char(sysdate, 'yymmdd') || {i} || trim(to_char(LOT_seq.currval, '0000')), " +
                    $"(select max(woid) from workorder), " +
                    $"to_char(sysdate, 'yyyy-mm-dd-hh24:mi:ss'), " +
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
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
