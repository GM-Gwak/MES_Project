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

namespace MES.UI
{
    public partial class Monitoring : Form
    {
        OracleCommand cmd = new OracleCommand();
        OracleConnection conn = new OracleConnection(strConn);
        static string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=hr;Password=hr;";
        OracleDataAdapter adapt = new OracleDataAdapter();
        OracleDataReader rdr;

        private void UI_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = $"select wostat from workorder where wostat = 'S' and rownum = 1";
            rdr = cmd.ExecuteReader();
            rdr.Read();

            if (rdr["wostat"].ToString() == "S")
            {
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;
                pictureBox27.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
            }
            else
            {
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
                pictureBox26.Visible = false;
                pictureBox27.Visible = false;
                pictureBox28.Visible = false;
                pictureBox29.Visible = false;
            }
        }
        
        // 배경 투명
        public Monitoring()
        {
            InitializeComponent();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Parent = pictureMain;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureMain;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureMain;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureMain;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureMain;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureMain;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Parent = pictureMain;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Parent = pictureMain;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Parent = pictureMain;
            pictureBox19.BackColor = Color.Transparent;
            pictureBox19.Parent = pictureMain;
            pictureBox21.BackColor = Color.Transparent;
            pictureBox21.Parent = pictureMain;

            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Parent = pictureMain;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.Parent = pictureMain;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.Parent = pictureMain;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Parent = pictureMain;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.Parent = pictureMain;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.Parent = pictureMain;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox16.Parent = pictureMain;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox17.Parent = pictureMain;
            pictureBox18.BackColor = Color.Transparent;
            pictureBox18.Parent = pictureMain;
            pictureBox20.BackColor = Color.Transparent;
            pictureBox20.Parent = pictureMain;
            pictureBox22.BackColor = Color.Transparent;
            pictureBox22.Parent = pictureMain;
            pictureBox23.BackColor = Color.Transparent;
            pictureBox23.Parent = pictureMain;
            pictureBox24.BackColor = Color.Transparent;
            pictureBox24.Parent = pictureMain;
            pictureBox25.BackColor = Color.Transparent;
            pictureBox25.Parent = pictureMain;
            pictureBox26.BackColor = Color.Transparent;
            pictureBox26.Parent = pictureMain;
            pictureBox27.BackColor = Color.Transparent;
            pictureBox27.Parent = pictureMain;
            pictureBox28.BackColor = Color.Transparent;
            pictureBox28.Parent = pictureMain;
            pictureBox29.BackColor = Color.Transparent;
            pictureBox29.Parent = pictureMain;
            // 이미지 숨기기
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox20.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
        }

        // 마우스 이벤트

        private void pic1_mm(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox10.Visible = true;
            pictureBox1.Image = Properties.Resources.재료1;
            pictureBox2.Visible = false;
            pictureBox11.Visible = true;
            pictureBox2.Image = Properties.Resources.분쇄;
            pictureBox3.Visible = false;
            pictureBox12.Visible = true;
            pictureBox3.Image = Properties.Resources.혼합1;
            pictureBox4.Visible = false;
            pictureBox13.Visible = true;
            pictureBox4.Image = Properties.Resources.혼합0;
        }

        private void pic1_ml(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox10.Visible = false;
            pictureBox1.Image = Properties.Resources.재료;
            pictureBox2.Visible = true;
            pictureBox11.Visible = false;
            pictureBox2.Image = Properties.Resources.분쇄1;
            pictureBox3.Visible = true;
            pictureBox12.Visible = false;
            pictureBox3.Image = Properties.Resources.혼합10;
            pictureBox4.Visible = true;
            pictureBox13.Visible = false;
            pictureBox4.Image = Properties.Resources.혼합01;

        }

        private void pic2_mm(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox10.Visible = true;
            pictureBox1.Image = Properties.Resources.재료1;
            pictureBox2.Visible = false;
            pictureBox11.Visible = true;
            pictureBox2.Image = Properties.Resources.분쇄;
            pictureBox3.Visible = false;
            pictureBox12.Visible = true;
            pictureBox3.Image = Properties.Resources.혼합1;
            pictureBox4.Visible = false;
            pictureBox13.Visible = true;
            pictureBox4.Image = Properties.Resources.혼합0;
        }

        private void pic2_ml(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox10.Visible = false;
            pictureBox1.Image = Properties.Resources.재료;
            pictureBox2.Visible = true;
            pictureBox11.Visible = false;
            pictureBox2.Image = Properties.Resources.분쇄1;
            pictureBox3.Visible = true;
            pictureBox12.Visible = false;
            pictureBox3.Image = Properties.Resources.혼합10;
            pictureBox4.Visible = true;
            pictureBox13.Visible = false;
            pictureBox4.Image = Properties.Resources.혼합01;
        }
        private void pic3_mm(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox10.Visible = true;
            pictureBox1.Image = Properties.Resources.재료1;
            pictureBox2.Visible = false;
            pictureBox11.Visible = true;
            pictureBox2.Image = Properties.Resources.분쇄;
            pictureBox3.Visible = false;
            pictureBox12.Visible = true;
            pictureBox3.Image = Properties.Resources.혼합1;
            pictureBox4.Visible = false;
            pictureBox13.Visible = true;
            pictureBox4.Image = Properties.Resources.혼합0;
        }

        private void pic3_ml(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox10.Visible = false;
            pictureBox1.Image = Properties.Resources.재료;
            pictureBox2.Visible = true;
            pictureBox11.Visible = false;
            pictureBox2.Image = Properties.Resources.분쇄1;
            pictureBox3.Visible = true;
            pictureBox12.Visible = false;
            pictureBox3.Image = Properties.Resources.혼합10;
            pictureBox4.Visible = true;
            pictureBox13.Visible = false;
            pictureBox4.Image = Properties.Resources.혼합01;
        }

        private void pic4_mm(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox10.Visible = true;
            pictureBox1.Image = Properties.Resources.재료1;
            pictureBox2.Visible = false;
            pictureBox11.Visible = true;
            pictureBox2.Image = Properties.Resources.분쇄;
            pictureBox3.Visible = false;
            pictureBox12.Visible = true;
            pictureBox3.Image = Properties.Resources.혼합1;
            pictureBox4.Visible = false;
            pictureBox13.Visible = true;
            pictureBox4.Image = Properties.Resources.혼합0;
        }

        private void pic4_ml(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox10.Visible = false;
            pictureBox1.Image = Properties.Resources.재료;
            pictureBox2.Visible = true;
            pictureBox11.Visible = false;
            pictureBox2.Image = Properties.Resources.분쇄1;
            pictureBox3.Visible = true;
            pictureBox12.Visible = false;
            pictureBox3.Image = Properties.Resources.혼합10;
            pictureBox4.Visible = true;
            pictureBox13.Visible = false;
            pictureBox4.Image = Properties.Resources.혼합01;
        }

        private void pic5_mm(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox14.Visible = true;
            pictureBox5.Image = Properties.Resources.틀1;
            pictureBox6.Visible = false;
            pictureBox15.Visible = true;
            pictureBox6.Image = Properties.Resources.틀0;
            pictureBox19.Visible = false;
            pictureBox20.Visible = true;
            pictureBox19.Image = Properties.Resources.틀0;
            pictureBox21.Visible = false;
            pictureBox22.Visible = true;
            pictureBox21.Image = Properties.Resources.틀1;

        }

        private void pic5_ml(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox14.Visible = false;
            pictureBox5.Image = Properties.Resources.틀10;
            pictureBox6.Visible = true;
            pictureBox15.Visible = false;
            pictureBox6.Image = Properties.Resources.틀01;
            pictureBox19.Visible = true;
            pictureBox20.Visible = false;
            pictureBox19.Image = Properties.Resources.틀01;
            pictureBox21.Visible = true;
            pictureBox22.Visible = false;
            pictureBox21.Image = Properties.Resources.틀10;
        }

        private void pic6_mm(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox14.Visible = true;
            pictureBox5.Image = Properties.Resources.틀1;
            pictureBox6.Visible = false;
            pictureBox15.Visible = true;
            pictureBox6.Image = Properties.Resources.틀0;
            pictureBox19.Visible = false;
            pictureBox20.Visible = true;
            pictureBox19.Image = Properties.Resources.틀0;
            pictureBox21.Visible = false;
            pictureBox22.Visible = true;
            pictureBox21.Image = Properties.Resources.틀1;
        }

        private void pic6_ml(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox14.Visible = false;
            pictureBox5.Image = Properties.Resources.틀10;
            pictureBox6.Visible = true;
            pictureBox15.Visible = false;
            pictureBox6.Image = Properties.Resources.틀01;
            pictureBox19.Visible = true;
            pictureBox20.Visible = false;
            pictureBox19.Image = Properties.Resources.틀01;
            pictureBox21.Visible = true;
            pictureBox22.Visible = false;
            pictureBox21.Image = Properties.Resources.틀10;
        }

        private void pic19_mm(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox14.Visible = true;
            pictureBox5.Image = Properties.Resources.틀1;
            pictureBox6.Visible = false;
            pictureBox15.Visible = true;
            pictureBox6.Image = Properties.Resources.틀0;
            pictureBox19.Visible = false;
            pictureBox20.Visible = true;
            pictureBox19.Image = Properties.Resources.틀0;
            pictureBox21.Visible = false;
            pictureBox22.Visible = true;
            pictureBox21.Image = Properties.Resources.틀1;
        }

        private void pic19_ml(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox14.Visible = false;
            pictureBox5.Image = Properties.Resources.틀10;
            pictureBox6.Visible = true;
            pictureBox15.Visible = false;
            pictureBox6.Image = Properties.Resources.틀01;
            pictureBox19.Visible = true;
            pictureBox20.Visible = false;
            pictureBox19.Image = Properties.Resources.틀01;
            pictureBox21.Visible = true;
            pictureBox22.Visible = false;
            pictureBox21.Image = Properties.Resources.틀10;
        }

        private void pic21_mm(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox14.Visible = true;
            pictureBox5.Image = Properties.Resources.틀1;
            pictureBox6.Visible = false;
            pictureBox15.Visible = true;
            pictureBox6.Image = Properties.Resources.틀0;
            pictureBox19.Visible = false;
            pictureBox20.Visible = true;
            pictureBox19.Image = Properties.Resources.틀0;
            pictureBox21.Visible = false;
            pictureBox22.Visible = true;
            pictureBox21.Image = Properties.Resources.틀1;
        }

        private void pic21_ml(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox14.Visible = false;
            pictureBox5.Image = Properties.Resources.틀10;
            pictureBox6.Visible = true;
            pictureBox15.Visible = false;
            pictureBox6.Image = Properties.Resources.틀01;
            pictureBox19.Visible = true;
            pictureBox20.Visible = false;
            pictureBox19.Image = Properties.Resources.틀01;
            pictureBox21.Visible = true;
            pictureBox22.Visible = false;
            pictureBox21.Image = Properties.Resources.틀10;
        }

        private void pic7_mm(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox16.Visible = true;
            pictureBox7.Image = Properties.Resources.자숙;
            pictureBox8.Visible = false;
            pictureBox17.Visible = true;
            pictureBox8.Image = Properties.Resources.냉각;
        }

        private void pic7_ml(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox16.Visible = false;
            pictureBox7.Image = Properties.Resources.자숙1;
            pictureBox8.Visible = true;
            pictureBox17.Visible = false;
            pictureBox8.Image = Properties.Resources.냉각1;
        }

        private void pic8_mm(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox16.Visible = true;
            pictureBox7.Image = Properties.Resources.자숙;
            pictureBox8.Visible = false;
            pictureBox17.Visible = true;
            pictureBox8.Image = Properties.Resources.냉각;
        }

        private void pic8_ml(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox16.Visible = false;
            pictureBox7.Image = Properties.Resources.자숙1;
            pictureBox8.Visible = true;
            pictureBox17.Visible = false;
            pictureBox8.Image = Properties.Resources.냉각1;
        }

        private void pic9_mm(object sender, MouseEventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox18.Visible = true;
            pictureBox9.Image = Properties.Resources.포장1;
        }

        private void pic9_ml(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox18.Visible = false;
            pictureBox9.Image = Properties.Resources.포장2;
        }


        /* delay 함수
         Delay 합수
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }
        */
    }


}

