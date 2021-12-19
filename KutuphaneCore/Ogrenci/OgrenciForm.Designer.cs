namespace View.Ogrenci
{
    partial class OgrenciForm
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
            this.btn_OgrGuncelle = new MetroFramework.Controls.MetroButton();
            this.OgrSil = new MetroFramework.Controls.MetroButton();
            this.OgrEkle = new MetroFramework.Controls.MetroButton();
            this.btn_OgrenciyeGit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.data_Ogrenci = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdBtn_ismeGore = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtn_TC = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OgrGuncelle
            // 
            this.btn_OgrGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OgrGuncelle.Highlight = true;
            this.btn_OgrGuncelle.Location = new System.Drawing.Point(328, 72);
            this.btn_OgrGuncelle.Name = "btn_OgrGuncelle";
            this.btn_OgrGuncelle.Size = new System.Drawing.Size(115, 32);
            this.btn_OgrGuncelle.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_OgrGuncelle.StyleManager = null;
            this.btn_OgrGuncelle.TabIndex = 7;
            this.btn_OgrGuncelle.Text = "Öğrenciyi Güncelle";
            this.btn_OgrGuncelle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_OgrGuncelle.Click += new System.EventHandler(this.btn_OgrGuncelle_Click);
            // 
            // OgrSil
            // 
            this.OgrSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OgrSil.Highlight = true;
            this.OgrSil.Location = new System.Drawing.Point(207, 72);
            this.OgrSil.Name = "OgrSil";
            this.OgrSil.Size = new System.Drawing.Size(115, 32);
            this.OgrSil.Style = MetroFramework.MetroColorStyle.Blue;
            this.OgrSil.StyleManager = null;
            this.OgrSil.TabIndex = 8;
            this.OgrSil.Text = "Öğrenciyi Sil";
            this.OgrSil.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OgrSil.Click += new System.EventHandler(this.OgrSil_Click_1);
            // 
            // OgrEkle
            // 
            this.OgrEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OgrEkle.Highlight = true;
            this.OgrEkle.Image = global::View.Properties.Resources.ogrEkle;
            this.OgrEkle.Location = new System.Drawing.Point(86, 72);
            this.OgrEkle.Name = "OgrEkle";
            this.OgrEkle.Size = new System.Drawing.Size(115, 32);
            this.OgrEkle.Style = MetroFramework.MetroColorStyle.Blue;
            this.OgrEkle.StyleManager = null;
            this.OgrEkle.TabIndex = 9;
            this.OgrEkle.Text = "Yeni Öğrenci Ekle";
            this.OgrEkle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OgrEkle.Click += new System.EventHandler(this.OgrEkle_Click_1);
            // 
            // btn_OgrenciyeGit
            // 
            this.btn_OgrenciyeGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OgrenciyeGit.Highlight = true;
            this.btn_OgrenciyeGit.Location = new System.Drawing.Point(449, 72);
            this.btn_OgrenciyeGit.Name = "btn_OgrenciyeGit";
            this.btn_OgrenciyeGit.Size = new System.Drawing.Size(115, 32);
            this.btn_OgrenciyeGit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_OgrenciyeGit.StyleManager = null;
            this.btn_OgrenciyeGit.TabIndex = 7;
            this.btn_OgrenciyeGit.Text = "Öğrenciye Git";
            this.btn_OgrenciyeGit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_OgrenciyeGit.Click += new System.EventHandler(this.btn_OgrenciyeGit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(267, 171);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Tüm Öğrenciler";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources._6586118_account_add_avatar_person_profile_icon;
            this.pictureBox1.Location = new System.Drawing.Point(119, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::View.Properties.Resources._6586134_person_profile_remove_user_icon;
            this.pictureBox2.Location = new System.Drawing.Point(240, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::View.Properties.Resources._6586102_configuration_options_preferences_settings_tools_icon;
            this.pictureBox3.Location = new System.Drawing.Point(361, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::View.Properties.Resources._6586125_account_avatar_person_profile_user_icon;
            this.pictureBox4.Location = new System.Drawing.Point(482, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // data_Ogrenci
            // 
            this.data_Ogrenci.AllowUserToResizeColumns = false;
            this.data_Ogrenci.AllowUserToResizeRows = false;
            this.data_Ogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Ogrenci.ColumnHeadersHeight = 30;
            this.data_Ogrenci.Location = new System.Drawing.Point(32, 195);
            this.data_Ogrenci.MultiSelect = false;
            this.data_Ogrenci.Name = "data_Ogrenci";
            this.data_Ogrenci.RowHeadersVisible = false;
            this.data_Ogrenci.RowTemplate.Height = 30;
            this.data_Ogrenci.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Ogrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Ogrenci.Size = new System.Drawing.Size(594, 235);
            this.data_Ogrenci.TabIndex = 17;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAra.Location = new System.Drawing.Point(501, 141);
            this.txtAra.MaxLength = 11;
            this.txtAra.Name = "txtAra";
            this.txtAra.PlaceholderText = "Arama";
            this.txtAra.Size = new System.Drawing.Size(125, 27);
            this.txtAra.TabIndex = 18;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAra.TextChanged += new System.EventHandler(this.ogrTC_TextChanged);
            // 
            // rdBtn_ismeGore
            // 
            this.rdBtn_ismeGore.AutoSize = true;
            this.rdBtn_ismeGore.Checked = true;
            this.rdBtn_ismeGore.CustomBackground = false;
            this.rdBtn_ismeGore.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rdBtn_ismeGore.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rdBtn_ismeGore.Location = new System.Drawing.Point(471, 171);
            this.rdBtn_ismeGore.Name = "rdBtn_ismeGore";
            this.rdBtn_ismeGore.Size = new System.Drawing.Size(76, 15);
            this.rdBtn_ismeGore.Style = MetroFramework.MetroColorStyle.Blue;
            this.rdBtn_ismeGore.StyleManager = null;
            this.rdBtn_ismeGore.TabIndex = 20;
            this.rdBtn_ismeGore.TabStop = true;
            this.rdBtn_ismeGore.Text = "İsme Göre";
            this.rdBtn_ismeGore.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdBtn_ismeGore.UseStyleColors = false;
            this.rdBtn_ismeGore.UseVisualStyleBackColor = true;
            // 
            // rdBtn_TC
            // 
            this.rdBtn_TC.AutoSize = true;
            this.rdBtn_TC.CustomBackground = false;
            this.rdBtn_TC.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rdBtn_TC.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rdBtn_TC.Location = new System.Drawing.Point(548, 171);
            this.rdBtn_TC.Name = "rdBtn_TC";
            this.rdBtn_TC.Size = new System.Drawing.Size(78, 15);
            this.rdBtn_TC.Style = MetroFramework.MetroColorStyle.Blue;
            this.rdBtn_TC.StyleManager = null;
            this.rdBtn_TC.TabIndex = 20;
            this.rdBtn_TC.Text = "TC\'ye göre";
            this.rdBtn_TC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdBtn_TC.UseStyleColors = false;
            this.rdBtn_TC.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::View.Properties.Resources._6586131_find_glass_magnifier_search_seo_icon1;
            this.pictureBox5.Location = new System.Drawing.Point(471, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.rdBtn_TC);
            this.Controls.Add(this.rdBtn_ismeGore);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.data_Ogrenci);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_OgrenciyeGit);
            this.Controls.Add(this.btn_OgrGuncelle);
            this.Controls.Add(this.OgrEkle);
            this.Controls.Add(this.OgrSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_OgrGuncelle;
        private MetroFramework.Controls.MetroButton OgrSil;
        private MetroFramework.Controls.MetroButton OgrEkle;
        private MetroFramework.Controls.MetroButton btn_OgrenciyeGit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.DataGridView data_Ogrenci;
        public System.Windows.Forms.TextBox txtAra;
        private MetroFramework.Controls.MetroRadioButton rdBtn_ismeGore;
        private MetroFramework.Controls.MetroRadioButton rdBtn_TC;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}