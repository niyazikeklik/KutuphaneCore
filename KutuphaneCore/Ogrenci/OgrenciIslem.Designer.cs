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
            this.ogrTC = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ogrAd = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.OgrBirt = new System.Windows.Forms.DateTimePicker();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.OgrTeNo = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.OgrButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ogrTC
            // 
            this.ogrTC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ogrTC.Location = new System.Drawing.Point(30, 49);
            this.ogrTC.MaxLength = 11;
            this.ogrTC.Name = "ogrTC";
            this.ogrTC.PlaceholderText = "000";
            this.ogrTC.Size = new System.Drawing.Size(155, 27);
            this.ogrTC.TabIndex = 0;
            this.ogrTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(30, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Öğrenci TC No";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(30, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(155, 21);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "İsim Soyisim";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // ogrAd
            // 
            this.ogrAd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ogrAd.Location = new System.Drawing.Point(30, 103);
            this.ogrAd.MaxLength = 30;
            this.ogrAd.Name = "ogrAd";
            this.ogrAd.PlaceholderText = "İsim Soyisim";
            this.ogrAd.Size = new System.Drawing.Size(155, 27);
            this.ogrAd.TabIndex = 1;
            this.ogrAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel3
            // 
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(30, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(155, 21);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Doğum Tarihi";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // OgrBirt
            // 
            this.OgrBirt.Location = new System.Drawing.Point(30, 211);
            this.OgrBirt.Name = "OgrBirt";
            this.OgrBirt.Size = new System.Drawing.Size(155, 23);
            this.OgrBirt.TabIndex = 3;
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // OgrTeNo
            // 
            this.OgrTeNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OgrTeNo.Location = new System.Drawing.Point(30, 157);
            this.OgrTeNo.MaxLength = 10;
            this.OgrTeNo.Name = "OgrTeNo";
            this.OgrTeNo.PlaceholderText = "534 000 00 00";
            this.OgrTeNo.Size = new System.Drawing.Size(155, 27);
            this.OgrTeNo.TabIndex = 2;
            this.OgrTeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel4
            // 
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(30, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(155, 21);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Telefon No";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // OgrButton
            // 
            this.OgrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OgrButton.Highlight = true;

            this.OgrButton.Location = new System.Drawing.Point(75, 244);
            this.OgrButton.Name = "OgrButton";
            this.OgrButton.Size = new System.Drawing.Size(110, 32);
            this.OgrButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OgrButton.StyleManager = null;
            this.OgrButton.TabIndex = 4;
            this.OgrButton.Text = "İşlemi Yap";
            this.OgrButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OgrButton.Click += new System.EventHandler(this.OgrEkle_Click);
            // 
            // OgrenciIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(212, 288);
            this.Controls.Add(this.OgrButton);
            this.Controls.Add(this.OgrBirt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.OgrTeNo);
            this.Controls.Add(this.ogrAd);
            this.Controls.Add(this.ogrTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OgrenciIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci Ekle";
            this.Load += new System.EventHandler(this.OgrenciIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ogrTC;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.TextBox ogrAd;
        public System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        public System.Windows.Forms.TextBox OgrTeNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public System.Windows.Forms.DateTimePicker OgrBirt;
        public MetroFramework.Controls.MetroButton OgrButton;
    }
}
