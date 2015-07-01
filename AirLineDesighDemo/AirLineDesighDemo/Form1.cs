using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CSharpgdal;
using System.Drawing.Imaging;
using System.IO;

namespace AirLineDesighDemo
{
    public partial class Form1 : Form
    {
        private int[] n = new int[1];
        private int[] n_n = new int[1];  
        public Form1()
        {
            InitializeComponent();
        }

        private void demo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aveHForm aveh = new aveHForm();
            aveh.ShowDialog();
            if (aveh.DialogResult == DialogResult.OK)
            {
                  double[] n_b = new double[5000];
                  double[] n_l = new double[5000];                   
                  //线敷点
                  airlinedesign1(aveh.f, aveh.ave_H, aveh.H, aveh.yy, aveh.Px, aveh.b1, aveh.b2, aveh.l1, aveh.l2, n_b, n_l, n_n);
                  for (int i = 0; i < n_n[0]; i++)
                  {
                      richTextBox1.AppendText(i.ToString() + " " + n_b[i].ToString() + " " + n_l[i].ToString() + "\n");
                  }

              }   
            MessageBox.Show("基于平均高程敷点完毕！");
            n[0] = 1;
        }

        private void demo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aveHForm aveh = new aveHForm();
            aveh.ShowDialog();
            if (aveh.DialogResult == DialogResult.OK)
            {
                double[] n_b = new double[5000];
                double[] n_l = new double[5000];
                //增加相片高度yy。xx（宽度）对应旁向，yy（高度）对应航向
                
                //矩形敷点
                airlinedesign(aveh.f, aveh.ave_H, aveh.H, aveh.xx, aveh.yy,aveh.Px, aveh.Py, aveh.b1, aveh.b2, aveh.l1, aveh.l2, n_b, n_l, n, n_n);
                for (int i = 0; i < n[0]; i++)
                    for (int j = 0; j < n_n[0]; j++)
                    {
                        richTextBox1.AppendText(i.ToString() + " " + j.ToString() + " " + n_b[i * n_n[0] + j].ToString() + " " + n_l[i * n_n[0] + j].ToString() + "\n");
                    }

            }   
        }
        [DllImport("Designline.dll", EntryPoint = "airlinedesign")]
        public static extern void airlinedesign(double f, double ave_H, double H, double xx,double yy,double Px, double Py, double b1, double b2, double l1, double l2, double[] p_b, double[] p_l, int[] n, int[] n_n);
        [DllImport("Designline.dll", EntryPoint = "airlinedesign1")]
        public static extern void airlinedesign1(double f, double ave_H, double H, double xx, double Px, double b1, double b2, double l1, double l2, double[] p_b, double[] p_l, int[] n);
        [DllImport("Designline.dll", EntryPoint = "airlinedesign2")]
        public static extern void airlinedesign2(double f, double ave_H, double H, double xx, double yy, double Px, double Py, double b1, double b2, double b3,double l1, double l2,double l3, double[] p_b, double[] p_l, int[] n, int[] n_n);
        private void pichtureNodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturenode("input.txt","20110722");
           
        }
        //filename为曝光txt文件，输入的是每条航线分别有几个曝光点，str为输入字符窜
        private void picturenode(string filename,string str)
        {
            String[] linesave;
            linesave = File.ReadAllLines("C:\\Users\\LI\\Desktop\\王志强\\AirLineDesighDemo\\input.txt", Encoding.Default);
            int [,]dataave = new int[linesave.Length, 2];
            for (int i = 0; i < linesave.Length; i++)
            {
                String[] s = new string[2];
                s = linesave[i].Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    dataave[i, j] = Convert.ToInt16(s[j]);
                }
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string folderName = fbd.SelectedPath; //获得选择的文件夹路径
            if (folderName == "")
            {
                return;
            }
            DirectoryInfo theFolder = new DirectoryInfo(folderName);
            if (Directory.Exists(folderName + "\\result") == false)//如果存在就删除file文件夹
            {
                System.IO.Directory.CreateDirectory(folderName + "\\result");
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(folderName + "\\result");
                foreach (FileInfo f in dir.GetFiles())
                    f.Delete();
            }
            int m = 1;
            int k=0;
            int n;
            foreach (FileInfo nextfile in theFolder.GetFiles())
            {
                n = dataave[k, 0];
                System.Drawing.Image image = System.Drawing.Image.FromFile(nextfile.FullName);
                Bitmap bitmap = new Bitmap(image, image.Width, image.Height);
                Graphics g = Graphics.FromImage(bitmap);
                string text = str+"-"+ n+ "-" + m;
                float fontSize = 12.0f;    //字体大小  
                float textWidth = text.Length * fontSize;  //文本的长度  
                //下面定义一个矩形区域，以后在这个矩形里画上白底黑字  
                float rectX = 0;
                float rectY = 0;
                float rectWidth = text.Length * (fontSize);
                float rectHeight = fontSize + 8;
                //声明矩形域  
                RectangleF textArea = new RectangleF(rectX, rectY, rectWidth, rectHeight);

                Font font = new Font("宋体", fontSize);   //定义字体  
                Brush whiteBrush = new SolidBrush(Color.White);   //白笔刷，画文字用  
                Brush blackBrush = new SolidBrush(Color.Black);   //黑笔刷，画背景用  

               // g.FillRectangle(blackBrush, rectX, rectY, rectWidth, rectHeight);

                g.DrawString(text, font, whiteBrush, 0,0);
                //保存为Jpg类型  
                bitmap.Save(folderName + "\\result\\" + nextfile.Name, ImageFormat.Jpeg);
                g.Dispose();
                bitmap.Dispose();
                image.Dispose();
                if (m == dataave[k,1])
                {
                    m = 1;
                    k++;         
                }
                else
                    m++;
            }        
        }

        private void demo平行四边形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aveHForm aveh = new aveHForm();
            aveh.ShowDialog();
            if (aveh.DialogResult == DialogResult.OK)
            {
                double[] n_b = new double[5000];
                double[] n_l = new double[5000];
                //增加相片高度yy。xx（宽度）对应旁向，yy（高度）对应航向              
                // 平行四边形敷点
                double b1 = 30.52382;
                double b2 = 30.52380;
                double b3 = 30.53403;
                double l1 = 114.35394;
                double l2 = 114.36595;
                double l3 = 114.35394;
                //输入参数增加b3,l3，其中b1,l1是起始点，b2,l2,b3,l3是平行四边形靠近这点的两个顶点，b1,l1指向b2,l2是沿旁向，指向b3,l3是沿航线。
                airlinedesign2(aveh.f, aveh.ave_H, aveh.H, aveh.xx, aveh.yy, aveh.Px, aveh.Py, b1, b2,b3, l1, l2,l3, n_b, n_l, n, n_n);
                for (int i = 0; i < n[0]; i++)
                    for (int j = 0; j < n_n[0]; j++)
                    {
                        richTextBox1.AppendText(i.ToString() + " " + j.ToString() + " " + n_b[i * n_n[0] + j].ToString() + " " + n_l[i * n_n[0] + j].ToString() + "\n");
                    }
            }   
        }
    }
}
