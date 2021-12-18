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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OgrSil = new System.Windows.Forms.Button();
            this.OgrGuncelle = new System.Windows.Forms.Button();
            this.OgrEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(924, 584);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 128);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(599, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 128);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OgrSil);
            this.panel3.Controls.Add(this.OgrGuncelle);
            this.panel3.Controls.Add(this.OgrEkle);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(290, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 128);
            this.panel3.TabIndex = 3;
            // 
            // OgrSil
            // 
            this.OgrSil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OgrSil.Location = new System.Drawing.Point(209, 34);
            this.OgrSil.Name = "OgrSil";
            this.OgrSil.Size = new System.Drawing.Size(93, 39);
            this.OgrSil.TabIndex = 10;
            this.OgrSil.Text = "Kitabı Sil";
            this.OgrSil.UseVisualStyleBackColor = true;
            this.OgrSil.Click += new System.EventHandler(this.OgrSil_Click_1);
            // 
            // OgrGuncelle
            // 
            this.OgrGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OgrGuncelle.Location = new System.Drawing.Point(110, 34);
            this.OgrGuncelle.Name = "OgrGuncelle";
            this.OgrGuncelle.Size = new System.Drawing.Size(93, 39);
            this.OgrGuncelle.TabIndex = 11;
            this.OgrGuncelle.Text = "Kitabı Güncelle";
            this.OgrGuncelle.UseVisualStyleBackColor = true;
            this.OgrGuncelle.Click += new System.EventHandler(this.OgrGuncelle_Click_1);
            // 
            // OgrEkle
            // 
            this.OgrEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OgrEkle.Location = new System.Drawing.Point(11, 34);
            this.OgrEkle.Name = "OgrEkle";
            this.OgrEkle.Size = new System.Drawing.Size(93, 39);
            this.OgrEkle.TabIndex = 12;
            this.OgrEkle.Text = "Yeni Kitap Ekle";
            this.OgrEkle.UseVisualStyleBackColor = true;
            this.OgrEkle.Click += new System.EventHandler(this.OgrEkle_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tüm Kitaplar";
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 712);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapProfil";
            this.Load += new System.EventHandler(this.KitapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OgrSil;
        private System.Windows.Forms.Button OgrGuncelle;
        private System.Windows.Forms.Button OgrEkle;
        private System.Windows.Forms.Label label1;
    }
}