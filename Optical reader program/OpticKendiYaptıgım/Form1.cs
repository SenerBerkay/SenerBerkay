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

namespace OpticKendiYaptıgım
{
    public partial class Form1_Berkay : Form
    {
        public Form1_Berkay()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            StreamReader oku = new StreamReader(@"C:\Users\berkay\Desktop\Örnek Optik Form Datası.txt");
            while (!oku.EndOfStream)
            {
                listBox1.Items.Add(oku.ReadLine());
            }
            oku.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string a = listBox1.Items[listBox1.SelectedIndex].ToString();
                //MessageBox.Show("Grup"+" " + a);
                textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                StreamWriter yaz = new StreamWriter(sv.FileName);
                yaz.WriteLine("Bu liste optik form sonuçlarına ait");
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    yaz.WriteLine(listBox1.Items[i]);
                }
                yaz.WriteLine("Ortalama:44.41");
                yaz.Close();

            }
        }
        private int NumaraBul(String No, ListBox L)
        {
            int satir = -1;
            string a;
            for (int i = 0; i < L.Items.Count; i++)
            {
                a = L.Items[i].ToString();
                if (a.Substring(1, 12) == No)
                {
                    satir = i;
                    L.SelectedIndex = i;
                    break;
                }
            }

            return satir;

        }
        private int NumaraBUL(String No, ListBox L, String Grup)
        {
            int satir = -1;
            string a;
            for (int i = 0; i < L.Items.Count; i++)
            {
                a = L.Items[i].ToString();
                if (a.Substring(0, 13) == (Grup + No))
                {
                    satir = i;
                    L.SelectedIndex = i;
                    break;
                }
            }
            return satir;
        }
        private int PuanHesapla(String Cevap, String Anahtar)
        {
            int sayac = 0;
            int k;
            
            if (Cevap.Length < Anahtar.Length)
            {
                k = Cevap.Length;
                
            }
            else
            {
                k = Anahtar.Length;
                

            }
            for (int i = 0; i < k; i++)
            {
                if (Anahtar[i] == Cevap[i])
                {
                    sayac++;
                }
            }
            return sayac;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex!=-1)
            {

                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Lütfen liste kutunuzun boş olup olmadığını kontrol ediniz"+"\n"+"Liste kutunuz doluysa lütfen satır seçiniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string OgrCevap, CevapAnahtari;
            int x = NumaraBul(textBox2.Text, listBox1);
            if (x >= 0)
            {
                OgrCevap = listBox1.Items[x].ToString();
                int y = NumaraBUL("000000000000", listBox1, OgrCevap[0].ToString());
                CevapAnahtari = listBox1.Items[y].ToString();
                int puan = PuanHesapla(OgrCevap.Substring(13, OgrCevap.Length - 13).TrimEnd(),
                    CevapAnahtari.Substring(13, CevapAnahtari.Length - 13).TrimEnd());
                MessageBox.Show(OgrCevap + "\n" + CevapAnahtari, "Puan:" + puan);
            }
            else
            {
                MessageBox.Show(textBox2.Text + " Nolu öğrenci bulunamadı.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = NumaraBUL("000000000000", listBox1, "A");
            int y = NumaraBUL("000000000000", listBox1, "B");
            int z = NumaraBUL("000000000000", listBox1, "C");
            int t = NumaraBUL("000000000000", listBox1, "D");
            string Anahtar1 = listBox1.Items[x].ToString();
            Anahtar1 = Anahtar1.Substring(13, Anahtar1.Length - 13).TrimEnd();
            string Anahtar2 = listBox1.Items[y].ToString();
            Anahtar2 = Anahtar2.Substring(13, Anahtar2.Length - 13).TrimEnd();
            string Anahtar3 = listBox1.Items[z].ToString();
            Anahtar3 = Anahtar3.Substring(13, Anahtar3.Length - 13).TrimEnd();
            string Anahtar4 = listBox1.Items[t].ToString();
            Anahtar4 = Anahtar4.Substring(13, Anahtar4.Length - 13).TrimEnd();
            string OgCevap, no;
            

            //30 soruluk sınava göre puanlama yapılacağı için 3.33333333 çarpılıyor.
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                OgCevap = listBox1.Items[i].ToString();
                /*switch (OgCevap)
                {
                    case (OgCevap.Substring(1, 2) = "A"):
                            no = OgCevap.Substring(1, 12);
                            OgCevap = OgCevap.Substring(13, OgCevap.Length - 13).TrimEnd();
                            listBox2.Items.Add(no + "\t" + PuanHesapla(OgCevap, Anahtar1));
                        

                }*/
                /*Yukarıdaki yorum satırlarında switch-case ile amaçlanan ilk başta OgCevap ile cevap anahtarına ulaşılmak istenmiştir.case kısmında cevap anahtarı ile öğrencilerin grubuna
                 * ulaşılmak istenmiştir fakat case kısmında örneğin A grubu char olarak tanımlanmaya çalışılınca bir takım problemler yaşanmıştır.Hedeflenen case'ler yardımıyla listbox1'deki düzen
                 * ile cevapları, grupları listbox2'ye göndermekti.Yeteri kadar bilgim olmadığım için case'de char'ı (örneğin A grubu için) tanımlamayı bilmediğim için hedeflenen başarılamamıştır.
                 * Yukarıdaki switch case kısmında yapmak istediğimi özellikle bıraktım.Çünkü case'de char tanımlayabildiğim zaman switch case'de yapmak istediğim mantıksal dizini yorum satırından
                 * çıkaracağım.
                 */
                if (OgCevap[0] == 'A')
                {
                    
                    no = OgCevap.Substring(1, 12);
                    OgCevap = OgCevap.Substring(13, OgCevap.Length - 13).TrimEnd();
                    //int FazlaCevap = int.Parse(OgCevap.Substring(13, OgCevap.Length - 13));
                    //if (FazlaCevap < 31)
                    //{
                        listBox2.Items.Add("A grubuna aittir:");
                        listBox2.Items.Add(no + "\t" + (PuanHesapla(OgCevap, Anahtar1) * 3.33333333).ToString());
                    //}

                    /*else
                    {
                        listBox2.Items.Add("A grubuna aittir:");
                        listBox2.Items.Add(no + "\t" + (PuanHesapla(OgCevap, Anahtar1) * 3.33333333-30* 3.33333333).ToString());
                    }*/

                    
                }
            }
            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                OgCevap = listBox1.Items[j].ToString();
                if (OgCevap[0] == 'B')
                {
                    
                    no = OgCevap.Substring(1, 12);
                    OgCevap = OgCevap.Substring(13, OgCevap.Length - 13).TrimEnd();
                    listBox2.Items.Add("B grubuna aittir:");
                    listBox2.Items.Add(no + "\t" + (PuanHesapla(OgCevap, Anahtar2) * 3.33333333).ToString());

                }
            }
            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                OgCevap = listBox1.Items[k].ToString();
                if (OgCevap[0] == 'C')
                {
                    
                    no = OgCevap.Substring(1, 12);
                    OgCevap = OgCevap.Substring(13, OgCevap.Length - 13).TrimEnd();
                    listBox2.Items.Add("C grubuna aittir:");
                    listBox2.Items.Add(no + "\t" + (PuanHesapla(OgCevap, Anahtar3)* 3.33333333).ToString());
                }
            }
            for (int l = 0; l < listBox1.Items.Count; l++)
            {
                OgCevap = listBox1.Items[l].ToString();
                if (OgCevap[0] == 'D')
                {
                    
                    no = OgCevap.Substring(1, 12);
                    OgCevap = OgCevap.Substring(13, OgCevap.Length - 13).TrimEnd();
                    listBox2.Items.Add("D grubuna aittir:");
                    listBox2.Items.Add(no + "\t" + (PuanHesapla(OgCevap, Anahtar4)*3.33333333).ToString());
                    
                }
            }
            
        }

    }
}

