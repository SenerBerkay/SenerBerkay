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

namespace SınavListesi
{
    public partial class Öğrenci : Form
    {
        public Öğrenci()
        {
            InitializeComponent();
        }

        private void OgrencilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ogrencilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veriDataSet);

        }

        private void Öğrenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veriDataSet.Dersler' table. You can move, or remove it, as needed.
            this.derslerTableAdapter.Fill(this.veriDataSet.Dersler);
            // TODO: This line of code loads data into the 'veriDataSet.Siniflar' table. You can move, or remove it, as needed.
            this.siniflarTableAdapter.Fill(this.veriDataSet.Siniflar);
            // TODO: This line of code loads data into the 'veriDataSet.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.veriDataSet.Ogrenciler);

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            VeriTabaniIslemleri v = new VeriTabaniIslemleri(Properties.Settings.Default.VeriConnectionString);
            if (DialogResult.OK == MessageBox.Show("Bu işlem öğrenciler tablosunu silecektir.Onaylıyor musunuz?", "Tablo Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                v.OgrenciSil();
                Öğrenci_Load(sender, e);
            }
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            VeriTabaniIslemleri v = new VeriTabaniIslemleri(Properties.Settings.Default.VeriConnectionString);
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(op.FileName, Encoding.GetEncoding("iso-8859-9"));
                string[] veri = oku.ReadToEnd().Split('\n');
                string cevap= v.OgrYukle(veri, toolStripProgressBar1);
                Öğrenci_Load(sender, e);
                MessageBox.Show(cevap);
                toolStripProgressBar1.Value = 0;

            }
        }
    }
}
