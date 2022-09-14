using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormText : Form
    {
        Func<double, double> function;
        int A;
        int B;
        public FormText(Func<double,double> func, int a, int b)
        {
            InitializeComponent();
            function = func;
            A= a;
            B= b;
            pictureBox1.Visible = true;
            pictureBox1.Width = 600;
           // DrawGraf();
        }

        private void DrawGraf()
        {
            var listB = new List<double>();
            for (int i = 0; i < 600; i++)
            {
                double x = (i * (B - A)) /600.0 + A;
                var y2 = function(x);
                listB.Add(function(x));
            }
            double max = listB.Max();
            double min = listB.Min();
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(pictureBox1.Height);
            Console.WriteLine(pictureBox1.Width);  
            Pen p = new Pen(Color.Red, 1);
            Graphics g = pictureBox1.CreateGraphics();
            
            for (int i = 0; i <600 -1; i++)
            {
                int x1 = i;
                int y1 = Convert.ToInt32((listB[i] - min) * (pictureBox1.Height / (max - min)));
                int x2 = i + 1;
                int y2 = Convert.ToInt32((listB[i + 1] - min) * (pictureBox1.Height / (max - min)));
                g.DrawLine(p,
                    new Point(x1, y1),
                    new Point(x2, y2));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraf();
        }
    }
}
