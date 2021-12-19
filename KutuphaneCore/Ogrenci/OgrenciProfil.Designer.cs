namespace KutuphaneCore
{
    partial class OgrenciProfil
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.teslimAl = new MetroFramework.Controls.MetroButton();
            this.iadeEt = new MetroFramework.Controls.MetroButton();
            this.GridBulunanKitaplar = new System.Windows.Forms.DataGridView();
            this.data_Ogrenci = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogrBorc = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ogrOkul = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ogrTc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrIsim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBulunanKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ogrenci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 933);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.teslimAl);
            this.panel4.Controls.Add(this.iadeEt);
            this.panel4.Controls.Add(this.GridBulunanKitaplar);
            this.panel4.Controls.Add(this.data_Ogrenci);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1309, 933);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // teslimAl
            // 
            this.teslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teslimAl.Highlight = true;
            this.teslimAl.Location = new System.Drawing.Point(1074, 610);
            this.teslimAl.Name = "teslimAl";
            this.teslimAl.Size = new System.Drawing.Size(115, 37);
            this.teslimAl.Style = MetroFramework.MetroColorStyle.Blue;
            this.teslimAl.StyleManager = null;
            this.teslimAl.TabIndex = 21;
            this.teslimAl.Text = "Teslim Al";
            this.teslimAl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.teslimAl.Click += new System.EventHandler(this.teslimAl_Click);
            // 
            // iadeEt
            // 
            this.iadeEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iadeEt.Highlight = true;
            this.iadeEt.Location = new System.Drawing.Point(1074, 290);
            this.iadeEt.Name = "iadeEt";
            this.iadeEt.Size = new System.Drawing.Size(115, 37);
            this.iadeEt.Style = MetroFramework.MetroColorStyle.Blue;
            this.iadeEt.StyleManager = null;
            this.iadeEt.TabIndex = 20;
            this.iadeEt.Text = "İade Et";
            this.iadeEt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.iadeEt.Click += new System.EventHandler(this.iadeEt_Click);
            // 
            // GridBulunanKitaplar
            // 
            this.GridBulunanKitaplar.AllowUserToResizeColumns = false;
            this.GridBulunanKitaplar.AllowUserToResizeRows = false;
            this.GridBulunanKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridBulunanKitaplar.ColumnHeadersHeight = 30;
            this.GridBulunanKitaplar.Location = new System.Drawing.Point(261, 342);
            this.GridBulunanKitaplar.MultiSelect = false;
            this.GridBulunanKitaplar.Name = "GridBulunanKitaplar";
            this.GridBulunanKitaplar.RowHeadersVisible = false;
            this.GridBulunanKitaplar.RowTemplate.Height = 30;
            this.GridBulunanKitaplar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBulunanKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBulunanKitaplar.Size = new System.Drawing.Size(928, 262);
            this.GridBulunanKitaplar.TabIndex = 19;
            // 
            // data_Ogrenci
            // 
            this.data_Ogrenci.AllowUserToResizeColumns = false;
            this.data_Ogrenci.AllowUserToResizeRows = false;
            this.data_Ogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Ogrenci.ColumnHeadersHeight = 30;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Ogrenci.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_Ogrenci.Location = new System.Drawing.Point(261, 22);
            this.data_Ogrenci.MultiSelect = false;
            this.data_Ogrenci.Name = "data_Ogrenci";
            this.data_Ogrenci.RowHeadersVisible = false;
            this.data_Ogrenci.RowTemplate.Height = 50;
            this.data_Ogrenci.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Ogrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Ogrenci.Size = new System.Drawing.Size(928, 262);
            this.data_Ogrenci.TabIndex = 18;
            this.data_Ogrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Ogrenci_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ogrBorc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ogrOkul);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ogrTc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ogrIsim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // ogrBorc
            // 
            this.ogrBorc.AutoSize = true;
            this.ogrBorc.Location = new System.Drawing.Point(79, 242);
            this.ogrBorc.Name = "ogrBorc";
            this.ogrBorc.Size = new System.Drawing.Size(44, 15);
            this.ogrBorc.TabIndex = 1;
            this.ogrBorc.Text = "label11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(52, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Toplam Borç";
            // 
            // ogrOkul
            // 
            this.ogrOkul.AutoSize = true;
            this.ogrOkul.Location = new System.Drawing.Point(79, 188);
            this.ogrOkul.Name = "ogrOkul";
            this.ogrOkul.Size = new System.Drawing.Size(44, 15);
            this.ogrOkul.TabIndex = 1;
            this.ogrOkul.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(77, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Okul";
            // 
            // ogrTc
            // 
            this.ogrTc.AutoSize = true;
            this.ogrTc.Location = new System.Drawing.Point(79, 128);
            this.ogrTc.Name = "ogrTc";
            this.ogrTc.Size = new System.Drawing.Size(44, 15);
            this.ogrTc.TabIndex = 1;
            this.ogrTc.Text = "label11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğrenci TC";
            // 
            // ogrIsim
            // 
            this.ogrIsim.AutoSize = true;
            this.ogrIsim.Location = new System.Drawing.Point(79, 75);
            this.ogrIsim.Name = "ogrIsim";
            this.ogrIsim.Size = new System.Drawing.Size(44, 15);
            this.ogrIsim.TabIndex = 1;
            this.ogrIsim.Text = "label11";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(54, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "İsim Soyisim";
            // 
            // OgrenciProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 933);
            this.Controls.Add(this.panel2);
            this.Name = "OgrenciProfil";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.OgrenciProfil_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBulunanKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ogrenci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ogrBorc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ogrOkul;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ogrTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ogrIsim;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView data_Ogrenci;
        public System.Windows.Forms.DataGridView GridBulunanKitaplar;
        private MetroFramework.Controls.MetroButton teslimAl;
        private MetroFramework.Controls.MetroButton iadeEt;
    }
}