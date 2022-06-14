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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ÖğrenciİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Öğrenci ogr = new Öğrenci();
            if (Application.OpenForms["Öğrenci"] != null)
            {
                ogr.Activate();
            }
            else
            {
                ogr.MdiParent = this;
                ogr.Show();
            }

        }

        private void SınıfListesiOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SınıfListesi ogr = new SınıfListesi();
            if (Application.OpenForms["SınıfListesi"] != null)
            {
                ogr.Activate();
            }
            else
            {
                ogr.MdiParent = this;
                ogr.Show();
            }

        }

        private void SınıfİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinifIslemleri goster = new SinifIslemleri();
            goster.MdiParent = this;
            goster.Show();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkında goster = new Hakkında();
            goster.MdiParent = this;
            goster.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersIslemleri goster = new DersIslemleri();
            goster.MdiParent = this;
            goster.Show();
        }

        private void YardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog dosya = new OpenFileDialog();
            dosya.FileName = "Yardım-Kullanma Klavuzu";
            dosya.Filter= "Pdf Files|*.pdf";
            dosya.ShowDialog();
            Bu komutlarla açması gerekirken açmadı.Bu kısımda nerede eksik yaptığımı bulamadım.*/
        }
    }
}
