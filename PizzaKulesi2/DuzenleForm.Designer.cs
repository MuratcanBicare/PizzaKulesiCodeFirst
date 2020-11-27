
namespace PizzaKulesi2
{
    partial class DuzenleForm
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCesit = new System.Windows.Forms.TextBox();
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.btnPizzaEkle = new System.Windows.Forms.Button();
            this.btnIPizzaIptal = new System.Windows.Forms.Button();
            this.btnPizzaDuzenle = new System.Windows.Forms.Button();
            this.btnPizzaSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEksMalSil = new System.Windows.Forms.Button();
            this.btnEksMalDuzenle = new System.Windows.Forms.Button();
            this.btnEksMalIptal = new System.Windows.Forms.Button();
            this.btnEksMalEkle = new System.Windows.Forms.Button();
            this.lstEkstraMalzemeler = new System.Windows.Forms.ListBox();
            this.txtEksMalAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCesit
            // 
            this.txtCesit.Location = new System.Drawing.Point(88, 24);
            this.txtCesit.Name = "txtCesit";
            this.txtCesit.Size = new System.Drawing.Size(197, 20);
            this.txtCesit.TabIndex = 0;
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.Location = new System.Drawing.Point(24, 60);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(423, 329);
            this.lstPizzalar.TabIndex = 1;
            // 
            // btnPizzaEkle
            // 
            this.btnPizzaEkle.Location = new System.Drawing.Point(291, 20);
            this.btnPizzaEkle.Name = "btnPizzaEkle";
            this.btnPizzaEkle.Size = new System.Drawing.Size(75, 34);
            this.btnPizzaEkle.TabIndex = 4;
            this.btnPizzaEkle.Text = "EKLE";
            this.btnPizzaEkle.UseVisualStyleBackColor = true;
            this.btnPizzaEkle.Click += new System.EventHandler(this.btnPizzaEkle_Click);
            // 
            // btnIPizzaIptal
            // 
            this.btnIPizzaIptal.Location = new System.Drawing.Point(372, 19);
            this.btnIPizzaIptal.Name = "btnIPizzaIptal";
            this.btnIPizzaIptal.Size = new System.Drawing.Size(75, 35);
            this.btnIPizzaIptal.TabIndex = 5;
            this.btnIPizzaIptal.Text = "İPTAL";
            this.btnIPizzaIptal.UseVisualStyleBackColor = true;
            this.btnIPizzaIptal.Click += new System.EventHandler(this.btnIPizzaIptal_Click);
            // 
            // btnPizzaDuzenle
            // 
            this.btnPizzaDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPizzaDuzenle.Location = new System.Drawing.Point(24, 409);
            this.btnPizzaDuzenle.Name = "btnPizzaDuzenle";
            this.btnPizzaDuzenle.Size = new System.Drawing.Size(197, 62);
            this.btnPizzaDuzenle.TabIndex = 6;
            this.btnPizzaDuzenle.Text = "DÜZENLE";
            this.btnPizzaDuzenle.UseVisualStyleBackColor = true;
            this.btnPizzaDuzenle.Click += new System.EventHandler(this.btnPizzaDuzenle_Click);
            // 
            // btnPizzaSil
            // 
            this.btnPizzaSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPizzaSil.Location = new System.Drawing.Point(251, 409);
            this.btnPizzaSil.Name = "btnPizzaSil";
            this.btnPizzaSil.Size = new System.Drawing.Size(196, 62);
            this.btnPizzaSil.TabIndex = 7;
            this.btnPizzaSil.Text = "SİL";
            this.btnPizzaSil.UseVisualStyleBackColor = true;
            this.btnPizzaSil.Click += new System.EventHandler(this.btnPizzaSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pizza Çeşit:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Eks. Mal. :";
            // 
            // btnEksMalSil
            // 
            this.btnEksMalSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEksMalSil.Location = new System.Drawing.Point(680, 409);
            this.btnEksMalSil.Name = "btnEksMalSil";
            this.btnEksMalSil.Size = new System.Drawing.Size(196, 62);
            this.btnEksMalSil.TabIndex = 14;
            this.btnEksMalSil.Text = "SİL";
            this.btnEksMalSil.UseVisualStyleBackColor = true;
            this.btnEksMalSil.Click += new System.EventHandler(this.btnEksMalSil_Click);
            // 
            // btnEksMalDuzenle
            // 
            this.btnEksMalDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEksMalDuzenle.Location = new System.Drawing.Point(453, 409);
            this.btnEksMalDuzenle.Name = "btnEksMalDuzenle";
            this.btnEksMalDuzenle.Size = new System.Drawing.Size(197, 62);
            this.btnEksMalDuzenle.TabIndex = 13;
            this.btnEksMalDuzenle.Text = "DÜZENLE";
            this.btnEksMalDuzenle.UseVisualStyleBackColor = true;
            this.btnEksMalDuzenle.Click += new System.EventHandler(this.btnEksMalDuzenle_Click);
            // 
            // btnEksMalIptal
            // 
            this.btnEksMalIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEksMalIptal.Location = new System.Drawing.Point(801, 19);
            this.btnEksMalIptal.Name = "btnEksMalIptal";
            this.btnEksMalIptal.Size = new System.Drawing.Size(75, 35);
            this.btnEksMalIptal.TabIndex = 12;
            this.btnEksMalIptal.Text = "İPTAL";
            this.btnEksMalIptal.UseVisualStyleBackColor = true;
            this.btnEksMalIptal.Click += new System.EventHandler(this.btnEksMalIptal_Click);
            // 
            // btnEksMalEkle
            // 
            this.btnEksMalEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEksMalEkle.Location = new System.Drawing.Point(720, 20);
            this.btnEksMalEkle.Name = "btnEksMalEkle";
            this.btnEksMalEkle.Size = new System.Drawing.Size(75, 34);
            this.btnEksMalEkle.TabIndex = 11;
            this.btnEksMalEkle.Text = "EKLE";
            this.btnEksMalEkle.UseVisualStyleBackColor = true;
            this.btnEksMalEkle.Click += new System.EventHandler(this.btnEksMalEkle_Click);
            // 
            // lstEkstraMalzemeler
            // 
            this.lstEkstraMalzemeler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEkstraMalzemeler.FormattingEnabled = true;
            this.lstEkstraMalzemeler.Location = new System.Drawing.Point(453, 60);
            this.lstEkstraMalzemeler.Name = "lstEkstraMalzemeler";
            this.lstEkstraMalzemeler.Size = new System.Drawing.Size(423, 329);
            this.lstEkstraMalzemeler.TabIndex = 10;
            // 
            // txtEksMalAdi
            // 
            this.txtEksMalAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEksMalAdi.Location = new System.Drawing.Point(516, 24);
            this.txtEksMalAdi.Name = "txtEksMalAdi";
            this.txtEksMalAdi.Size = new System.Drawing.Size(198, 20);
            this.txtEksMalAdi.TabIndex = 9;
            // 
            // DuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEksMalSil);
            this.Controls.Add(this.btnEksMalDuzenle);
            this.Controls.Add(this.btnEksMalIptal);
            this.Controls.Add(this.btnEksMalEkle);
            this.Controls.Add(this.lstEkstraMalzemeler);
            this.Controls.Add(this.txtEksMalAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPizzaSil);
            this.Controls.Add(this.btnPizzaDuzenle);
            this.Controls.Add(this.btnIPizzaIptal);
            this.Controls.Add(this.btnPizzaEkle);
            this.Controls.Add(this.lstPizzalar);
            this.Controls.Add(this.txtCesit);
            this.MinimumSize = new System.Drawing.Size(914, 522);
            this.Name = "DuzenleForm";
            this.Text = "DuzenleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCesit;
        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.Button btnPizzaEkle;
        private System.Windows.Forms.Button btnIPizzaIptal;
        private System.Windows.Forms.Button btnPizzaDuzenle;
        private System.Windows.Forms.Button btnPizzaSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEksMalSil;
        private System.Windows.Forms.Button btnEksMalDuzenle;
        private System.Windows.Forms.Button btnEksMalIptal;
        private System.Windows.Forms.Button btnEksMalEkle;
        private System.Windows.Forms.ListBox lstEkstraMalzemeler;
        private System.Windows.Forms.TextBox txtEksMalAdi;
    }
}