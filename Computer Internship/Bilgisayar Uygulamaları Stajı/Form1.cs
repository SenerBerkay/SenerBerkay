using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Win32;
using System.IO;

namespace Bilgisayar_Uygulamaları_Stajı
{
    public partial class Form1 : Form
    {
        string ProgramAdi = "Berkay";
        public Form1()
        {
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue("ProgramAdı", "\"" + Application.ExecutablePath + "\"");
        }
        double enjek = 0.15;
        double ekstrüz = 0.15;
        double pres = 0.10;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Prim Alacakların kayıt edildiği programa hoşgeldiniz");
            for (int i = 1; i < 4; i++)
            {
                comboBox1.Items.Add(i);
            }
            OpenFileDialog op = new OpenFileDialog();
            try
            {
                MessageBox.Show("Lütfen 'Prim Alacaklar metin (txt)' dosyasını  mevcutsa Aç'tan seçiniz");
                op.ShowDialog();
                StreamReader ok = new StreamReader(op.FileName);
                while (!ok.EndOfStream)
                {
                    listBox1.Items.Add(ok.ReadLine());
                }
                ok.Close();
            }
            catch
            {
                MessageBox.Show("Lüften 'Prim Alacaklar metin (txt)' dosya seçiniz veya Prim Alacaklar txt dosyasının olup olmadığını kontrol ediniz!");
                button2.Enabled = false;
                SaveFileDialog sv = new SaveFileDialog();
                sv.FileName = "Prim Alacaklar.txt";
                sv.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
                MessageBox.Show("Lütfen Farklı Kaydet Penceresi'nden 'Prim Alacaklar metin (txt)' dosyasını kayıt işlemini başarıyla gerçekleştiriniz!");
                if(sv.ShowDialog()==DialogResult.OK)
                {
                    StreamWriter yaz = new StreamWriter(sv.FileName);
                    yaz.Close();
                }
                MessageBox.Show("Lütfen 'Prim Alacakları Dosyadan Göster' tuşuna basınız");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            IMALAT vr = new IMALAT();
            int index = comboBox1.SelectedIndex;
            string Yetkili = vr.MakinaUzmanı(index);
            textBox1.Text = Yetkili;
            string Makina = vr.Makinalar(index);
            textBox2.Text = Makina;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "Enjeksiyon Makinası")
                MessageBox.Show("Enjeksiyon Makinaları bakımını Aralık ayı içerisinde yapınız");
            else if (textBox2.Text == "Ekstrüzyon Makinası")
                MessageBox.Show("Ekstrüzyon Makinaları bakımını yılda 2 kez olmak üzere Haziran ve Aralık aylarında mutlaka yapınız");
            else
                MessageBox.Show("Presleme Makinaları bakımını yılda 3 kez olmak üzere Nisan, Ağustos ve Aralık aylarında mutlaka yapınız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if (textBox1.Text == "Onur Kutlu")
            {
                string[] Enjeksiyon = { "Mert Ayvaz","Eda Soytürk","Batuhan Şendeğer","Meltem Macit", "Uğur Berber","Eda Sekiz","Mehmet Öndül","Büşra Kunşuk","Mehmet Çiftçi","Nur Yazdalı","Yasin Balay",
                "Tansu Aydın","Doğan Kavas","Beyza Özer","Yasin Durgun","Hülya Güneş","Vahit Calayir","Yeşim Özselek","Sinan Çıkış","Özge Tabak","İbrahim Mestan","Perihan Kırca","Burak Tüten","Kıymet Gülmez",
                "Erdoğan Ören","Nagehan Arık","Mahmut Gürçay","Seçil Doruk","Orhan Ayyılmaz","Tuğba Sevim"};
                for (int i = 0; i < 30; i++)
                {
                    checkedListBox1.Items.Add(Enjeksiyon[i]);
                }
            }
            else if (textBox1.Text == "Mustafa Kurt")
            {
                string[] Ekstrüzyon = {"Mehmet Aslan","Bahadır Kaya","Canan Yenigün","Necip Karaca","Salih Bölükbaşı","Ayşenur Yanık","Melih Akalın","Rafet Akarsu","Aysun Korucuoğlu","Hüseyin Yılmaz","Yusuf Akar",
                "Yasemin Çoban","Recep Ramazan","Mustafa Altay","Sevda Bahçe","Ali İlgi","Yunus Özbek","Sinem Aydın","Abdulhalim Arat","Onur Ayaruğ","Aslı Karadağ","Halil Dere","Ahmet Aslantaş","Hümeysa Alagöz","Hasan Bagürlü",
                "Taner Baran","Dilek Orakçı","Soner Zengin","Fatih Mercan","Necla Erece"};
                for (int j = 0; j < 30; j++)
                {
                    checkedListBox1.Items.Add(Ekstrüzyon[j]);
                }
            }
            else if (textBox1.Text == "Sezgin Bayram")
            {
                string[] Presleme = {"Raşit Sobat","İsmail Çakır","Alpay Demir","Selma Erdoğan","Taner Kahraman","Yiğit Balcı","Ömer Arslan","Fatma Demirtaş","Hakan Tosun","Durmuş Kalaycı","Murat Karabıyık","Sevgi Kolsuzlar","Fahrettin Atılgan",
                "İlhan Karalı","Semih İlgen","Hale Terzi","Muhammet Altıntaş","Orhan Başaran","Ahmet Bilgin","Elmas Tokalı","Serkan Çolak","Özkan Yüksel","İbrahim Uslusoy","Gülşah Özlü","Kamil Olgun","Ayhan Işık","Yaşar Koç","Seher Akgün","Hilmi Akıncı",
                "Zafer Özyurt"};
                int i = 0;
                while (i < 30)
                {
                    checkedListBox1.Items.Add(Presleme[i]);
                    i++;
                }
            }
        }
        private void DOSYAAC()
        {
            OpenFileDialog op = new OpenFileDialog();
            try
            {
                MessageBox.Show("Lütfen 'Prim Alacaklar metin (txt)' dosyasını Aç'tan seçiniz.");
                op.ShowDialog();
                StreamReader ok = new StreamReader(op.FileName);
                while (!ok.EndOfStream)
                {
                    listBox1.Items.Add(ok.ReadLine());
                }
                ok.Close();
            }
            catch
            {
                MessageBox.Show("Lüften 'Prim Alacakları Dosyadan Göster' tuşuna basınız!");
                MessageBox.Show("Lütfen 'Prim Alacaklar metin (txt)' dosyasının mevcut olup olmadığını kontrol ediniz!");
                button2.Enabled = false;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string[] secili = new string[checkedListBox1.Items.Count];
            for (int j = 0; j < checkedListBox1.CheckedItems.Count; j++)
            {
                secili[j] = checkedListBox1.CheckedItems[j].ToString() + " ";
                listBox1.Items.Add(secili[j]);
            }

            switch (textBox2.Text)
            {
                case "Enjeksiyon Makinası":
                    listBox1.Items.Add("Maaşlarının " + enjek + " " + "kısmı kadar pirim alacaklar");
                    break;
                case "Ekstrüzyon Makinası":
                    listBox1.Items.Add("Maaşlarının " + ekstrüz + " " + "kısmı kadar pirim alacaklar");
                    break;
                default:
                    listBox1.Items.Add("Maaşlarının " + pres + " " + "kısmı kadar pirim alacaklar");
                    break;
            }
            DateTime bugun = DateTime.Now;
            string today = bugun.ToString();
            SaveFileDialog sv = new SaveFileDialog();
            sv.FileName = "Prim Alacaklar.txt";
            sv.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            MessageBox.Show("Lütfen dosya kayıt işlemini yapınız");
            if (sv.ShowDialog() == DialogResult.OK)
            {
                StreamWriter yaz = new StreamWriter(sv.FileName);
                yaz.WriteLine("Son güncellenme:" + " " + today);
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    yaz.WriteLine(listBox1.Items[j]);
                }
                yaz.Close();
            }
            DOSYAAC();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = checkedListBox1.Items.Count;
            for (int i = 0; i < toplam; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            DOSYAAC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}

