using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dosyaokuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader(@"C:\Users\mertp\Desktop\ÖRNEKC#.txt");
            listBox1.Items.Clear();
            while (!oku.EndOfStream)
            {
                string satir = oku.ReadLine();
                listBox1.Items.Add(satir);
            }
        }
    }
}