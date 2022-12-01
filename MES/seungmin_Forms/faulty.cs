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
    public partial class faulty : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr ;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        public faulty()
        {
            InitializeComponent();
        }

        private void faulty_Load(object sender, EventArgs e)
        {
            date_1.Text = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd");
            date_2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            conn.Open();
            cmd.Connection = conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 차트
                chart1.Series["고기만두"].Points.Clear();
                chart1.Series["김치만두"].Points.Clear();
                chart1.Series["갈비만두"].Points.Clear();
                chart1.Series["총 합"].Points.Clear();

                cmd.CommandText = $"select sum(faqty), lotendtime, pmid from faulty f, lot l, workorder w where f.lotid = l.lotid and l.wcid = w.wcid and lotendtime between '{date_1.Value.ToString("yyyy-MM-dd")}' and '{date_2.Value.ToString("yyyy-MM-dd")}' group by lotendtime,pmid";
                OracleDataReader sum1 = cmd.ExecuteReader();
                while (sum1.Read())
                {
                    chart1.Series["총 합"].Points.AddXY(sum1["lotendtime"].ToString(), Int32.Parse(sum1["sum(faqty)"].ToString()));
                }
                cmd.CommandText = $"select sum(faqty), lotendtime, pmid from faulty f, lot l, workorder w where f.lotid = l.lotid and l.wcid = w.wcid and lotendtime between '{date_1.Value.ToString("yyyy-MM-dd")}' and '{date_2.Value.ToString("yyyy-MM-dd")}'and pmid = 'PMe01' group by lotendtime,pmid";
                OracleDataReader sum2 = cmd.ExecuteReader();
                while (sum2.Read())
                {
                    chart1.Series["고기만두"].Points.Add(Int32.Parse(sum2["sum(faqty)"].ToString()));
                }
                cmd.CommandText = $"select sum(faqty), lotendtime, pmid from faulty f, lot l, workorder w where f.lotid = l.lotid and l.wcid = w.wcid and lotendtime between '{date_1.Value.ToString("yyyy-MM-dd")}' and '{date_2.Value.ToString("yyyy-MM-dd")}'and pmid = 'PMe02' group by lotendtime,pmid";
                OracleDataReader sum3 = cmd.ExecuteReader();
                while (sum3.Read())
                {
                    chart1.Series["김치만두"].Points.Add(Int32.Parse(sum3["sum(faqty)"].ToString()));
                }
                cmd.CommandText = $"select sum(faqty), lotendtime, pmid from faulty f, lot l, workorder w where f.lotid = l.lotid and l.wcid = w.wcid and lotendtime between '{date_1.Value.ToString("yyyy-MM-dd")}' and '{date_2.Value.ToString("yyyy-MM-dd")}'and pmid = 'PMe03' group by lotendtime,pmid";
                OracleDataReader sum4 = cmd.ExecuteReader();
                while (sum4.Read())
                {
                    chart1.Series["갈비만두"].Points.Add(Int32.Parse(sum4["sum(faqty)"].ToString()));
                }

                cmd.CommandText = "commit";
                cmd.ExecuteNonQuery();
            }

            catch (Exception)
            {
                MessageBox.Show("Date 설정 똑바로해요~!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faulty_Detail faulty_detail = new faulty_Detail();
            faulty_detail.Show();
        }
    }
}
