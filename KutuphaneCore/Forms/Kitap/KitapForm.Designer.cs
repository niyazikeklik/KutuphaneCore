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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapForm));
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.data_TumKitap = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.rdBtn_ismeGore = new MetroFramework.Controls.MetroRadioButton();
			this.rdBtn_TC = new MetroFramework.Controls.MetroRadioButton();
			this.panel11 = new System.Windows.Forms.Panel();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Btn_KitapGit = new View.CustomElement.CustomButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.Btn_KitaGuncelle = new View.CustomElement.CustomButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Btn_KitapSil = new View.CustomElement.CustomButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Btn_KitapEkle = new View.CustomElement.CustomButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data_TumKitap)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
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
			this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.metroLabel1.CustomBackground = false;
			this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.ForeColor = System.Drawing.Color.White;
			this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
			this.metroLabel1.Location = new System.Drawing.Point(0, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(867, 21);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
			this.metroLabel1.StyleManager = null;
			this.metroLabel1.TabIndex = 18;
			this.metroLabel1.Text = "Tüm Kitaplar";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseStyleColors = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = global::View.Properties.Resources.kitapSimge;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 183);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox6.Image = global::View.Properties.Resources.kitapSil;
			this.pictureBox6.Location = new System.Drawing.Point(0, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(48, 48);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 11;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox7.Image = global::View.Properties.Resources.kitapGuncelle;
			this.pictureBox7.Location = new System.Drawing.Point(0, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(48, 48);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 11;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox8.Image = global::View.Properties.Resources.kitapSil;
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
			this.panel8.Location = new System.Drawing.Point(200, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(867, 438);
			this.panel8.TabIndex = 26;
			// 
			// data_TumKitap
			// 
			this.data_TumKitap.AllowUserToAddRows = false;
			this.data_TumKitap.AllowUserToDeleteRows = false;
			this.data_TumKitap.AllowUserToResizeColumns = false;
			this.data_TumKitap.AllowUserToResizeRows = false;
			this.data_TumKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.data_TumKitap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.data_TumKitap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.data_TumKitap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.data_TumKitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.data_TumKitap.ColumnHeadersHeight = 50;
			this.data_TumKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data_TumKitap.DefaultCellStyle = dataGridViewCellStyle2;
			this.data_TumKitap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.data_TumKitap.EnableHeadersVisualStyles = false;
			this.data_TumKitap.GridColor = System.Drawing.SystemColors.Control;
			this.data_TumKitap.Location = new System.Drawing.Point(0, 21);
			this.data_TumKitap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.data_TumKitap.MultiSelect = false;
			this.data_TumKitap.Name = "data_TumKitap";
			this.data_TumKitap.ReadOnly = true;
			this.data_TumKitap.RowHeadersVisible = false;
			this.data_TumKitap.RowHeadersWidth = 51;
			this.data_TumKitap.RowTemplate.Height = 40;
			this.data_TumKitap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.data_TumKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.data_TumKitap.ShowCellToolTips = false;
			this.data_TumKitap.ShowEditingIcon = false;
			this.data_TumKitap.Size = new System.Drawing.Size(867, 417);
			this.data_TumKitap.TabIndex = 36;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 438);
			this.panel1.TabIndex = 24;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.panel10);
			this.panel9.Controls.Add(this.panel11);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 375);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(200, 63);
			this.panel9.TabIndex = 25;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.rdBtn_ismeGore);
			this.panel10.Controls.Add(this.rdBtn_TC);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 29);
			this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(200, 43);
			this.panel10.TabIndex = 22;
			// 
			// rdBtn_ismeGore
			// 
			this.rdBtn_ismeGore.AutoSize = true;
			this.rdBtn_ismeGore.Checked = true;
			this.rdBtn_ismeGore.CustomBackground = false;
			this.rdBtn_ismeGore.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdBtn_ismeGore.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.rdBtn_ismeGore.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.rdBtn_ismeGore.Location = new System.Drawing.Point(112, 0);
			this.rdBtn_ismeGore.Name = "rdBtn_ismeGore";
			this.rdBtn_ismeGore.Size = new System.Drawing.Size(88, 43);
			this.rdBtn_ismeGore.Style = MetroFramework.MetroColorStyle.Blue;
			this.rdBtn_ismeGore.StyleManager = null;
			this.rdBtn_ismeGore.TabIndex = 25;
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
			this.rdBtn_TC.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdBtn_TC.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.rdBtn_TC.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.rdBtn_TC.Location = new System.Drawing.Point(0, 0);
			this.rdBtn_TC.Name = "rdBtn_TC";
			this.rdBtn_TC.Size = new System.Drawing.Size(112, 43);
			this.rdBtn_TC.Style = MetroFramework.MetroColorStyle.Blue;
			this.rdBtn_TC.StyleManager = null;
			this.rdBtn_TC.TabIndex = 24;
			this.rdBtn_TC.Text = "Barkod\'a Göre";
			this.rdBtn_TC.Theme = MetroFramework.MetroThemeStyle.Light;
			this.rdBtn_TC.UseStyleColors = false;
			this.rdBtn_TC.UseVisualStyleBackColor = true;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.txtAra);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(200, 29);
			this.panel11.TabIndex = 21;
			// 
			// txtAra
			// 
			this.txtAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAra.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAra.ForeColor = System.Drawing.Color.White;
			this.txtAra.Location = new System.Drawing.Point(0, 0);
			this.txtAra.MaxLength = 11;
			this.txtAra.Multiline = true;
			this.txtAra.Name = "txtAra";
			this.txtAra.PlaceholderText = "Arama";
			this.txtAra.Size = new System.Drawing.Size(200, 29);
			this.txtAra.TabIndex = 18;
			this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.Btn_KitapGit);
			this.panel6.Controls.Add(this.pictureBox8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 327);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(200, 48);
			this.panel6.TabIndex = 4;
			// 
			// Btn_KitapGit
			// 
			this.Btn_KitapGit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_KitapGit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_KitapGit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_KitapGit.ForeColor = System.Drawing.Color.White;
			this.Btn_KitapGit.Location = new System.Drawing.Point(48, 0);
			this.Btn_KitapGit.Name = "Btn_KitapGit";
			this.Btn_KitapGit.Size = new System.Drawing.Size(152, 48);
			this.Btn_KitapGit.TabIndex = 2;
			this.Btn_KitapGit.Text = "Kitaba Git";
			this.Btn_KitapGit.UseVisualStyleBackColor = false;
			this.Btn_KitapGit.Click += new System.EventHandler(this.Btn_KitapGit_Click_1);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.Btn_KitaGuncelle);
			this.panel5.Controls.Add(this.pictureBox7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 279);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(200, 48);
			this.panel5.TabIndex = 3;
			// 
			// Btn_KitaGuncelle
			// 
			this.Btn_KitaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_KitaGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_KitaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_KitaGuncelle.ForeColor = System.Drawing.Color.White;
			this.Btn_KitaGuncelle.Location = new System.Drawing.Point(48, 0);
			this.Btn_KitaGuncelle.Name = "Btn_KitaGuncelle";
			this.Btn_KitaGuncelle.Size = new System.Drawing.Size(152, 48);
			this.Btn_KitaGuncelle.TabIndex = 12;
			this.Btn_KitaGuncelle.Text = "Kitap Güncelle";
			this.Btn_KitaGuncelle.UseVisualStyleBackColor = false;
			this.Btn_KitaGuncelle.Click += new System.EventHandler(this.Btn_KitaGuncelle_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Btn_KitapSil);
			this.panel4.Controls.Add(this.pictureBox6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 231);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 48);
			this.panel4.TabIndex = 2;
			// 
			// Btn_KitapSil
			// 
			this.Btn_KitapSil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_KitapSil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_KitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_KitapSil.ForeColor = System.Drawing.Color.White;
			this.Btn_KitapSil.Location = new System.Drawing.Point(48, 0);
			this.Btn_KitapSil.Name = "Btn_KitapSil";
			this.Btn_KitapSil.Size = new System.Drawing.Size(152, 48);
			this.Btn_KitapSil.TabIndex = 12;
			this.Btn_KitapSil.Text = "Kitap Sil";
			this.Btn_KitapSil.UseVisualStyleBackColor = false;
			this.Btn_KitapSil.Click += new System.EventHandler(this.Btn_KitapSil_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.Btn_KitapEkle);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 183);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 48);
			this.panel3.TabIndex = 1;
			// 
			// Btn_KitapEkle
			// 
			this.Btn_KitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_KitapEkle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_KitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_KitapEkle.ForeColor = System.Drawing.Color.White;
			this.Btn_KitapEkle.Location = new System.Drawing.Point(48, 0);
			this.Btn_KitapEkle.Name = "Btn_KitapEkle";
			this.Btn_KitapEkle.Size = new System.Drawing.Size(152, 48);
			this.Btn_KitapEkle.TabIndex = 12;
			this.Btn_KitapEkle.Text = "Kitap Ekle";
			this.Btn_KitapEkle.UseVisualStyleBackColor = false;
			this.Btn_KitapEkle.Click += new System.EventHandler(this.Btn_KitapEkle_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::View.Properties.Resources.kitapEkle;
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
			this.panel2.Size = new System.Drawing.Size(200, 183);
			this.panel2.TabIndex = 0;
			// 
			// KitapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1067, 438);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KitapForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kitap";
			this.Load += new System.EventHandler(this.KitapForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.data_TumKitap)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel11.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView data_TumKitap;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private MetroFramework.Controls.MetroRadioButton rdBtn_TC;
        private MetroFramework.Controls.MetroRadioButton rdBtn_ismeGore;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.TextBox txtAra;
		private CustomElement.CustomButton Btn_KitapGit;
		private CustomElement.CustomButton Btn_KitaGuncelle;
		private CustomElement.CustomButton Btn_KitapSil;
		private CustomElement.CustomButton Btn_KitapEkle;
	}
}