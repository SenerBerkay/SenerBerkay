using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavListesi
{
    public partial class SinifIslemleri : Form
    {
        public SinifIslemleri()
        {
            InitializeComponent();
        }

        private void SinifIslemleri_Load(object sender, EventArgs e)
        {
            VeriTabaniIslemleri v = new VeriTabaniIslemleri(Properties.Settings.Default.VeriConnectionString);
            string Siniflar = v.SinifListesi2();
            string[] SiniflarD = Siniflar.Split();
            for (int i = 0; i < SiniflarD.Length; i++)
            {
                listBox1.Items.Add(SiniflarD[i]);
            }
        }
    }
}
