namespace KutuphaneCore
{
    partial class OgrenciIslem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrTC = new System.Windows.Forms.TextBox();
            this.ogrAd = new System.Windows.Forms.TextBox();
            this.OgrTelNo = new System.Windows.Forms.TextBox();
            this.OgrBirt = new System.Windows.Forms.DateTimePicker();
            this.OgrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dogum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon Numarası";
            // 
            // ogrTC
            // 
            this.ogrTC.Location = new System.Drawing.Point(30, 49);
            this.ogrTC.MaxLength = 9;
            this.ogrTC.Name = "ogrTC";
            this.ogrTC.PlaceholderText = "Ogrenci TC";
            this.ogrTC.Size = new System.Drawing.Size(100, 23);
            this.ogrTC.TabIndex = 1;
            // 
            // ogrAd
            // 
            this.ogrAd.Location = new System.Drawing.Point(30, 108);
            this.ogrAd.Name = "ogrAd";
            this.ogrAd.PlaceholderText = "İsim Soyisim";
            this.ogrAd.Size = new System.Drawing.Size(100, 23);
            this.ogrAd.TabIndex = 1;
            // 
            // OgrTelNo
            // 
            this.OgrTelNo.Location = new System.Drawing.Point(149, 108);
            this.OgrTelNo.Name = "OgrTelNo";
            this.OgrTelNo.PlaceholderText = "Telefon Numarası";
            this.OgrTelNo.Size = new System.Drawing.Size(201, 23);
            this.OgrTelNo.TabIndex = 1;
            // 
            // OgrBirt
            // 
            this.OgrBirt.Location = new System.Drawing.Point(150, 49);
            this.OgrBirt.Name = "OgrBirt";
            this.OgrBirt.Size = new System.Drawing.Size(200, 23);
            this.OgrBirt.TabIndex = 2;
            // 
            // OgrButton
            // 
            this.OgrButton.Location = new System.Drawing.Point(30, 149);
            this.OgrButton.Name = "OgrButton";
            this.OgrButton.Size = new System.Drawing.Size(320, 41);
            this.OgrButton.TabIndex = 3;
            this.OgrButton.Text = "İşlemi Yap";
            this.OgrButton.UseVisualStyleBackColor = true;
            this.OgrButton.Click += new System.EventHandler(this.OgrButton_Click);
            // 
            // OgrenciIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 208);
            this.Controls.Add(this.OgrButton);
            this.Controls.Add(this.OgrBirt);
            this.Controls.Add(this.OgrTelNo);
            this.Controls.Add(this.ogrAd);
            this.Controls.Add(this.ogrTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci Ekle";
            this.Load += new System.EventHandler(this.OgrenciIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox ogrTC;
        public System.Windows.Forms.Button OgrButton;
        public System.Windows.Forms.TextBox ogrAd;
        public System.Windows.Forms.TextBox OgrTelNo;
        public System.Windows.Forms.DateTimePicker OgrBirt;
    }
}
