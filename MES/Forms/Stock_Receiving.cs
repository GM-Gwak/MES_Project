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

namespace MES
{
    public partial class Stock_Receiving : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr ;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        DataSet ds = new DataSet();
        public Stock_Receiving()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        private void Stock_Receiving_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            comboBox1.Focus();
            comboBox1.SelectedIndex = 0;
        }

        private void ST_Rec_OK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = $"select PMId from PdMaster where PMName = '{comboBox1.SelectedItem}'";
                rdr = cmd.ExecuteReader();
                rdr.Read();
                string id = rdr["PMId"].ToString();

                cmd.CommandText = $"insert into Stock(StId, StDate, StQty, PMId) values('St'||trim(to_char(Stock_seq.nextval,'000')),'{dateTimePicker1.Text}',{textBox1.Text},'{id}')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("완료되었습니다.", "알림");
            }
            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message,"알림");
            }
        }

        private void ST_Re_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ST_Rec_OK.Focus();
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }
    }
}
