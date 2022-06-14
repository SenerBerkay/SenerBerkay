using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SınavListesi
{
    public partial class SınıfListesi : Form
    {
        public SınıfListesi()
        {
            InitializeComponent();
        }
        int DerstekiOgrenciSayisi = 0;
        int SeciliSinifKontejan = 0;
        private void SınıfListesi_Load(object sender, EventArgs e)
        {
            VeriTabaniIslemleri v = new VeriTabaniIslemleri(Properties.Settings.Default.VeriConnectionString);
            string[] Dersler = v.DersListesi().Split('\n');
            listBox1.Items.AddRange(Dersler);
            string[] Siniflar = v.SinifListesi().Split('\n');
            checkedListBox1.Items.AddRange(Siniflar);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] a = listBox1.Items[listBox1.SelectedIndex].ToString().Split(':');
            DerstekiOgrenciSayisi = Convert.ToInt16(a[2]);
            label2.Text = a[2];
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliSinifKontejan = 0;
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string[] a = checkedListBox1.CheckedItems[i].ToString().Split(':');
                SeciliSinifKontejan = SeciliSinifKontejan + Convert.ToInt16(a[2]);

            }
            label4.Text = SeciliSinifKontejan.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VeriTabaniIslemleri v = new VeriTabaniIslemleri(Properties.Settings.Default.VeriConnectionString);
            try
            {
                string[] a = listBox1.Items[listBox1.SelectedIndex].ToString().Split(':');
                string DersNo = a[0];
                ArrayList Siniflar = new ArrayList();
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    string[] SinifListesi = checkedListBox1.CheckedItems[i].ToString().Split(':');
                    Siniflar.Add(SinifListesi);

                }
                v.SinifDoldur(DersNo, Siniflar);
            }
            catch
            {
                MessageBox.Show("Lütfen ders seçiniz!");
            }
            try
            {
                int L = Convert.ToInt16(label2.Text);
                int C = Convert.ToInt16(label4.Text);

                if (L <= C)
                {
                    MessageBox.Show(listBox1.Items[listBox1.SelectedIndex] + " " + "Dersinin Sınıf Ataması Başarı ile Gerçekleşmiştir");
                }
                else if (L > C)
                {
                    int fark = L - C;
                    MessageBox.Show(listBox1.Items[listBox1.SelectedIndex] + " " + "Dersinin Sınıf Ataması Başarı ile Gerçekleşmiştir" + " " + fark + " " + "kişi ataması yapılamamıştır");
                }
                
                    
            }
            catch
            {

            }
            
        }
    }
}
