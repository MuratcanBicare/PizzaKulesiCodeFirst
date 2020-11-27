
namespace PizzaKulesi2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkstraMalzeme = new System.Windows.Forms.Button();
            this.btnPizzaCesidi = new System.Windows.Forms.Button();
            this.chkTeslimEdileleriGizle = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkTeslim = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cboPizzaCesidi = new System.Windows.Forms.ComboBox();
            this.clbMalzeme = new System.Windows.Forms.CheckedListBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMusteri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuzenle.Location = new System.Drawing.Point(637, 503);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(258, 87);
            this.btnDuzenle.TabIndex = 36;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.Location = new System.Drawing.Point(333, 503);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(257, 87);
            this.btnSil.TabIndex = 35;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ekstra Malzemeler";
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.AllowUserToAddRows = false;
            this.dgvSiparis.AllowUserToDeleteRows = false;
            this.dgvSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvSiparis.Location = new System.Drawing.Point(333, 55);
            this.dgvSiparis.MultiSelect = false;
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.ReadOnly = true;
            this.dgvSiparis.RowHeadersVisible = false;
            this.dgvSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparis.Size = new System.Drawing.Size(562, 410);
            this.dgvSiparis.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Musteri";
            this.Column2.HeaderText = "AdSoyad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Pizza";
            this.Column3.HeaderText = "Pizza";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "VirgulluMalzeme";
            this.Column4.HeaderText = "EkstraMalzemeler";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeslimDurumu";
            this.Column5.HeaderText = "TeslimDurumu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AdresiYaz";
            this.Column6.HeaderText = "Adres";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnEkstraMalzeme
            // 
            this.btnEkstraMalzeme.Location = new System.Drawing.Point(150, 92);
            this.btnEkstraMalzeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkstraMalzeme.Name = "btnEkstraMalzeme";
            this.btnEkstraMalzeme.Size = new System.Drawing.Size(44, 30);
            this.btnEkstraMalzeme.TabIndex = 32;
            this.btnEkstraMalzeme.Text = "+";
            this.btnEkstraMalzeme.UseVisualStyleBackColor = true;
            this.btnEkstraMalzeme.Click += new System.EventHandler(this.btnEkstraMalzeme_Click);
            // 
            // btnPizzaCesidi
            // 
            this.btnPizzaCesidi.Location = new System.Drawing.Point(150, 21);
            this.btnPizzaCesidi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPizzaCesidi.Name = "btnPizzaCesidi";
            this.btnPizzaCesidi.Size = new System.Drawing.Size(44, 30);
            this.btnPizzaCesidi.TabIndex = 31;
            this.btnPizzaCesidi.Text = "+";
            this.btnPizzaCesidi.UseVisualStyleBackColor = true;
            this.btnPizzaCesidi.Click += new System.EventHandler(this.btnPizzaCesidi_Click);
            // 
            // chkTeslimEdileleriGizle
            // 
            this.chkTeslimEdileleriGizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTeslimEdileleriGizle.AutoSize = true;
            this.chkTeslimEdileleriGizle.Location = new System.Drawing.Point(698, 25);
            this.chkTeslimEdileleriGizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTeslimEdileleriGizle.Name = "chkTeslimEdileleriGizle";
            this.chkTeslimEdileleriGizle.Size = new System.Drawing.Size(183, 20);
            this.chkTeslimEdileleriGizle.TabIndex = 30;
            this.chkTeslimEdileleriGizle.Text = "Teslim Edilenleri Gizle";
            this.chkTeslimEdileleriGizle.UseVisualStyleBackColor = true;
            this.chkTeslimEdileleriGizle.CheckedChanged += new System.EventHandler(this.chkTeslimEdileleriGizle_CheckedChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.Location = new System.Drawing.Point(13, 632);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(226, 30);
            this.btnEkle.TabIndex = 29;
            this.btnEkle.Text = "Sipariş Oluştur";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chkTeslim
            // 
            this.chkTeslim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTeslim.AutoSize = true;
            this.chkTeslim.Location = new System.Drawing.Point(13, 608);
            this.chkTeslim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTeslim.Name = "chkTeslim";
            this.chkTeslim.Size = new System.Drawing.Size(118, 20);
            this.chkTeslim.TabIndex = 28;
            this.chkTeslim.Text = "Teslim Edildi";
            this.chkTeslim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Teslimat Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pizza Çeşidi";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAdres.Location = new System.Drawing.Point(11, 398);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(226, 112);
            this.txtAdres.TabIndex = 25;
            // 
            // cboPizzaCesidi
            // 
            this.cboPizzaCesidi.DisplayMember = "Cesit";
            this.cboPizzaCesidi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaCesidi.FormattingEnabled = true;
            this.cboPizzaCesidi.Location = new System.Drawing.Point(11, 55);
            this.cboPizzaCesidi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPizzaCesidi.Name = "cboPizzaCesidi";
            this.cboPizzaCesidi.Size = new System.Drawing.Size(226, 24);
            this.cboPizzaCesidi.TabIndex = 24;
            // 
            // clbMalzeme
            // 
            this.clbMalzeme.FormattingEnabled = true;
            this.clbMalzeme.Location = new System.Drawing.Point(12, 126);
            this.clbMalzeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbMalzeme.Name = "clbMalzeme";
            this.clbMalzeme.Size = new System.Drawing.Size(226, 106);
            this.clbMalzeme.TabIndex = 23;
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(13, 334);
            this.txtMusteriAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(226, 22);
            this.txtMusteriAdSoyad.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Müşteri Ad Soyad";
            // 
            // cboMusteri
            // 
            this.cboMusteri.DisplayMember = "Musteri";
            this.cboMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMusteri.FormattingEnabled = true;
            this.cboMusteri.Location = new System.Drawing.Point(13, 271);
            this.cboMusteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMusteri.Name = "cboMusteri";
            this.cboMusteri.Size = new System.Drawing.Size(226, 24);
            this.cboMusteri.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Müşteri";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(10, 567);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(101, 30);
            this.btnMusteriEkle.TabIndex = 39;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIptal.Location = new System.Drawing.Point(333, 608);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(562, 30);
            this.btnIptal.TabIndex = 40;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(10, 526);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(229, 30);
            this.btnMusteriDuzenle.TabIndex = 41;
            this.btnMusteriDuzenle.Text = "Müşteri Düzenle";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = true;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusteriSil.Enabled = false;
            this.btnMusteriSil.Location = new System.Drawing.Point(117, 567);
            this.btnMusteriSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(120, 30);
            this.btnMusteriSil.TabIndex = 42;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 671);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriDuzenle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMusteri);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSiparis);
            this.Controls.Add(this.btnEkstraMalzeme);
            this.Controls.Add(this.btnPizzaCesidi);
            this.Controls.Add(this.chkTeslimEdileleriGizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.chkTeslim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cboPizzaCesidi);
            this.Controls.Add(this.clbMalzeme);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(951, 710);
            this.Name = "Form1";
            this.Text = "Pizza Sipariş Takip";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.Button btnEkstraMalzeme;
        private System.Windows.Forms.Button btnPizzaCesidi;
        private System.Windows.Forms.CheckBox chkTeslimEdileleriGizle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkTeslim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ComboBox cboPizzaCesidi;
        private System.Windows.Forms.CheckedListBox clbMalzeme;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnMusteriSil;
    }
}

