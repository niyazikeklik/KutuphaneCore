﻿namespace View.Ogrenci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OgrGit = new System.Windows.Forms.Button();
            this.OgrSil = new System.Windows.Forms.Button();
            this.OgrGuncelle = new System.Windows.Forms.Button();
            this.OgrEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 361);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OgrGit);
            this.panel1.Controls.Add(this.OgrSil);
            this.panel1.Controls.Add(this.OgrGuncelle);
            this.panel1.Controls.Add(this.OgrEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 70);
            this.panel1.TabIndex = 4;
            // 
            // OgrGit
            // 
            this.OgrGit.Location = new System.Drawing.Point(437, 12);
            this.OgrGit.Name = "OgrGit";
            this.OgrGit.Size = new System.Drawing.Size(93, 39);
            this.OgrGit.TabIndex = 0;
            this.OgrGit.Text = "Öğrenciye Git";
            this.OgrGit.UseVisualStyleBackColor = true;
            this.OgrGit.Click += new System.EventHandler(this.OgrGit_Click);
            // 
            // OgrSil
            // 
            this.OgrSil.Location = new System.Drawing.Point(338, 12);
            this.OgrSil.Name = "OgrSil";
            this.OgrSil.Size = new System.Drawing.Size(93, 39);
            this.OgrSil.TabIndex = 0;
            this.OgrSil.Text = "Öğrenci Sil";
            this.OgrSil.UseVisualStyleBackColor = true;
            this.OgrSil.Click += new System.EventHandler(this.OgrSil_Click);
            // 
            // OgrGuncelle
            // 
            this.OgrGuncelle.Location = new System.Drawing.Point(239, 12);
            this.OgrGuncelle.Name = "OgrGuncelle";
            this.OgrGuncelle.Size = new System.Drawing.Size(93, 39);
            this.OgrGuncelle.TabIndex = 0;
            this.OgrGuncelle.Text = "Öğrenciyi Güncelle";
            this.OgrGuncelle.UseVisualStyleBackColor = true;
            this.OgrGuncelle.Click += new System.EventHandler(this.OgrGuncelle_Click);
            // 
            // OgrEkle
            // 
            this.OgrEkle.Location = new System.Drawing.Point(140, 12);
            this.OgrEkle.Name = "OgrEkle";
            this.OgrEkle.Size = new System.Drawing.Size(93, 39);
            this.OgrEkle.TabIndex = 0;
            this.OgrEkle.Text = "Yeni\r\nÖğrenci Ekle";
            this.OgrEkle.UseVisualStyleBackColor = true;
            this.OgrEkle.Click += new System.EventHandler(this.OgrEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenciler";
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "OgrenciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OgrGit;
        private System.Windows.Forms.Button OgrSil;
        private System.Windows.Forms.Button OgrGuncelle;
        private System.Windows.Forms.Button OgrEkle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}