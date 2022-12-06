using System;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MES.seungmin_Forms
{
    public partial class faulty_Detail : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        // 각 폼 그리드 뷰 쿼리
        string main_query = "select f.faid, f.lotid, w.pmid, l.wcid, f.faqty, m.faname, l.lotendtime, l.mbno" +
                            " from faulty f, faultymaster m, lot l, workorder w" +
                            " where f.faid = m.faid and f.lotid = l.lotid and l.woid = w.woid";
        public faulty_Detail()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        private void faulty_Detail_Load(object sender, EventArgs e)
        {
            StartTime.Text = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd");
            EndTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
            adapt.SelectCommand = new OracleCommand(main_query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            WO_GRID.DataSource = ds.Tables[0].DefaultView;
        }

        private void WO_VIEW_Click(object sender, EventArgs e)
        {
            // 제품명(콤보박스1), 작업상태(콤보박스2), 최소날짜, 최대날짜
            // 조건이 추가되지 않는 이상 고정
            string[] col_value = new string[] { PMName.Text, Wofact.Text, StartTime.Text, EndTime.Text };

            // 조회할 컬럼명 (제품명 컬럼, 작업장 컬럼, 작업시작시간 컬럼)
            string[] col_name = new string[] { "w.pmid", "l.wcid", "l.lotendtime" };

            // 조회 함수
            view(main_query, col_name, col_value);
        }
        public void view(string query, string[] col_name, string[] col_value)
        {
            if (col_value[0] == "")
            {
                if (col_value[1] == "")
                {
                    query += $" and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {
                    query += $" and {col_name[1]} = '{col_value[1]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
            }
            else
            {
                if (col_value[1] == "")
                {
                    query += $" and {col_name[0]} = '{col_value[0]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {
                    query += $" and {col_name[0]} = '{col_value[0]}' and {col_name[1]} = '{col_value[1]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
