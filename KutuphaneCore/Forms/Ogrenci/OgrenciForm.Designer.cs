using System.Windows.Forms;

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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.data_Ogrenci = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.rdBtn_TC = new MetroFramework.Controls.MetroRadioButton();
			this.rdBtn_ismeGore = new MetroFramework.Controls.MetroRadioButton();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtAra = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.Btn_OgrGit = new View.CustomElement.CustomButton();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.Btn_OgrGuncelle = new View.CustomElement.CustomButton();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Btn_OgrSil = new View.CustomElement.CustomButton();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Btn_OgrEkle = new View.CustomElement.CustomButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data_Ogrenci)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::View.Properties.Resources.ogrEkle;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// data_Ogrenci
			// 
			this.data_Ogrenci.AllowUserToAddRows = false;
			this.data_Ogrenci.AllowUserToDeleteRows = false;
			this.data_Ogrenci.AllowUserToResizeColumns = false;
			this.data_Ogrenci.AllowUserToResizeRows = false;
			this.data_Ogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.data_Ogrenci.BackgroundColor = System.Drawing.Color.White;
			this.data_Ogrenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.data_Ogrenci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.data_Ogrenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.data_Ogrenci.ColumnHeadersHeight = 50;
			this.data_Ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data_Ogrenci.DefaultCellStyle = dataGridViewCellStyle2;
			this.data_Ogrenci.Dock = System.Windows.Forms.DockStyle.Fill;
			this.data_Ogrenci.EnableHeadersVisualStyles = false;
			this.data_Ogrenci.GridColor = System.Drawing.SystemColors.Control;
			this.data_Ogrenci.Location = new System.Drawing.Point(0, 21);
			this.data_Ogrenci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.data_Ogrenci.MultiSelect = false;
			this.data_Ogrenci.Name = "data_Ogrenci";
			this.data_Ogrenci.ReadOnly = true;
			this.data_Ogrenci.RowHeadersVisible = false;
			this.data_Ogrenci.RowHeadersWidth = 51;
			this.data_Ogrenci.RowTemplate.Height = 40;
			this.data_Ogrenci.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.data_Ogrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.data_Ogrenci.ShowCellToolTips = false;
			this.data_Ogrenci.ShowEditingIcon = false;
			this.data_Ogrenci.Size = new System.Drawing.Size(867, 417);
			this.data_Ogrenci.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 438);
			this.panel1.TabIndex = 21;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel10);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 375);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(200, 63);
			this.panel7.TabIndex = 24;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.White;
			this.panel10.Controls.Add(this.rdBtn_TC);
			this.panel10.Controls.Add(this.rdBtn_ismeGore);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 28);
			this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(200, 34);
			this.panel10.TabIndex = 22;
			// 
			// rdBtn_TC
			// 
			this.rdBtn_TC.AutoSize = true;
			this.rdBtn_TC.CustomBackground = false;
			this.rdBtn_TC.Dock = System.Windows.Forms.DockStyle.Right;
			this.rdBtn_TC.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.rdBtn_TC.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.rdBtn_TC.Location = new System.Drawing.Point(111, 0);
			this.rdBtn_TC.Name = "rdBtn_TC";
			this.rdBtn_TC.Size = new System.Drawing.Size(89, 34);
			this.rdBtn_TC.Style = MetroFramework.MetroColorStyle.Blue;
			this.rdBtn_TC.StyleManager = null;
			this.rdBtn_TC.TabIndex = 24;
			this.rdBtn_TC.Text = "TC\'ye göre";
			this.rdBtn_TC.Theme = MetroFramework.MetroThemeStyle.Light;
			this.rdBtn_TC.UseStyleColors = false;
			this.rdBtn_TC.UseVisualStyleBackColor = true;
			// 
			// rdBtn_ismeGore
			// 
			this.rdBtn_ismeGore.AutoSize = true;
			this.rdBtn_ismeGore.Checked = true;
			this.rdBtn_ismeGore.CustomBackground = false;
			this.rdBtn_ismeGore.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdBtn_ismeGore.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.rdBtn_ismeGore.FontWeight = MetroFramework.MetroLinkWeight.Regular;
			this.rdBtn_ismeGore.Location = new System.Drawing.Point(0, 0);
			this.rdBtn_ismeGore.Name = "rdBtn_ismeGore";
			this.rdBtn_ismeGore.Size = new System.Drawing.Size(88, 34);
			this.rdBtn_ismeGore.Style = MetroFramework.MetroColorStyle.Blue;
			this.rdBtn_ismeGore.StyleManager = null;
			this.rdBtn_ismeGore.TabIndex = 25;
			this.rdBtn_ismeGore.TabStop = true;
			this.rdBtn_ismeGore.Text = "İsme Göre";
			this.rdBtn_ismeGore.Theme = MetroFramework.MetroThemeStyle.Light;
			this.rdBtn_ismeGore.UseStyleColors = false;
			this.rdBtn_ismeGore.UseVisualStyleBackColor = true;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.txtAra);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(200, 28);
			this.panel9.TabIndex = 21;
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
			this.txtAra.Name = "txtAra";
			this.txtAra.PlaceholderText = "Arama";
			this.txtAra.Size = new System.Drawing.Size(200, 27);
			this.txtAra.TabIndex = 18;
			this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged_1);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.Btn_OgrGit);
			this.panel6.Controls.Add(this.pictureBox8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 327);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(200, 48);
			this.panel6.TabIndex = 4;
			// 
			// Btn_OgrGit
			// 
			this.Btn_OgrGit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_OgrGit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_OgrGit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_OgrGit.ForeColor = System.Drawing.Color.White;
			this.Btn_OgrGit.Location = new System.Drawing.Point(48, 0);
			this.Btn_OgrGit.Name = "Btn_OgrGit";
			this.Btn_OgrGit.Size = new System.Drawing.Size(152, 48);
			this.Btn_OgrGit.TabIndex = 12;
			this.Btn_OgrGit.Text = "Öğrenciye Git";
			this.Btn_OgrGit.UseVisualStyleBackColor = false;
			this.Btn_OgrGit.Click += new System.EventHandler(this.Btn_OgrGit_Click);
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox8.Image = global::View.Properties.Resources.ogrGit;
			this.pictureBox8.Location = new System.Drawing.Point(0, 0);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(48, 48);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 11;
			this.pictureBox8.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.Btn_OgrGuncelle);
			this.panel5.Controls.Add(this.pictureBox7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 279);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(200, 48);
			this.panel5.TabIndex = 3;
			// 
			// Btn_OgrGuncelle
			// 
			this.Btn_OgrGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_OgrGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_OgrGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_OgrGuncelle.ForeColor = System.Drawing.Color.White;
			this.Btn_OgrGuncelle.Location = new System.Drawing.Point(48, 0);
			this.Btn_OgrGuncelle.Name = "Btn_OgrGuncelle";
			this.Btn_OgrGuncelle.Size = new System.Drawing.Size(152, 48);
			this.Btn_OgrGuncelle.TabIndex = 12;
			this.Btn_OgrGuncelle.Text = "Öğrenci Güncelle";
			this.Btn_OgrGuncelle.UseVisualStyleBackColor = false;
			this.Btn_OgrGuncelle.Click += new System.EventHandler(this.Btn_OgrGuncelle_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox7.Image = global::View.Properties.Resources.ogrGuncelle;
			this.pictureBox7.Location = new System.Drawing.Point(0, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(48, 48);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 11;
			this.pictureBox7.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Btn_OgrSil);
			this.panel4.Controls.Add(this.pictureBox6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 231);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 48);
			this.panel4.TabIndex = 2;
			// 
			// Btn_OgrSil
			// 
			this.Btn_OgrSil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_OgrSil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_OgrSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_OgrSil.ForeColor = System.Drawing.Color.White;
			this.Btn_OgrSil.Location = new System.Drawing.Point(48, 0);
			this.Btn_OgrSil.Name = "Btn_OgrSil";
			this.Btn_OgrSil.Size = new System.Drawing.Size(152, 48);
			this.Btn_OgrSil.TabIndex = 12;
			this.Btn_OgrSil.Text = "Öğrenci Sİl";
			this.Btn_OgrSil.UseVisualStyleBackColor = false;
			this.Btn_OgrSil.Click += new System.EventHandler(this.Btn_OgrSil_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox6.Image = global::View.Properties.Resources.ogrSil;
			this.pictureBox6.Location = new System.Drawing.Point(0, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(48, 48);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 11;
			this.pictureBox6.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.Btn_OgrEkle);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 183);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 48);
			this.panel3.TabIndex = 1;
			// 
			// Btn_OgrEkle
			// 
			this.Btn_OgrEkle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btn_OgrEkle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_OgrEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Btn_OgrEkle.ForeColor = System.Drawing.Color.White;
			this.Btn_OgrEkle.Location = new System.Drawing.Point(48, 0);
			this.Btn_OgrEkle.Name = "Btn_OgrEkle";
			this.Btn_OgrEkle.Size = new System.Drawing.Size(152, 48);
			this.Btn_OgrEkle.TabIndex = 12;
			this.Btn_OgrEkle.Text = "Öğrenci Ekle";
			this.Btn_OgrEkle.UseVisualStyleBackColor = false;
			this.Btn_OgrEkle.Click += new System.EventHandler(this.Btn_OgrEkle_Click);
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
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = global::View.Properties.Resources.buyukErkekOgrenci;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 183);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.data_Ogrenci);
			this.panel8.Controls.Add(this.metroLabel1);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(200, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(867, 438);
			this.panel8.TabIndex = 23;
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
			this.metroLabel1.Size = new System.Drawing.Size(867, 21);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
			this.metroLabel1.StyleManager = null;
			this.metroLabel1.TabIndex = 18;
			this.metroLabel1.Text = "Tüm Öğrenciler";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroLabel1.UseStyleColors = true;
			// 
			// OgrenciForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1067, 438);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OgrenciForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OgrenciForm";
			this.Load += new System.EventHandler(this.OgrenciForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data_Ogrenci)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView data_Ogrenci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Panel panel7;
        private Panel panel10;
        private MetroFramework.Controls.MetroRadioButton rdBtn_TC;
        private MetroFramework.Controls.MetroRadioButton rdBtn_ismeGore;
        private Panel panel9;
        public TextBox txtAra;
		private CustomElement.CustomButton Btn_OgrGit;
		private CustomElement.CustomButton Btn_OgrGuncelle;
		private CustomElement.CustomButton Btn_OgrSil;
		private CustomElement.CustomButton Btn_OgrEkle;
	}
}