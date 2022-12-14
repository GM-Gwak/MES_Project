using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Design_v3._0.Properties;

namespace UI_Design_v3._0
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 배경 투명
        public Form1()
        {
            InitializeComponent();

            /*
            for(int i=1; i<=10; i++)
            {
                picBoxColor(i);
            }
             */
            
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
        }


        /*
        public void picBoxColor(int _inch)
        {
            try
            {
                var picBox = Controls
                   .OfType<PictureBox>()
                   .Where(pib => pib.Name == "pictureBox" + _inch.ToString())
                   .First();

                picBox.BackColor = Color.Transparent;
                picBox.Parent = pictureMain;
            }
            catch (Exception ex)
            {

            }
        }
        */

        // 폼 불러오기
        private void workplace1_Click(object sender, EventArgs e)
        {
            Workplace1 workplace1 = new Workplace1();
            workplace1.Show();
        }

        private void workplace2_Click(object sender, EventArgs e)
        {
            Workplace2 workplace2 = new Workplace2();
            workplace2.Show();
        }

        private void workplace3_Click(object sender, EventArgs e)
        {
            Workplace3 workplace3 = new Workplace3();
            workplace3.Show();
        }

        private void workplace4_Click(object sender, EventArgs e)
        {
            Workplace4 workplace4 = new Workplace4();
            workplace4.Show();
        }


        // 프로그레스바
        public void btn1()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        public void btn2()
        {
            if (timer2.Enabled)
            {
                timer2.Stop();
            }
            else
            {
                timer2.Start();
            }
        }
        public void btn3()
        {
            if (timer3.Enabled)
            {
                timer3.Stop();
            }
            else
            {
                timer3.Start();
            }
        }
        public void btn4()
        {
            if (timer4.Enabled)
            {
                timer4.Stop();
            }
            else
            {
                timer4.Start();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn1();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            btn2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn4();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                //MessageBox.Show("제1공정 완료");
                progressBar1.Value = 0;
                btn2();
            }
            else
            {
                progressBar1.Value += 1;
                ps_2.Text = progressBar1.Value.ToString() + " %";
                if (progressBar1.Value == 100)
                {
                    ps_2.Text ="0%";
                }                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                //MessageBox.Show("제2공정 완료");
                progressBar2.Value = 0;
                btn3();
            }
            else
            {
                progressBar2.Value += 1;
                ps_4.Text = progressBar2.Value.ToString() + " %";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                //MessageBox.Show("제3공정 완료");
                progressBar3.Value = 0;
                btn4();
            }
            else
            {
                progressBar3.Value += 1;
                ps_6.Text = progressBar3.Value.ToString() + " %";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                //MessageBox.Show("제4공정 완료");
                progressBar4.Value = 0;
            }
            else
            {
                progressBar4.Value += 1;
                ps_8.Text = progressBar4.Value.ToString() + " %";
            }
        }

        // 전체 실행
        private void button5_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value == 0)
            {
                btn1();
                if(progressBar1.Value == 100)
                {
                    if(progressBar2.Value == 100)
                    {
                        if (progressBar3.Value == 100);
                    }                    
                }
            }
            
            /*
            try
            {
                if (progressBar1.Value == 0)
                {
                    button1_Click(sender, e);
                    if (progressBar1.Value == 100)
                    {
                        button2_Click(sender, e);
                    }
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            */
            /*
            button1_Click(sender, e);
            Delay(5000);
            button2_Click(sender, e);
            Delay(5000);
            button3_Click(sender, e);
            Delay(5000);
            button4_Click(sender, e);
            */
        }

        // 생산자 입장
        private void button6_Click(object sender, EventArgs e)
        {
            if (timer5.Enabled)
            {
                timer5.Stop();
            }
            else
            {
                timer5.Start();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (timer6.Enabled)
            {
                timer6.Stop();
            }
            else
            {
                timer6.Start();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (timer7.Enabled)
            {
                timer7.Stop();
            }
            else
            {
                timer7.Start();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (timer8.Enabled)
            {
                timer8.Stop();
            }
            else
            {
                timer8.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer5.Stop();
                
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value += 1;
                ps_2.Text = progressBar1.Value.ToString() + " %";
                if (progressBar1.Value == 100)
                {
                    ps_2.Text = "0%";
                }
            }
        }
        private void timer6_Tick_1(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                timer6.Stop();
                progressBar2.Value = 0;
            }
            else
            {
                progressBar2.Value += 1;
                ps_4.Text = progressBar2.Value.ToString() + " %";
                if (progressBar2.Value == 100)
                {
                    ps_4.Text = "0%";
                }
            }
        }
        private void timer7_Tick_1(object sender, EventArgs e)
        {
            if (progressBar3.Value == 100)
            {
                timer7.Stop();                
                progressBar3.Value = 0;
            }
            else
            {
                progressBar3.Value += 1;
                ps_6.Text = progressBar3.Value.ToString() + " %";
                if (progressBar3.Value == 100)
                {
                    ps_6.Text = "0%";
                }
            }
        }
        private void timer8_Tick_1(object sender, EventArgs e)
        {
            if (progressBar4.Value == 100)
            {
                timer8.Stop();                
                progressBar4.Value = 0;
            }
            else
            {
                progressBar4.Value += 1;
                ps_8.Text = progressBar4.Value.ToString() + " %";
                if (progressBar4.Value == 100)
                {
                    ps_8.Text = "0%";
                }
            }
        }

        // 마우스 이벤트
        
        private void pic1_mm(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox10.Visible = true;
            pictureBox1.Image = Properties.Resources.재료1;
        }

        private void pic1_ml(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox10.Visible = false;
            pictureBox1.Image = Properties.Resources.재료;
        }

        private void pic2_mm(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox11.Visible = true;
            pictureBox2.Image = Properties.Resources.분쇄;
        }

        private void pic2_ml(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox11.Visible = false;
            pictureBox2.Image = Properties.Resources.분쇄1;
        }
        private void pic3_mm(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox12.Visible = true;
            pictureBox3.Image = Properties.Resources.혼합1;
        }

        private void pic3_ml(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox12.Visible = false;
            pictureBox3.Image = Properties.Resources.혼합10;
        }

        private void pic4_mm(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox13.Visible = true;
            pictureBox4.Image = Properties.Resources.혼합0;
        }

        private void pic4_ml(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox13.Visible = false;
            pictureBox4.Image = Properties.Resources.혼합01;
        }

        private void pic5_mm(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox14.Visible = true;
            pictureBox5.Image = Properties.Resources.틀1;
        }

        private void pic5_ml(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox14.Visible = false;
            pictureBox5.Image = Properties.Resources.틀10;
        }

        private void pic6_mm(object sender, MouseEventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox15.Visible = true;
            pictureBox6.Image = Properties.Resources.틀0;
        }

        private void pic6_ml(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox15.Visible = false;
            pictureBox6.Image = Properties.Resources.틀01;
        }

        private void pic7_mm(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox16.Visible = true;
            pictureBox7.Image = Properties.Resources.자숙;
        }

        private void pic7_ml(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox16.Visible = false;
            pictureBox7.Image = Properties.Resources.자숙1;
        }

        private void pic8_mm(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox17.Visible = true;
            pictureBox8.Image = Properties.Resources.냉각;
        }

        private void pic8_ml(object sender, EventArgs e)
        {
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
