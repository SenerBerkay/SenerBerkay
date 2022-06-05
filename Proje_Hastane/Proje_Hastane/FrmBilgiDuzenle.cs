﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        SQLbaglantisi bgl=new SQLbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text=dr[1].ToString();
                TxtSoyad.Text=dr[2].ToString();
                MskTelefon.Text=dr[4].ToString();
                txtSifre.Text=dr[5].ToString();
                CmbCinsiyet.Text=dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut2.Parameters.AddWithValue("p4",txtSifre.Text);
            komut2.Parameters.AddWithValue("p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("p6", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }
    }
}
