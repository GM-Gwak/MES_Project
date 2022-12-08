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
    public partial class test : Form
    {
        mainform main;
        //public EventHandler work1;
        
        public test()
        {
            InitializeComponent();
        }
        public test(object form)       //생성자를 하나 더 만듦
        {
            InitializeComponent();

            main = (mainform)form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            main.work_cd1();
            //work1.Invoke(null, EventArgs.Empty);
        }

        private void test_Load(object sender, EventArgs e)
        {
            //mainform main = new mainform();
            //work1 += new EventHandler(main.work_cd1);
        }
    }
}
