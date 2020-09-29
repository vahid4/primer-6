using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primer_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("brojevi.txt");
            int n = 0;
            double prosek = 0;
            while(!f.EndOfStream)
            {
                double a = Convert.ToDouble(f.ReadLine());
                prosek += a;
                n++;
            }
            f.Close();
            prosek /= n;

            listBox1.Items.Clear();

            f = new StreamReader("brojevi.txt");
            while(!f.EndOfStream)
            {
                double a = Convert.ToDouble(f.ReadLine());
                if (a > prosek)
                    listBox1.Items.Add(a);
            }
            f.Close();

            button1.Enabled = false;
            textBox1.Text = prosek.ToString();
        }
    }
}
