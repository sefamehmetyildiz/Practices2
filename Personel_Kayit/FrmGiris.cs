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

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-GLAR9PS;Initial Catalog=PersonalVeriTabani;Integrated Security=True");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAdi=@p1 and Sifre=@p2", bağlantı);
            komut.Parameters.AddWithValue("@p1", MskID.Text);
            komut.Parameters.AddWithValue("@p2", MskSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bağlantı.Close();
        }
    }
}