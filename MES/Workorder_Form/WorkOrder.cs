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
    public partial class WorkOrder : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();

        // 각 폼 그리드 뷰 쿼리
        string main_query = "select distinct(w.WoId) 작업지시ID," +
                    "PMName 제품명," +
                    "LotCreateTime 지시일," +
                    "WoStat 작업상태," +
                    "WoStartTime 시작시간," +
                    "WoEndTime 종료시간," +
                    "WoPlanQty 계획수량," +
                    "WoProdQty 실적," +
                    "WcNowTem 현재온도," +
                    "WcNowHum 현재습도" +
                    " from workorder w, PdMaster m, LOT l where w.PMId = m.PMId and w.WoId = l.WoId";

        string woid;
        string pmname;
        string woid_del;

        public WorkOrder()
        {
            InitializeComponent();
        }

        private void WorkOrder_Load(object sender, EventArgs e)
        {
            WoStartTime.Text = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd");
            WoEndTime.Text = DateTime.Now.ToString("yyyy-MM-dd");

            adapt.SelectCommand = new OracleCommand(main_query + " order by w.woid", conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            WO_GRID.DataSource = ds.Tables[0].DefaultView;

            WO_GRID.Columns[2].Width = 130;
            WO_GRID.Columns[4].Width = 130;
            WO_GRID.Columns[5].Width = 130;
        }

        public void view_workorder(string query, string[] col_name, string[] col_value)
        {
            if (col_value[0] == "")
            {
                if (col_value[1] == "")
                {
                    query += $" and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]} 23:59:59' order by w.Woid";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;

                    WO_GRID.Columns[2].Width = 130;
                    WO_GRID.Columns[4].Width = 130;
                    WO_GRID.Columns[5].Width = 130;
                }
                else
                {
                    query += $" and {col_name[1]} = '{col_value[1]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]} 23:59:59' order by w.Woid";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;

                    WO_GRID.Columns[2].Width = 130;
                    WO_GRID.Columns[4].Width = 130;
                    WO_GRID.Columns[5].Width = 130;
                }
            }
            else
            {
                if (col_value[1] == "")
                {
                    query += $" and {col_name[0]} = '{col_value[0]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]} 23:59:59' order by w.Woid";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;

                    WO_GRID.Columns[2].Width = 130;
                    WO_GRID.Columns[4].Width = 130;
                    WO_GRID.Columns[5].Width = 130;
                }
                else
                {
                    query += $" and {col_name[0]} = '{col_value[0]}' and {col_name[1]} = '{col_value[1]}' and {col_name[2]} >= '{col_value[2]}' and  {col_name[2]} <= '{col_value[3]} 23:59:59' order by w.Woid";
                    adapt.SelectCommand = new OracleCommand(query, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    WO_GRID.DataSource = ds.Tables[0].DefaultView;

                    WO_GRID.Columns[2].Width = 130;
                    WO_GRID.Columns[4].Width = 130;
                    WO_GRID.Columns[5].Width = 130;
                }
            }
        }
        private void WO_GRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            woid = WO_GRID.SelectedRows[0].Cells[0].Value.ToString();
            pmname = WO_GRID.SelectedRows[0].Cells[1].Value.ToString().Substring(0, 4);

            WorkOrder_Detail.wo_num = woid;
            WorkOrder_Detail.wo_pmname = pmname;
        }

        private void WO_Detail_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (woid == null || woid == "")
                {
                    MessageBox.Show("조회할 지시서를 선택해주십시오.");
                    return;
                }
                    WorkOrder_Detail wo_detail_view = new WorkOrder_Detail();
                    wo_detail_view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WO_CREATE_Click_1(object sender, EventArgs e)
        {
            WorkOrder_Create Wo_Create_view = new WorkOrder_Create();
            Wo_Create_view.ShowDialog();
        }

        private void WO_VIEW_Click_1(object sender, EventArgs e)
        {
            string stat = string.Empty;



            if (WoStat.Text == "가동")
            {
                stat = "S";
            }
            else if (WoStat.Text == "완료")
            {
                stat = "E";
            }
            else
            {
                stat = "P";
            }

            // 제품명(콤보박스1), 작업상태(콤보박스2), 최소날짜, 최대날짜
            // 조건이 추가되지 않는 이상 고정
            string[] col_value = new string[] { PMName.Text, stat, WoStartTime.Text, WoEndTime.Text };

            // 조회할 컬럼명 (제품명 컬럼, 작업상태 컬럼, 작업시작시간 컬럼)
            string[] col_name = new string[] { "PMName", "WoStat", "LotCreateTime" };

            // 조회 함수
            view_workorder(main_query, col_name, col_value);

            WoStat.SelectedIndex = -1;
            PMName.SelectedIndex = -1;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            woid_del = WO_GRID.SelectedRows[0].Cells[0].Value.ToString();
            cmd.CommandText = $"delete lot where woid = '{woid_del}'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"delete workorder where woid = '{woid_del}'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"commit";
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
