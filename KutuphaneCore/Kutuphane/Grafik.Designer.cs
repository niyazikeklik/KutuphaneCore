namespace View.Kutuphane
{
    partial class Grafik
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.OgrButton = new MetroFramework.Controls.MetroButton();
            this.TxtTitles = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 43);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(687, 338);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.OgrButton);
            this.panel1.Controls.Add(this.TxtTitles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 43);
            this.panel1.TabIndex = 1;
            // 
            // metroButton2
            // 
            this.metroButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(565, 10);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(110, 27);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "X Eksen Başlık Gir";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(449, 10);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 27);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Y Eksen Başlık Gir";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // OgrButton
            // 
            this.OgrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OgrButton.Highlight = true;
            this.OgrButton.Location = new System.Drawing.Point(333, 10);
            this.OgrButton.Name = "OgrButton";
            this.OgrButton.Size = new System.Drawing.Size(110, 27);
            this.OgrButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OgrButton.StyleManager = null;
            this.OgrButton.TabIndex = 5;
            this.OgrButton.Text = "Başlık Gir";
            this.OgrButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OgrButton.Click += new System.EventHandler(this.OgrButton_Click);
            // 
            // TxtTitles
            // 
            this.TxtTitles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTitles.Location = new System.Drawing.Point(172, 10);
            this.TxtTitles.MaxLength = 11;
            this.TxtTitles.Name = "TxtTitles";
            this.TxtTitles.PlaceholderText = "Başlık Gir";
            this.TxtTitles.Size = new System.Drawing.Size(155, 27);
            this.TxtTitles.TabIndex = 1;
            this.TxtTitles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 381);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafik";
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Grafik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TxtTitles;
        public MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroButton OgrButton;
    }
}