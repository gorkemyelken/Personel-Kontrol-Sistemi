﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kontrol_Sistemi
{
    public partial class frmizinturleri : Form
    {
        public frmizinturleri()
        {
            InitializeComponent();
        }

        private void frmizinturleri_Load(object sender, EventArgs e)
        {
            izin.ListviewwKayitGetir(listView1);
        }

        private void Temizle()
        {
            txtIzinTurID.Text = "";
            txtizinTuru.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                izin i = new izin();
                i.IzinTuru = txtizinTuru.Text;
                string sql = "insert into izinTurleri values('"+i.IzinTuru+"')";
                SqlCommand komut = new SqlCommand();
                Database.ESG(komut,sql);
                MessageBox.Show("Kayıt eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListviewwKayitGetir(listView1);
                Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                izin i = new izin();
                i.IzinTurID = int.Parse(txtIzinTurID.Text);
                i.IzinTuru = txtizinTuru.Text;
                string sql = "update izinTurleri set izinTuru='"+i.IzinTuru+"' where izinTurID='"+i.IzinTurID+"'";
                SqlCommand komut = new SqlCommand();
                Database.ESG(komut, sql);
                MessageBox.Show("Kayıt güncellendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListviewwKayitGetir(listView1);
                Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtIzinTurID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtizinTuru.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                izin i = new izin();
                i.IzinTurID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sql = "delete from izinTurleri where izinTurID='"+i.IzinTurID+"'";
                SqlCommand komut = new SqlCommand();
                Database.ESG(komut, sql);
                MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                izin.ListviewwKayitGetir(listView1);
                Temizle();
            }
            else
            {
                MessageBox.Show("Önce kayıt seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
