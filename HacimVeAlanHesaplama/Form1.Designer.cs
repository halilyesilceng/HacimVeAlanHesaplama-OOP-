namespace HacimVeAlanHesaplama
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
            this.lblUzunKenar = new System.Windows.Forms.Label();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.btnDikdörtgenHacimHesapla = new System.Windows.Forms.Button();
            this.txtKisaKenar = new System.Windows.Forms.TextBox();
            this.lblKisaKenar = new System.Windows.Forms.Label();
            this.txtAyritUzunluk = new System.Windows.Forms.TextBox();
            this.lblAyrıtUzunluk = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblKüp = new System.Windows.Forms.Label();
            this.txtKüp = new System.Windows.Forms.TextBox();
            this.btnKüpHacimHesapla = new System.Windows.Forms.Button();
            this.txtKareAlan = new System.Windows.Forms.TextBox();
            this.lblKareAlan = new System.Windows.Forms.Label();
            this.txtKisaKenarAlan = new System.Windows.Forms.TextBox();
            this.lblKisaKenarAlan = new System.Windows.Forms.Label();
            this.txtUzunKenarAlan = new System.Windows.Forms.TextBox();
            this.lblUzunKenarAlan = new System.Windows.Forms.Label();
            this.lblAlanHesapla = new System.Windows.Forms.Label();
            this.btnKareAlanHesapla = new System.Windows.Forms.Button();
            this.btnDikdörtgenAlanHesapla = new System.Windows.Forms.Button();
            this.txtSonucAlan = new System.Windows.Forms.TextBox();
            this.lblSonucAlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUzunKenar
            // 
            this.lblUzunKenar.AutoSize = true;
            this.lblUzunKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunKenar.Location = new System.Drawing.Point(128, 116);
            this.lblUzunKenar.Name = "lblUzunKenar";
            this.lblUzunKenar.Size = new System.Drawing.Size(91, 17);
            this.lblUzunKenar.TabIndex = 0;
            this.lblUzunKenar.Text = "Uzun Kenar :";
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(248, 116);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(100, 22);
            this.txtUzunKenar.TabIndex = 1;
            // 
            // btnDikdörtgenHacimHesapla
            // 
            this.btnDikdörtgenHacimHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDikdörtgenHacimHesapla.Location = new System.Drawing.Point(114, 271);
            this.btnDikdörtgenHacimHesapla.Name = "btnDikdörtgenHacimHesapla";
            this.btnDikdörtgenHacimHesapla.Size = new System.Drawing.Size(234, 34);
            this.btnDikdörtgenHacimHesapla.TabIndex = 2;
            this.btnDikdörtgenHacimHesapla.Text = "Dikdörtgen Hacim Hesapla";
            this.btnDikdörtgenHacimHesapla.UseVisualStyleBackColor = true;
            this.btnDikdörtgenHacimHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtKisaKenar
            // 
            this.txtKisaKenar.Location = new System.Drawing.Point(248, 153);
            this.txtKisaKenar.Name = "txtKisaKenar";
            this.txtKisaKenar.Size = new System.Drawing.Size(100, 22);
            this.txtKisaKenar.TabIndex = 4;
            // 
            // lblKisaKenar
            // 
            this.lblKisaKenar.AutoSize = true;
            this.lblKisaKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisaKenar.Location = new System.Drawing.Point(134, 153);
            this.lblKisaKenar.Name = "lblKisaKenar";
            this.lblKisaKenar.Size = new System.Drawing.Size(85, 17);
            this.lblKisaKenar.TabIndex = 3;
            this.lblKisaKenar.Text = "Kısa Kenar :";
            // 
            // txtAyritUzunluk
            // 
            this.txtAyritUzunluk.Location = new System.Drawing.Point(248, 194);
            this.txtAyritUzunluk.Name = "txtAyritUzunluk";
            this.txtAyritUzunluk.Size = new System.Drawing.Size(100, 22);
            this.txtAyritUzunluk.TabIndex = 6;
            // 
            // lblAyrıtUzunluk
            // 
            this.lblAyrıtUzunluk.AutoSize = true;
            this.lblAyrıtUzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyrıtUzunluk.Location = new System.Drawing.Point(111, 194);
            this.lblAyrıtUzunluk.Name = "lblAyrıtUzunluk";
            this.lblAyrıtUzunluk.Size = new System.Drawing.Size(108, 17);
            this.lblAyrıtUzunluk.TabIndex = 5;
            this.lblAyrıtUzunluk.Text = "Ayrıt Uzunluğu :";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(248, 366);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 22);
            this.txtSonuc.TabIndex = 8;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(109, 358);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(124, 29);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "SONUÇ :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(126, 67);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(230, 29);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "HACİM HESAPLA";
            // 
            // lblKüp
            // 
            this.lblKüp.AutoSize = true;
            this.lblKüp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKüp.Location = new System.Drawing.Point(173, 236);
            this.lblKüp.Name = "lblKüp";
            this.lblKüp.Size = new System.Drawing.Size(41, 17);
            this.lblKüp.TabIndex = 10;
            this.lblKüp.Text = "Küp :";
            // 
            // txtKüp
            // 
            this.txtKüp.Location = new System.Drawing.Point(248, 231);
            this.txtKüp.Name = "txtKüp";
            this.txtKüp.Size = new System.Drawing.Size(100, 22);
            this.txtKüp.TabIndex = 12;
            // 
            // btnKüpHacimHesapla
            // 
            this.btnKüpHacimHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKüpHacimHesapla.Location = new System.Drawing.Point(114, 311);
            this.btnKüpHacimHesapla.Name = "btnKüpHacimHesapla";
            this.btnKüpHacimHesapla.Size = new System.Drawing.Size(234, 29);
            this.btnKüpHacimHesapla.TabIndex = 13;
            this.btnKüpHacimHesapla.Text = "Küp Hacim Hesapla";
            this.btnKüpHacimHesapla.UseVisualStyleBackColor = true;
            this.btnKüpHacimHesapla.Click += new System.EventHandler(this.btnKüpHacimHesapla_Click);
            // 
            // txtKareAlan
            // 
            this.txtKareAlan.Location = new System.Drawing.Point(557, 194);
            this.txtKareAlan.Name = "txtKareAlan";
            this.txtKareAlan.Size = new System.Drawing.Size(100, 22);
            this.txtKareAlan.TabIndex = 19;
            // 
            // lblKareAlan
            // 
            this.lblKareAlan.AutoSize = true;
            this.lblKareAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKareAlan.Location = new System.Drawing.Point(482, 197);
            this.lblKareAlan.Name = "lblKareAlan";
            this.lblKareAlan.Size = new System.Drawing.Size(46, 17);
            this.lblKareAlan.TabIndex = 18;
            this.lblKareAlan.Text = "Kare :";
            // 
            // txtKisaKenarAlan
            // 
            this.txtKisaKenarAlan.Location = new System.Drawing.Point(557, 153);
            this.txtKisaKenarAlan.Name = "txtKisaKenarAlan";
            this.txtKisaKenarAlan.Size = new System.Drawing.Size(100, 22);
            this.txtKisaKenarAlan.TabIndex = 17;
            // 
            // lblKisaKenarAlan
            // 
            this.lblKisaKenarAlan.AutoSize = true;
            this.lblKisaKenarAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisaKenarAlan.Location = new System.Drawing.Point(443, 153);
            this.lblKisaKenarAlan.Name = "lblKisaKenarAlan";
            this.lblKisaKenarAlan.Size = new System.Drawing.Size(85, 17);
            this.lblKisaKenarAlan.TabIndex = 16;
            this.lblKisaKenarAlan.Text = "Kısa Kenar :";
            // 
            // txtUzunKenarAlan
            // 
            this.txtUzunKenarAlan.Location = new System.Drawing.Point(557, 116);
            this.txtUzunKenarAlan.Name = "txtUzunKenarAlan";
            this.txtUzunKenarAlan.Size = new System.Drawing.Size(100, 22);
            this.txtUzunKenarAlan.TabIndex = 15;
            // 
            // lblUzunKenarAlan
            // 
            this.lblUzunKenarAlan.AutoSize = true;
            this.lblUzunKenarAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUzunKenarAlan.Location = new System.Drawing.Point(437, 116);
            this.lblUzunKenarAlan.Name = "lblUzunKenarAlan";
            this.lblUzunKenarAlan.Size = new System.Drawing.Size(91, 17);
            this.lblUzunKenarAlan.TabIndex = 14;
            this.lblUzunKenarAlan.Text = "Uzun Kenar :";
            // 
            // lblAlanHesapla
            // 
            this.lblAlanHesapla.AutoSize = true;
            this.lblAlanHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlanHesapla.Location = new System.Drawing.Point(441, 58);
            this.lblAlanHesapla.Name = "lblAlanHesapla";
            this.lblAlanHesapla.Size = new System.Drawing.Size(215, 29);
            this.lblAlanHesapla.TabIndex = 20;
            this.lblAlanHesapla.Text = "ALAN HESAPLA";
            // 
            // btnKareAlanHesapla
            // 
            this.btnKareAlanHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKareAlanHesapla.Location = new System.Drawing.Point(423, 289);
            this.btnKareAlanHesapla.Name = "btnKareAlanHesapla";
            this.btnKareAlanHesapla.Size = new System.Drawing.Size(234, 29);
            this.btnKareAlanHesapla.TabIndex = 22;
            this.btnKareAlanHesapla.Text = "Kare Alan Hesapla";
            this.btnKareAlanHesapla.UseVisualStyleBackColor = true;
            this.btnKareAlanHesapla.Click += new System.EventHandler(this.btnKareAlanHesapla_Click);
            // 
            // btnDikdörtgenAlanHesapla
            // 
            this.btnDikdörtgenAlanHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDikdörtgenAlanHesapla.Location = new System.Drawing.Point(423, 249);
            this.btnDikdörtgenAlanHesapla.Name = "btnDikdörtgenAlanHesapla";
            this.btnDikdörtgenAlanHesapla.Size = new System.Drawing.Size(234, 34);
            this.btnDikdörtgenAlanHesapla.TabIndex = 21;
            this.btnDikdörtgenAlanHesapla.Text = "Dikdörtgen Alan Hesapla";
            this.btnDikdörtgenAlanHesapla.UseVisualStyleBackColor = true;
            this.btnDikdörtgenAlanHesapla.Click += new System.EventHandler(this.btnDikdörtgenAlanHesapla_Click);
            // 
            // txtSonucAlan
            // 
            this.txtSonucAlan.Location = new System.Drawing.Point(557, 366);
            this.txtSonucAlan.Name = "txtSonucAlan";
            this.txtSonucAlan.Size = new System.Drawing.Size(100, 22);
            this.txtSonucAlan.TabIndex = 24;
            // 
            // lblSonucAlan
            // 
            this.lblSonucAlan.AutoSize = true;
            this.lblSonucAlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucAlan.Location = new System.Drawing.Point(418, 358);
            this.lblSonucAlan.Name = "lblSonucAlan";
            this.lblSonucAlan.Size = new System.Drawing.Size(124, 29);
            this.lblSonucAlan.TabIndex = 23;
            this.lblSonucAlan.Text = "SONUÇ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 532);
            this.Controls.Add(this.txtSonucAlan);
            this.Controls.Add(this.lblSonucAlan);
            this.Controls.Add(this.btnKareAlanHesapla);
            this.Controls.Add(this.btnDikdörtgenAlanHesapla);
            this.Controls.Add(this.lblAlanHesapla);
            this.Controls.Add(this.txtKareAlan);
            this.Controls.Add(this.lblKareAlan);
            this.Controls.Add(this.txtKisaKenarAlan);
            this.Controls.Add(this.lblKisaKenarAlan);
            this.Controls.Add(this.txtUzunKenarAlan);
            this.Controls.Add(this.lblUzunKenarAlan);
            this.Controls.Add(this.btnKüpHacimHesapla);
            this.Controls.Add(this.txtKüp);
            this.Controls.Add(this.lblKüp);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtAyritUzunluk);
            this.Controls.Add(this.lblAyrıtUzunluk);
            this.Controls.Add(this.txtKisaKenar);
            this.Controls.Add(this.lblKisaKenar);
            this.Controls.Add(this.btnDikdörtgenHacimHesapla);
            this.Controls.Add(this.txtUzunKenar);
            this.Controls.Add(this.lblUzunKenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUzunKenar;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.Button btnDikdörtgenHacimHesapla;
        private System.Windows.Forms.TextBox txtKisaKenar;
        private System.Windows.Forms.Label lblKisaKenar;
        private System.Windows.Forms.TextBox txtAyritUzunluk;
        private System.Windows.Forms.Label lblAyrıtUzunluk;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblKüp;
        private System.Windows.Forms.TextBox txtKüp;
        private System.Windows.Forms.Button btnKüpHacimHesapla;
        private System.Windows.Forms.TextBox txtKareAlan;
        private System.Windows.Forms.Label lblKareAlan;
        private System.Windows.Forms.TextBox txtKisaKenarAlan;
        private System.Windows.Forms.Label lblKisaKenarAlan;
        private System.Windows.Forms.TextBox txtUzunKenarAlan;
        private System.Windows.Forms.Label lblUzunKenarAlan;
        private System.Windows.Forms.Label lblAlanHesapla;
        private System.Windows.Forms.Button btnKareAlanHesapla;
        private System.Windows.Forms.Button btnDikdörtgenAlanHesapla;
        private System.Windows.Forms.TextBox txtSonucAlan;
        private System.Windows.Forms.Label lblSonucAlan;
    }
}

