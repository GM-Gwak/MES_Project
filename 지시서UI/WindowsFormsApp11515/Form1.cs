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

namespace WindowsFormsApp11515
{

    public partial class WO : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleDataReader rdr;
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        // 각 폼 그리드 뷰 쿼리
        string main_query = "select w.WoId 작업지시ID," +
                    "PMName 제품명," +
                    "LotCreateTime 지시일," +
                    "WoStat 작업상태," +
                    "WoStartTime 시작시간," +
                    "WoEndTime 종료시간," +
                    "WoPlanQty 계획수량," +
                    "WoProdQty 현재수량," +
                    "MbNo 담당자," +
                    "WcNowTem 현재온도," +
                    "WcNowHum 현재습도" +
                    " from workorder w, PdMaster m, LOT l where w.PMId = m.PMId and w.WoId = l.WoId";
        public WO()
        {
            InitializeComponent();
        }

        private void WO_VIEW_Click(object sender, EventArgs e)
        {

            // 제품명(콤보박스1), 작업상태(콤보박스2), 최소날짜, 최대날짜
            // 조건이 추가되지 않는 이상 고정
            string[] col_value = new string[] { PMName.Text, WoStat.Text, WoStartTime.Text, WoEndTime.Text};

            // 조회할 컬럼명 (제품명 컬럼, 작업상태 컬럼, 작업시작시간 컬럼)
            string[] col_name = new string[] {"PMName", "WoStat", "LotCreateTime"};

            // 조회 함수
            view(main_query, col_name, col_value);
        }

        private void WO_Load(object sender, EventArgs e)
        {
            WoStartTime.Text = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd");
            WoEndTime.Text = DateTime.Now.ToString("yyyy-MM-dd");

            adapt.SelectCommand = new OracleCommand(main_query, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            WO_GRID.DataSource = ds.Tables[0].DefaultView;
        }



        public void view(string query, string[] col_name, string[] col_value)
        {
            if (col_value[0] == "")
            {
                if (col_value[1] == "")
                {
                    query += $" and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}-23:59:59'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {
                    query += $" and {col_name[1]} = '{col_value[1]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}-23:59:59'";
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
                    query += $" and {col_name[0]} = '{col_value[0]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}-23:59:59'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
                else
                {
                    query += $" and {col_name[0]} = '{col_value[0]}' and {col_name[1]} = '{col_value[1]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]}-23:59:59'";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }
    }
}
