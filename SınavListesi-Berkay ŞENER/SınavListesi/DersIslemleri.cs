﻿using System;
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
    public partial class DersIslemleri : Form
    {
        public DersIslemleri()
        {
            InitializeComponent();
        }

        private void DersIslemleri_Load(object sender, EventArgs e)
        {
            VeriTabaniIslemleri v = new VeriTabaniIslemleri(Properties.Settings.Default.VeriConnectionString);
            string Dersler = v.DersListesi2();
            string[] DerslerD = Dersler.Split();
            for (int i = 0; i < DerslerD.Length; i++)
            {
                listBox1.Items.Add(DerslerD[i]);
            }

        }
    }
}
