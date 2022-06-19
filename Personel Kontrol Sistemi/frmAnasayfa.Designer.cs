namespace Personel_Kontrol_Sistemi
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDepartmanlar = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.btnizinHareketListele = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.panelFormlar = new System.Windows.Forms.Panel();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            this.btnDepartmanlar.FlatAppearance.BorderSize = 0;
            this.btnDepartmanlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanlar.Location = new System.Drawing.Point(1, 11);
            this.btnDepartmanlar.Name = "btnDepartmanlar";
            this.btnDepartmanlar.Size = new System.Drawing.Size(112, 50);
            this.btnDepartmanlar.TabIndex = 0;
            this.btnDepartmanlar.Text = "Departmanlar";
            this.btnDepartmanlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartmanlar.UseVisualStyleBackColor = true;
            this.btnDepartmanlar.Click += new System.EventHandler(this.btnDepartmanlar_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.FlatAppearance.BorderSize = 0;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Location = new System.Drawing.Point(2, 67);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(111, 50);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.FlatAppearance.BorderSize = 0;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelListele.Location = new System.Drawing.Point(3, 123);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(110, 50);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.FlatAppearance.BorderSize = 0;
            this.btnMesaiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiEkle.Location = new System.Drawing.Point(3, 179);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(110, 50);
            this.btnMesaiEkle.TabIndex = 0;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnMesailer
            // 
            this.btnMesailer.FlatAppearance.BorderSize = 0;
            this.btnMesailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesailer.Location = new System.Drawing.Point(2, 235);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(111, 50);
            this.btnMesailer.TabIndex = 0;
            this.btnMesailer.Text = "Mesailer";
            this.btnMesailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesailer.UseVisualStyleBackColor = true;
            this.btnMesailer.Click += new System.EventHandler(this.btnMesailer_Click);
            // 
            // btnizinHareketListele
            // 
            this.btnizinHareketListele.FlatAppearance.BorderSize = 0;
            this.btnizinHareketListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinHareketListele.Location = new System.Drawing.Point(3, 291);
            this.btnizinHareketListele.Name = "btnizinHareketListele";
            this.btnizinHareketListele.Size = new System.Drawing.Size(110, 50);
            this.btnizinHareketListele.TabIndex = 0;
            this.btnizinHareketListele.Text = "İzin Hareketleri";
            this.btnizinHareketListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnizinHareketListele.UseVisualStyleBackColor = true;
            this.btnizinHareketListele.Click += new System.EventHandler(this.btnizinHareketListele_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.SystemColors.Control;
            this.panelIslemler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIslemler.Controls.Add(this.btnDepartmanlar);
            this.panelIslemler.Controls.Add(this.btnMesailer);
            this.panelIslemler.Controls.Add(this.btnizinHareketListele);
            this.panelIslemler.Controls.Add(this.btnPersonelEkle);
            this.panelIslemler.Controls.Add(this.btnPersonelListele);
            this.panelIslemler.Controls.Add(this.btnMesaiEkle);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIslemler.Location = new System.Drawing.Point(0, 0);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(120, 353);
            this.panelIslemler.TabIndex = 1;
            // 
            // panelFormlar
            // 
            this.panelFormlar.BackColor = System.Drawing.Color.SkyBlue;
            this.panelFormlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormlar.Location = new System.Drawing.Point(120, 0);
            this.panelFormlar.Name = "panelFormlar";
            this.panelFormlar.Size = new System.Drawing.Size(944, 353);
            this.panelFormlar.TabIndex = 2;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 353);
            this.Controls.Add(this.panelFormlar);
            this.Controls.Add(this.panelIslemler);
            this.Name = "frmAnasayfa";
            this.Text = "Ana Sayfa ";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmanlar;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnMesailer;
        private System.Windows.Forms.Button btnizinHareketListele;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Panel panelFormlar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

