namespace KutuphaneCore
{
    partial class KitapIslem
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
			this.ktpBarkod = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ktpAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ktpYazar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ktpSayfa = new System.Windows.Forms.NumericUpDown();
			this.ktpBasım = new System.Windows.Forms.DateTimePicker();
			this.ktpTur = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ktpButon = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ktpSayfa)).BeginInit();
			this.SuspendLayout();
			// 
			// ktpBarkod
			// 
			this.ktpBarkod.Location = new System.Drawing.Point(19, 47);
			this.ktpBarkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpBarkod.Name = "ktpBarkod";
			this.ktpBarkod.Size = new System.Drawing.Size(114, 27);
			this.ktpBarkod.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Barkod No";
			// 
			// ktpAd
			// 
			this.ktpAd.Location = new System.Drawing.Point(19, 113);
			this.ktpAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpAd.Name = "ktpAd";
			this.ktpAd.Size = new System.Drawing.Size(114, 27);
			this.ktpAd.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kitap Ad";
			// 
			// ktpYazar
			// 
			this.ktpYazar.Location = new System.Drawing.Point(19, 176);
			this.ktpYazar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpYazar.Name = "ktpYazar";
			this.ktpYazar.Size = new System.Drawing.Size(114, 27);
			this.ktpYazar.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Yazar";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(167, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Sayfa Sayısı";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(167, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Basım Tarihi";
			// 
			// ktpSayfa
			// 
			this.ktpSayfa.Location = new System.Drawing.Point(167, 47);
			this.ktpSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpSayfa.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.ktpSayfa.Name = "ktpSayfa";
			this.ktpSayfa.Size = new System.Drawing.Size(229, 27);
			this.ktpSayfa.TabIndex = 2;
			// 
			// ktpBasım
			// 
			this.ktpBasım.Location = new System.Drawing.Point(167, 109);
			this.ktpBasım.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpBasım.Name = "ktpBasım";
			this.ktpBasım.Size = new System.Drawing.Size(228, 27);
			this.ktpBasım.TabIndex = 3;
			// 
			// ktpTur
			// 
			this.ktpTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ktpTur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ktpTur.FormattingEnabled = true;
			this.ktpTur.Location = new System.Drawing.Point(167, 176);
			this.ktpTur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpTur.Name = "ktpTur";
			this.ktpTur.Size = new System.Drawing.Size(228, 28);
			this.ktpTur.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(167, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Kitap Turu";
			// 
			// ktpButon
			// 
			this.ktpButon.Location = new System.Drawing.Point(14, 224);
			this.ktpButon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ktpButon.Name = "ktpButon";
			this.ktpButon.Size = new System.Drawing.Size(387, 57);
			this.ktpButon.TabIndex = 5;
			this.ktpButon.Text = "İşlemi Yap";
			this.ktpButon.UseVisualStyleBackColor = true;
			this.ktpButon.Click += new System.EventHandler(this.KtpButon_Click);
			// 
			// KitapIslem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 299);
			this.Controls.Add(this.ktpButon);
			this.Controls.Add(this.ktpTur);
			this.Controls.Add(this.ktpBasım);
			this.Controls.Add(this.ktpSayfa);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ktpYazar);
			this.Controls.Add(this.ktpAd);
			this.Controls.Add(this.ktpBarkod);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "KitapIslem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kitap Islem";
			this.Load += new System.EventHandler(this.KitapIslem_Load);
			((System.ComponentModel.ISupportInitialize)(this.ktpSayfa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ktpBarkod;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ktpAd;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ktpYazar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown ktpSayfa;
        public System.Windows.Forms.DateTimePicker ktpBasım;
        public System.Windows.Forms.ComboBox ktpTur;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button ktpButon;
    }
}