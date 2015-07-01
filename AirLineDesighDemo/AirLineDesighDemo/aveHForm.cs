using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CSharpgdal
{
    public partial class aveHForm : Form
    {
      


        public double f;
        public double ave_H;
        public double H;
        public double xx;
        public double yy;
        public double Px;
        public double Py;
        public double b1;
        public double b2;
        public double l1;
        public double l2;
        public bool flag = false;
        public aveHForm()
        {
            InitializeComponent();
            f= 0.34F;
            ave_H= 0;
            H = 0;
            Px = 0.75F;
            Py = 0.4F;
            xx = 0;
            yy = 0;
            b1 = 0;
            b2 = 0;
            l1 = 0;
            l2 = 0;
            button1.DialogResult = DialogResult.OK;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            string str = "请输入";
            if (this.textBox2.Text == "")
            {
                str += " " + "平均高程";
            }
            if (this.textBox3.Text == "")
            {
                str += " " + "飞行高度";
            }
            if (this.textBox6.Text == "")
            {
                str += " " + "相幅宽度";
            }
            if (this.textBox7.Text == "")
            {
                str += " " + "最低纬度";
            }
            if (this.textBox8.Text == "")
            {
                str += " " + "最高纬度";
            }
            if (this.textBox9.Text == "")
            {
                str += " " + "最小经度";
            }
            if (this.textBox10.Text == "")
            {
                str += " " + "最大纬度";
            }
            if (this.textBox10.Text == "")
            {
                str += " " + "相幅高度";
            }
            else
            {
                flag = true;
            }
            if (flag)
            {
                f = Convert.ToDouble(this.textBox1.Text);
                ave_H = Convert.ToDouble(this.textBox2.Text);
                H = Convert.ToDouble(this.textBox3.Text);
                Px = Convert.ToDouble(this.textBox4.Text);
                Py = Convert.ToDouble(this.textBox5.Text);
                xx = Convert.ToDouble(this.textBox6.Text);
                b1 = Convert.ToDouble(this.textBox7.Text);
                b2 = Convert.ToDouble(this.textBox8.Text);
                l1 = Convert.ToDouble(this.textBox9.Text);
                l2 = Convert.ToDouble(this.textBox10.Text);
                yy = Convert.ToDouble(this.textBox11.Text);
            }
            else
            {
                MessageBox.Show(str);
            }
        }    
        private void aveHForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
