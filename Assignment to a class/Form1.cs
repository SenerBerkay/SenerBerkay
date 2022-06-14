using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Atama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATA2DataSet.Dersler' table. You can move, or remove it, as needed.
            this.derslerTableAdapter.Fill(this.dATA2DataSet.Dersler);
            // TODO: This line of code loads data into the 'dATA2DataSet.Dersler' table. You can move, or remove it, as needed.
            this.derslerTableAdapter.Fill(this.dATA2DataSet.Dersler);


        }



        private void DerslerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.derslerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dATA2DataSet);

        }
        public void TabloDoldur(void)
        {
            this.Validate();
            this.derslerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dATA2DataSet);
            derslerBindingSource.AddNew();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
