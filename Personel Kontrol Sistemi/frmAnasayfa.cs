﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kontrol_Sistemi
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        void FormGetir(Form form,Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            form.FormBorderStyle = FormBorderStyle.None;

        }
        private void btnDepartmanlar_Click(object sender, EventArgs e)
        { 
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
            
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }
        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            
            FormGetir(frm,panelFormlar);
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            frmKullanici k = new frmKullanici();
            k.ShowDialog();
        }
        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm = new frmMesaiEkle();
            frm.ShowDialog();


        }
        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            FormGetir(frm, panelFormlar);
        }
        private void btnizinHareketLeri_Click(object sender, EventArgs e)
        {
        }

        private void btnizinHareketListele_Click(object sender, EventArgs e)
        {

            frmizinHareketLisetele frm = new frmizinHareketLisetele();

            FormGetir(frm, panelFormlar);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelIslemler.Width==170)
            {
                panelIslemler.Width = 80;
            }
            else if (panelIslemler.Width==80)
            {
                panelIslemler.Width = 170;
            }
        }
    }
}
