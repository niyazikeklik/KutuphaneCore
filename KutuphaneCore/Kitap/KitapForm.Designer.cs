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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdBtn_TC = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.rdBtn_ismeGore = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.data_TumKitap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_KitapGit = new MetroFramework.Controls.MetroButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_KtpGuncelle = new MetroFramework.Controls.MetroButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_KtpSil = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_KtpEkle = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_TumKitap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(553, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Tüm Kitaplar";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rdBtn_TC);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.txtAra);
            this.panel7.Controls.Add(this.rdBtn_ismeGore);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(155, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(553, 53);
            this.panel7.TabIndex = 25;
            // 
            // rdBtn_TC
            // 
            this.rdBtn_TC.AutoSize = true;
            this.rdBtn_TC.CustomBackground = false;
            this.rdBtn_TC.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rdBtn_TC.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rdBtn_TC.Location = new System.Drawing.Point(454, 32);
            this.rdBtn_TC.Name = "rdBtn_TC";
            this.rdBtn_TC.Size = new System.Drawing.Size(96, 15);
            this.rdBtn_TC.Style = MetroFramework.MetroColorStyle.Blue;
            this.rdBtn_TC.StyleManager = null;
            this.rdBtn_TC.TabIndex = 20;
            this.rdBtn_TC.Text = "Barkod\'a göre";
            this.rdBtn_TC.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdBtn_TC.UseStyleColors = false;
            this.rdBtn_TC.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::View.Properties.Resources._6586131_find_glass_magnifier_search_seo_icon;
            this.pictureBox5.Location = new System.Drawing.Point(295, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAra.Location = new System.Drawing.Point(323, 20);
            this.txtAra.MaxLength = 11;
            this.txtAra.Name = "txtAra";
            this.txtAra.PlaceholderText = "Arama";
            this.txtAra.Size = new System.Drawing.Size(125, 27);
            this.txtAra.TabIndex = 18;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged_1);
            // 
            // rdBtn_ismeGore
            // 
            this.rdBtn_ismeGore.AutoSize = true;
            this.rdBtn_ismeGore.Checked = true;
            this.rdBtn_ismeGore.CustomBackground = false;
            this.rdBtn_ismeGore.FontSize = MetroFramework.MetroLinkSize.Small;
            this.rdBtn_ismeGore.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.rdBtn_ismeGore.Location = new System.Drawing.Point(454, 17);
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
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::View.Properties.Resources._5269101_book_education_library_notebook_read_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox6.Image = global::View.Properties.Resources._8675075_ic_fluent_notebook_regular_icon;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox7.Image = global::View.Properties.Resources._8675228_ic_fluent_notebook_sync_regular_icon;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox8.Image = global::View.Properties.Resources._8675050_ic_fluent_notebook_question_mark_icon;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 48);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.data_TumKitap);
            this.panel8.Controls.Add(this.metroLabel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(155, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(553, 327);
            this.panel8.TabIndex = 26;
            // 
            // data_TumKitap
            // 
            this.data_TumKitap.AllowUserToResizeColumns = false;
            this.data_TumKitap.AllowUserToResizeRows = false;
            this.data_TumKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TumKitap.BackgroundColor = System.Drawing.Color.White;
            this.data_TumKitap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_TumKitap.ColumnHeadersHeight = 30;
            this.data_TumKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_TumKitap.Location = new System.Drawing.Point(0, 21);
            this.data_TumKitap.MultiSelect = false;
            this.data_TumKitap.Name = "data_TumKitap";
            this.data_TumKitap.RowHeadersVisible = false;
            this.data_TumKitap.RowTemplate.Height = 30;
            this.data_TumKitap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_TumKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_TumKitap.Size = new System.Drawing.Size(553, 306);
            this.data_TumKitap.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 380);
            this.panel1.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Btn_KitapGit);
            this.panel6.Controls.Add(this.pictureBox8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 327);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(155, 48);
            this.panel6.TabIndex = 4;
            // 
            // Btn_KitapGit
            // 
            this.Btn_KitapGit.BackColor = System.Drawing.Color.White;
            this.Btn_KitapGit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_KitapGit.Highlight = true;
            this.Btn_KitapGit.Location = new System.Drawing.Point(48, 0);
            this.Btn_KitapGit.Name = "Btn_KitapGit";
            this.Btn_KitapGit.Size = new System.Drawing.Size(107, 48);
            this.Btn_KitapGit.Style = MetroFramework.MetroColorStyle.White;
            this.Btn_KitapGit.StyleManager = null;
            this.Btn_KitapGit.TabIndex = 9;
            this.Btn_KitapGit.Text = "Kitaba git";
            this.Btn_KitapGit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_KitapGit.UseVisualStyleBackColor = false;
            this.Btn_KitapGit.Click += new System.EventHandler(this.Btn_KitapGit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_KtpGuncelle);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 48);
            this.panel5.TabIndex = 3;
            // 
            // btn_KtpGuncelle
            // 
            this.btn_KtpGuncelle.BackColor = System.Drawing.Color.White;
            this.btn_KtpGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KtpGuncelle.Highlight = true;
            this.btn_KtpGuncelle.Location = new System.Drawing.Point(48, 0);
            this.btn_KtpGuncelle.Name = "btn_KtpGuncelle";
            this.btn_KtpGuncelle.Size = new System.Drawing.Size(107, 48);
            this.btn_KtpGuncelle.Style = MetroFramework.MetroColorStyle.White;
            this.btn_KtpGuncelle.StyleManager = null;
            this.btn_KtpGuncelle.TabIndex = 9;
            this.btn_KtpGuncelle.Text = "Kitap Güncelle";
            this.btn_KtpGuncelle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_KtpGuncelle.UseVisualStyleBackColor = false;
            this.btn_KtpGuncelle.Click += new System.EventHandler(this.btn_KtpGuncelle_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_KtpSil);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 48);
            this.panel4.TabIndex = 2;
            // 
            // btn_KtpSil
            // 
            this.btn_KtpSil.BackColor = System.Drawing.Color.White;
            this.btn_KtpSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KtpSil.Highlight = true;
            this.btn_KtpSil.Location = new System.Drawing.Point(48, 0);
            this.btn_KtpSil.Name = "btn_KtpSil";
            this.btn_KtpSil.Size = new System.Drawing.Size(107, 48);
            this.btn_KtpSil.Style = MetroFramework.MetroColorStyle.White;
            this.btn_KtpSil.StyleManager = null;
            this.btn_KtpSil.TabIndex = 9;
            this.btn_KtpSil.Text = "Kitap Sil";
            this.btn_KtpSil.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_KtpSil.UseVisualStyleBackColor = false;
            this.btn_KtpSil.Click += new System.EventHandler(this.btn_KtpSil_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_KtpEkle);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 48);
            this.panel3.TabIndex = 1;
            // 
            // btn_KtpEkle
            // 
            this.btn_KtpEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.btn_KtpEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KtpEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KtpEkle.Highlight = true;
            this.btn_KtpEkle.Location = new System.Drawing.Point(48, 0);
            this.btn_KtpEkle.Name = "btn_KtpEkle";
            this.btn_KtpEkle.Size = new System.Drawing.Size(107, 48);
            this.btn_KtpEkle.Style = MetroFramework.MetroColorStyle.White;
            this.btn_KtpEkle.StyleManager = null;
            this.btn_KtpEkle.TabIndex = 9;
            this.btn_KtpEkle.Text = "Kitap Ekle";
            this.btn_KtpEkle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_KtpEkle.UseVisualStyleBackColor = false;
            this.btn_KtpEkle.Click += new System.EventHandler(this.btn_KtpEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::View.Properties.Resources._8675120_ic_fluent_notebook_add_regular_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 183);
            this.panel2.TabIndex = 0;
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap";
            this.Load += new System.EventHandler(this.KitapForm_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_TumKitap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroRadioButton rdBtn_TC;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.TextBox txtAra;
        private MetroFramework.Controls.MetroRadioButton rdBtn_ismeGore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.DataGridView data_TumKitap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroButton Btn_KitapGit;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton btn_KtpGuncelle;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroButton btn_KtpSil;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btn_KtpEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}