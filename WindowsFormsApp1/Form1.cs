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
    
    public partial class Form1 : Form
    {
        //f(x)-a * h/b-a
        Func<double, double> function;
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            label1.Visible = false;
            label3.Visible=false;
            button1.Visible=false;
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function = Math.Sin;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
        }

        private void parabolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function = x => x * x;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            function = Math.Cos;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            int a, b;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                a = 0;
                b = 100;
            }
            var form = new FormText(function,a,b);
            form.Show();
        }

    }
}
