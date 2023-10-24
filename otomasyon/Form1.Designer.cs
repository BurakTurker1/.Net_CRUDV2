namespace otomasyon
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.GvListele = new System.Windows.Forms.DataGridView();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBrimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSITarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.lblUyarı = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_ID2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ürün adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ürün miktarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ürün barkod :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "birim fiyatı :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(137, 33);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 22);
            this.txtBarkod.TabIndex = 4;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(137, 69);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 22);
            this.txtad.TabIndex = 5;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(137, 110);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 6;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(137, 148);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtBirimFiyat.TabIndex = 7;
            // 
            // GvListele
            // 
            this.GvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uID,
            this.uAd,
            this.uMiktar,
            this.uBrimFiyat,
            this.uSITarih,
            this.uBarkod});
            this.GvListele.Location = new System.Drawing.Point(12, 291);
            this.GvListele.Name = "GvListele";
            this.GvListele.RowHeadersWidth = 51;
            this.GvListele.RowTemplate.Height = 24;
            this.GvListele.Size = new System.Drawing.Size(1180, 222);
            this.GvListele.TabIndex = 8;
            this.GvListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvListele_CellDoubleClick);
            this.GvListele.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvListele_CellMouseDown);
            // 
            // uID
            // 
            this.uID.DataPropertyName = "uID";
            this.uID.HeaderText = "Ürün ID";
            this.uID.MinimumWidth = 6;
            this.uID.Name = "uID";
            this.uID.Width = 125;
            // 
            // uAd
            // 
            this.uAd.DataPropertyName = "uAd";
            this.uAd.HeaderText = "Ürün Adı";
            this.uAd.MinimumWidth = 6;
            this.uAd.Name = "uAd";
            this.uAd.Width = 125;
            // 
            // uMiktar
            // 
            this.uMiktar.DataPropertyName = "uMiktar";
            this.uMiktar.HeaderText = "Ürün Stok ";
            this.uMiktar.MinimumWidth = 6;
            this.uMiktar.Name = "uMiktar";
            this.uMiktar.Width = 125;
            // 
            // uBrimFiyat
            // 
            this.uBrimFiyat.DataPropertyName = "uBrimFiyat";
            this.uBrimFiyat.HeaderText = "Brim Fiyatı";
            this.uBrimFiyat.MinimumWidth = 6;
            this.uBrimFiyat.Name = "uBrimFiyat";
            this.uBrimFiyat.Width = 125;
            // 
            // uSITarih
            // 
            this.uSITarih.DataPropertyName = "uSITarih";
            this.uSITarih.HeaderText = "İşlem Tarihi";
            this.uSITarih.MinimumWidth = 6;
            this.uSITarih.Name = "uSITarih";
            this.uSITarih.Width = 125;
            // 
            // uBarkod
            // 
            this.uBarkod.DataPropertyName = "uBarkod";
            this.uBarkod.HeaderText = "Barkod";
            this.uBarkod.MinimumWidth = 6;
            this.uBarkod.Name = "uBarkod";
            this.uBarkod.Width = 125;
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(148, 213);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(75, 23);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(250, 213);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(79, 23);
            this.BtnGüncelle.TabIndex = 11;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(349, 213);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(75, 23);
            this.BtnListele.TabIndex = 12;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(40, 213);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 13;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblUyarı
            // 
            this.lblUyarı.AutoSize = true;
            this.lblUyarı.Location = new System.Drawing.Point(40, 253);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(0, 16);
            this.lblUyarı.TabIndex = 14;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(31, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(54, 16);
            this.lbl_ID.TabIndex = 15;
            this.lbl_ID.Text = "urun ID :";
            // 
            // lbl_ID2
            // 
            this.lbl_ID2.AutoSize = true;
            this.lbl_ID2.Location = new System.Drawing.Point(134, 9);
            this.lbl_ID2.Name = "lbl_ID2";
            this.lbl_ID2.Size = new System.Drawing.Size(0, 16);
            this.lbl_ID2.TabIndex = 17;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(446, 213);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(254, 32);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 19;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 556);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lbl_ID2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.GvListele);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GvListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.DataGridView GvListele;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label lblUyarı;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBrimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSITarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBarkod;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
    }
}

