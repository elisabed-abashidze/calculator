using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        float a;
        float b;
        float result;

        string opType;


        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Integers()
        {
            a = 0;
            b = 0;
            result = 0;
        }

        private void Check_Symbol_Exist()
        {
            
            try
            {
                a = (float)Convert.ToDouble(txt_1.Text);
            }
            catch
            {
                
            }
        }


        #region buttons
        private void btn_0_Click(object sender, EventArgs e)
        {
            Check_Symbol_Exist();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_4_Click(object sender, EventArgs e)
        {

        }

        private void btn_5_Click(object sender, EventArgs e)
        {

        }

        private void btn_6_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {

        }

        private void btn_div_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {

        }

        private void btn_point_Click(object sender, EventArgs e)
        {

        }

        private void btn_percent_Click(object sender, EventArgs e)
        {

        }


        #endregion
    }
}
