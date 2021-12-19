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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemlerToolStripMenuItem,
            this.kitapİşlemlerToolStripMenuItem,
            this.grafikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemlerToolStripMenuItem
            // 
            this.öğrenciİşlemlerToolStripMenuItem.Image = global::View.Properties.Resources._6586125_account_avatar_person_profile_user_icon;
            this.öğrenciİşlemlerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.öğrenciİşlemlerToolStripMenuItem.Name = "öğrenciİşlemlerToolStripMenuItem";
            this.öğrenciİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.öğrenciİşlemlerToolStripMenuItem.Text = "Öğrenci";
            this.öğrenciİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.öğrenciİşlemlerToolStripMenuItem_Click);
            // 
            // kitapİşlemlerToolStripMenuItem
            // 
            this.kitapİşlemlerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapİşlemlerToolStripMenuItem.Image")));
            this.kitapİşlemlerToolStripMenuItem.Name = "kitapİşlemlerToolStripMenuItem";
            this.kitapİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.kitapİşlemlerToolStripMenuItem.Text = "Kitap";
            this.kitapİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemlerToolStripMenuItem_Click);
            // 
            // grafikToolStripMenuItem
            // 
            this.grafikToolStripMenuItem.Image = global::View.Properties.Resources._6586115_bar_chart_diagram_graph_report_icon;
            this.grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
            this.grafikToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
            this.grafikToolStripMenuItem.Text = "Grafik";
            this.grafikToolStripMenuItem.Click += new System.EventHandler(this.grafikToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 447);
            this.panel1.TabIndex = 1;
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
    }
}