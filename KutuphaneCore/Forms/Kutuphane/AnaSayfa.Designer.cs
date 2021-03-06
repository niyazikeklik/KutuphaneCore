namespace KutuphaneCore
{
    partial class AnaSayfa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.öğrenciİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kitapİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yapımcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemlerToolStripMenuItem,
            this.kitapİşlemlerToolStripMenuItem,
            this.grafikToolStripMenuItem,
            this.yapımcıBilgileriToolStripMenuItem,
            this.githubToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 32);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1337, 32);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// öğrenciİşlemlerToolStripMenuItem
			// 
			this.öğrenciİşlemlerToolStripMenuItem.Image = global::View.Properties.Resources.ogrenciUser;
			this.öğrenciİşlemlerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.öğrenciİşlemlerToolStripMenuItem.Name = "öğrenciİşlemlerToolStripMenuItem";
			this.öğrenciİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
			this.öğrenciİşlemlerToolStripMenuItem.Text = "Öğrenci";
			this.öğrenciİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.ÖğrenciİşlemlerToolStripMenuItem_Click);
			// 
			// kitapİşlemlerToolStripMenuItem
			// 
			this.kitapİşlemlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapİşlemlerToolStripMenuItem.Image")));
			this.kitapİşlemlerToolStripMenuItem.Name = "kitapİşlemlerToolStripMenuItem";
			this.kitapİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
			this.kitapİşlemlerToolStripMenuItem.Text = "Kitap";
			this.kitapİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.KitapİşlemlerToolStripMenuItem_Click);
			// 
			// grafikToolStripMenuItem
			// 
			this.grafikToolStripMenuItem.Image = global::View.Properties.Resources.grafik;
			this.grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
			this.grafikToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
			this.grafikToolStripMenuItem.Text = "Grafik";
			this.grafikToolStripMenuItem.Click += new System.EventHandler(this.GrafikToolStripMenuItem_Click);
			// 
			// yapımcıBilgileriToolStripMenuItem
			// 
			this.yapımcıBilgileriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapımcıBilgileriToolStripMenuItem.Image")));
			this.yapımcıBilgileriToolStripMenuItem.Name = "yapımcıBilgileriToolStripMenuItem";
			this.yapımcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
			this.yapımcıBilgileriToolStripMenuItem.Text = "Yapımcı Bilgileri";
			this.yapımcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.YapımcıBilgileriToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1337, 447);
			this.panel1.TabIndex = 1;
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Image = global::View.Properties.Resources.github;
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
			this.githubToolStripMenuItem.Text = "Github";
			this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
			// 
			// AnaSayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1337, 479);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AnaSayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kütüphanee Anasayfa";
			this.Load += new System.EventHandler(this.KutuphaneIslemForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem yapımcıBilgileriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
	}
}