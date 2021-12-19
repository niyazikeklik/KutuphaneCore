namespace View.Kitap
{
    partial class KitapForm
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
            this.btn_KitapEkle = new MetroFramework.Controls.MetroButton();
            this.btn_KitapSil = new MetroFramework.Controls.MetroButton();
            this.btn_KitapGuncelle = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.data_TumKitap = new System.Windows.Forms.DataGridView();
            this.rdBtn_TC = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtn_ismeGore = new MetroFramework.Controls.MetroRadioButton();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_TumKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_KitapEkle
            // 
            this.btn_KitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapEkle.Highlight = true;
            this.btn_KitapEkle.Location = new System.Drawing.Point(170, 60);
            this.btn_KitapEkle.Name = "btn_KitapEkle";
            this.btn_KitapEkle.Size = new System.Drawing.Size(115, 37);
            this.btn_KitapEkle.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_KitapEkle.StyleManager = null;
            this.btn_KitapEkle.TabIndex = 0;
            this.btn_KitapEkle.Text = "Yeni Kitap Ekle";
            this.btn_KitapEkle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_KitapEkle.Click += new System.EventHandler(this.btn_KitapEkle_Click);
            // 
            // btn_KitapSil
            // 
            this.btn_KitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapSil.Highlight = true;
            this.btn_KitapSil.Location = new System.Drawing.Point(291, 60);
            this.btn_KitapSil.Name = "btn_KitapSil";
            this.btn_KitapSil.Size = new System.Drawing.Size(115, 37);
            this.btn_KitapSil.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_KitapSil.StyleManager = null;
            this.btn_KitapSil.TabIndex = 0;
            this.btn_KitapSil.Text = "Kitabı Sil";
            this.btn_KitapSil.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_KitapSil.Click += new System.EventHandler(this.btn_KitapSil_Click);
            // 
            // btn_KitapGuncelle
            // 
            this.btn_KitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KitapGuncelle.Highlight = true;
            this.btn_KitapGuncelle.Location = new System.Drawing.Point(412, 60);
            this.btn_KitapGuncelle.Name = "btn_KitapGuncelle";
            this.btn_KitapGuncelle.Size = new System.Drawing.Size(115, 37);
            this.btn_KitapGuncelle.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_KitapGuncelle.StyleManager = null;
            this.btn_KitapGuncelle.TabIndex = 0;
            this.btn_KitapGuncelle.Text = "Kitabı Guncele";
            this.btn_KitapGuncelle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_KitapGuncelle.Click += new System.EventHandler(this.btn_KitapGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources._103409_text_add_book_icon;
            this.pictureBox1.Location = new System.Drawing.Point(203, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::View.Properties.Resources._103412_text_book_remove_icon;
            this.pictureBox2.Location = new System.Drawing.Point(324, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::View.Properties.Resources._103415_text_book_settings_icon;
            this.pictureBox3.Location = new System.Drawing.Point(445, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(273, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Tüm Kitaplar";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // data_TumKitap
            // 
            this.data_TumKitap.AllowUserToResizeColumns = false;
            this.data_TumKitap.AllowUserToResizeRows = false;
            this.data_TumKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TumKitap.ColumnHeadersHeight = 30;
            this.data_TumKitap.Location = new System.Drawing.Point(21, 162);
            this.data_TumKitap.MultiSelect = false;
            this.data_TumKitap.Name = "data_TumKitap";
            this.data_TumKitap.RowHeadersVisible = false;
            this.data_TumKitap.RowTemplate.Height = 30;
            this.data_TumKitap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_TumKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_TumKitap.Size = new System.Drawing.Size(674, 203);
            this.data_TumKitap.TabIndex = 18;
            // 
            // rdBtn_TC
            // 
            this.rdBtn_TC.AutoSize = true;
            this.rdBtn_TC.CustomBackground = false;
            this.rdBtn_TC.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rdBtn_TC.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rdBtn_TC.Location = new System.Drawing.Point(599, 142);
            this.rdBtn_TC.Name = "rdBtn_TC";
            this.rdBtn_TC.Size = new System.Drawing.Size(96, 15);
            this.rdBtn_TC.Style = MetroFramework.MetroColorStyle.Blue;
            this.rdBtn_TC.StyleManager = null;
            this.rdBtn_TC.TabIndex = 23;
            this.rdBtn_TC.Text = "Barkod\'a göre";
            this.rdBtn_TC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdBtn_TC.UseStyleColors = false;
            this.rdBtn_TC.UseVisualStyleBackColor = true;
            // 
            // rdBtn_ismeGore
            // 
            this.rdBtn_ismeGore.AutoSize = true;
            this.rdBtn_ismeGore.Checked = true;
            this.rdBtn_ismeGore.CustomBackground = false;
            this.rdBtn_ismeGore.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rdBtn_ismeGore.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rdBtn_ismeGore.Location = new System.Drawing.Point(522, 142);
            this.rdBtn_ismeGore.Name = "rdBtn_ismeGore";
            this.rdBtn_ismeGore.Size = new System.Drawing.Size(76, 15);
            this.rdBtn_ismeGore.Style = MetroFramework.MetroColorStyle.Blue;
            this.rdBtn_ismeGore.StyleManager = null;
            this.rdBtn_ismeGore.TabIndex = 24;
            this.rdBtn_ismeGore.TabStop = true;
            this.rdBtn_ismeGore.Text = "İsme Göre";
            this.rdBtn_ismeGore.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdBtn_ismeGore.UseStyleColors = false;
            this.rdBtn_ismeGore.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAra.Location = new System.Drawing.Point(552, 112);
            this.txtAra.MaxLength = 11;
            this.txtAra.Name = "txtAra";
            this.txtAra.PlaceholderText = "Arama";
            this.txtAra.Size = new System.Drawing.Size(143, 27);
            this.txtAra.TabIndex = 22;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::View.Properties.Resources._6586131_find_glass_magnifier_search_seo_icon1;
            this.pictureBox5.Location = new System.Drawing.Point(522, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.rdBtn_TC);
            this.Controls.Add(this.rdBtn_ismeGore);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.data_TumKitap);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_KitapGuncelle);
            this.Controls.Add(this.btn_KitapSil);
            this.Controls.Add(this.btn_KitapEkle);
            this.Name = "KitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapProfil";
            this.Load += new System.EventHandler(this.KitapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_TumKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_KitapEkle;
        private MetroFramework.Controls.MetroButton btn_KitapSil;
        private MetroFramework.Controls.MetroButton btn_KitapGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.DataGridView data_TumKitap;
        private MetroFramework.Controls.MetroRadioButton rdBtn_TC;
        private MetroFramework.Controls.MetroRadioButton rdBtn_ismeGore;
        public System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}