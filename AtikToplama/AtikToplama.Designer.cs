namespace AtikToplama
{
    partial class AtikToplama
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMetal = new System.Windows.Forms.Panel();
            this.btnMetal = new System.Windows.Forms.Button();
            this.lstMetal = new System.Windows.Forms.ListBox();
            this.btnMetalBosalt = new System.Windows.Forms.Button();
            this.progresMetal = new System.Windows.Forms.ProgressBar();
            this.pnlCam = new System.Windows.Forms.Panel();
            this.btnCam = new System.Windows.Forms.Button();
            this.lstCam = new System.Windows.Forms.ListBox();
            this.btnCamBosalt = new System.Windows.Forms.Button();
            this.progresCam = new System.Windows.Forms.ProgressBar();
            this.pnlOrganikAtik = new System.Windows.Forms.Panel();
            this.btnOrganikAtik = new System.Windows.Forms.Button();
            this.lstOrganikAtik = new System.Windows.Forms.ListBox();
            this.btnOrganikAtıkBosalt = new System.Windows.Forms.Button();
            this.progresOrganikAtik = new System.Windows.Forms.ProgressBar();
            this.pnlKagit = new System.Windows.Forms.Panel();
            this.btnKagit = new System.Windows.Forms.Button();
            this.lstKagit = new System.Windows.Forms.ListBox();
            this.btnKagitBosalt = new System.Windows.Forms.Button();
            this.progresKagit = new System.Windows.Forms.ProgressBar();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctrboxResimler = new System.Windows.Forms.PictureBox();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.pnlMetal.SuspendLayout();
            this.pnlCam.SuspendLayout();
            this.pnlOrganikAtik.SuspendLayout();
            this.pnlKagit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrboxResimler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMetal
            // 
            this.pnlMetal.BackColor = System.Drawing.Color.Teal;
            this.pnlMetal.Controls.Add(this.btnMetal);
            this.pnlMetal.Controls.Add(this.lstMetal);
            this.pnlMetal.Controls.Add(this.btnMetalBosalt);
            this.pnlMetal.Controls.Add(this.progresMetal);
            this.pnlMetal.Location = new System.Drawing.Point(362, 305);
            this.pnlMetal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMetal.Name = "pnlMetal";
            this.pnlMetal.Size = new System.Drawing.Size(148, 260);
            this.pnlMetal.TabIndex = 31;
            // 
            // btnMetal
            // 
            this.btnMetal.Location = new System.Drawing.Point(20, 12);
            this.btnMetal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(115, 24);
            this.btnMetal.TabIndex = 19;
            this.btnMetal.Text = "METAL";
            this.btnMetal.UseVisualStyleBackColor = true;
            this.btnMetal.Click += new System.EventHandler(this.btnMetal_Click);
            // 
            // lstMetal
            // 
            this.lstMetal.BackColor = System.Drawing.Color.Linen;
            this.lstMetal.FormattingEnabled = true;
            this.lstMetal.Location = new System.Drawing.Point(20, 41);
            this.lstMetal.Margin = new System.Windows.Forms.Padding(2);
            this.lstMetal.Name = "lstMetal";
            this.lstMetal.Size = new System.Drawing.Size(116, 147);
            this.lstMetal.TabIndex = 15;
            // 
            // btnMetalBosalt
            // 
            this.btnMetalBosalt.ForeColor = System.Drawing.Color.Black;
            this.btnMetalBosalt.Location = new System.Drawing.Point(20, 214);
            this.btnMetalBosalt.Margin = new System.Windows.Forms.Padding(2);
            this.btnMetalBosalt.Name = "btnMetalBosalt";
            this.btnMetalBosalt.Size = new System.Drawing.Size(115, 30);
            this.btnMetalBosalt.TabIndex = 17;
            this.btnMetalBosalt.Text = "BOŞALT";
            this.btnMetalBosalt.UseVisualStyleBackColor = true;
            this.btnMetalBosalt.Click += new System.EventHandler(this.btnMetalBosalt_Click);
            // 
            // progresMetal
            // 
            this.progresMetal.Location = new System.Drawing.Point(20, 190);
            this.progresMetal.Margin = new System.Windows.Forms.Padding(2);
            this.progresMetal.Name = "progresMetal";
            this.progresMetal.Size = new System.Drawing.Size(115, 19);
            this.progresMetal.TabIndex = 16;
            // 
            // pnlCam
            // 
            this.pnlCam.BackColor = System.Drawing.Color.Teal;
            this.pnlCam.Controls.Add(this.btnCam);
            this.pnlCam.Controls.Add(this.lstCam);
            this.pnlCam.Controls.Add(this.btnCamBosalt);
            this.pnlCam.Controls.Add(this.progresCam);
            this.pnlCam.Location = new System.Drawing.Point(208, 305);
            this.pnlCam.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCam.Name = "pnlCam";
            this.pnlCam.Size = new System.Drawing.Size(148, 260);
            this.pnlCam.TabIndex = 33;
            // 
            // btnCam
            // 
            this.btnCam.Location = new System.Drawing.Point(20, 12);
            this.btnCam.Margin = new System.Windows.Forms.Padding(2);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(115, 24);
            this.btnCam.TabIndex = 19;
            this.btnCam.Text = "CAM";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // lstCam
            // 
            this.lstCam.BackColor = System.Drawing.Color.Linen;
            this.lstCam.FormattingEnabled = true;
            this.lstCam.Location = new System.Drawing.Point(20, 41);
            this.lstCam.Margin = new System.Windows.Forms.Padding(2);
            this.lstCam.Name = "lstCam";
            this.lstCam.Size = new System.Drawing.Size(116, 147);
            this.lstCam.TabIndex = 15;
            // 
            // btnCamBosalt
            // 
            this.btnCamBosalt.ForeColor = System.Drawing.Color.Black;
            this.btnCamBosalt.Location = new System.Drawing.Point(20, 214);
            this.btnCamBosalt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCamBosalt.Name = "btnCamBosalt";
            this.btnCamBosalt.Size = new System.Drawing.Size(115, 30);
            this.btnCamBosalt.TabIndex = 17;
            this.btnCamBosalt.Text = "BOŞALT";
            this.btnCamBosalt.UseVisualStyleBackColor = true;
            this.btnCamBosalt.Click += new System.EventHandler(this.btnCamBosalt_Click);
            // 
            // progresCam
            // 
            this.progresCam.Location = new System.Drawing.Point(20, 190);
            this.progresCam.Margin = new System.Windows.Forms.Padding(2);
            this.progresCam.Name = "progresCam";
            this.progresCam.Size = new System.Drawing.Size(115, 19);
            this.progresCam.TabIndex = 16;
            // 
            // pnlOrganikAtik
            // 
            this.pnlOrganikAtik.BackColor = System.Drawing.Color.Teal;
            this.pnlOrganikAtik.Controls.Add(this.btnOrganikAtik);
            this.pnlOrganikAtik.Controls.Add(this.lstOrganikAtik);
            this.pnlOrganikAtik.Controls.Add(this.btnOrganikAtıkBosalt);
            this.pnlOrganikAtik.Controls.Add(this.progresOrganikAtik);
            this.pnlOrganikAtik.Location = new System.Drawing.Point(208, 40);
            this.pnlOrganikAtik.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrganikAtik.Name = "pnlOrganikAtik";
            this.pnlOrganikAtik.Size = new System.Drawing.Size(148, 260);
            this.pnlOrganikAtik.TabIndex = 32;
            // 
            // btnOrganikAtik
            // 
            this.btnOrganikAtik.Location = new System.Drawing.Point(20, 12);
            this.btnOrganikAtik.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrganikAtik.Name = "btnOrganikAtik";
            this.btnOrganikAtik.Size = new System.Drawing.Size(115, 24);
            this.btnOrganikAtik.TabIndex = 18;
            this.btnOrganikAtik.Text = "ORGANİK ATIK";
            this.btnOrganikAtik.UseVisualStyleBackColor = true;
            this.btnOrganikAtik.Click += new System.EventHandler(this.btnOrganikAtik_Click);
            // 
            // lstOrganikAtik
            // 
            this.lstOrganikAtik.BackColor = System.Drawing.Color.Linen;
            this.lstOrganikAtik.FormattingEnabled = true;
            this.lstOrganikAtik.Location = new System.Drawing.Point(20, 41);
            this.lstOrganikAtik.Margin = new System.Windows.Forms.Padding(2);
            this.lstOrganikAtik.Name = "lstOrganikAtik";
            this.lstOrganikAtik.Size = new System.Drawing.Size(116, 147);
            this.lstOrganikAtik.TabIndex = 15;
            // 
            // btnOrganikAtıkBosalt
            // 
            this.btnOrganikAtıkBosalt.ForeColor = System.Drawing.Color.Black;
            this.btnOrganikAtıkBosalt.Location = new System.Drawing.Point(20, 214);
            this.btnOrganikAtıkBosalt.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrganikAtıkBosalt.Name = "btnOrganikAtıkBosalt";
            this.btnOrganikAtıkBosalt.Size = new System.Drawing.Size(115, 30);
            this.btnOrganikAtıkBosalt.TabIndex = 17;
            this.btnOrganikAtıkBosalt.Text = "BOŞALT";
            this.btnOrganikAtıkBosalt.UseMnemonic = false;
            this.btnOrganikAtıkBosalt.UseVisualStyleBackColor = true;
            this.btnOrganikAtıkBosalt.Click += new System.EventHandler(this.btnOrganikAtıkBosalt_Click);
            // 
            // progresOrganikAtik
            // 
            this.progresOrganikAtik.Location = new System.Drawing.Point(20, 190);
            this.progresOrganikAtik.Margin = new System.Windows.Forms.Padding(2);
            this.progresOrganikAtik.Name = "progresOrganikAtik";
            this.progresOrganikAtik.Size = new System.Drawing.Size(115, 19);
            this.progresOrganikAtik.TabIndex = 16;
            // 
            // pnlKagit
            // 
            this.pnlKagit.BackColor = System.Drawing.Color.Teal;
            this.pnlKagit.Controls.Add(this.btnKagit);
            this.pnlKagit.Controls.Add(this.lstKagit);
            this.pnlKagit.Controls.Add(this.btnKagitBosalt);
            this.pnlKagit.Controls.Add(this.progresKagit);
            this.pnlKagit.Location = new System.Drawing.Point(360, 40);
            this.pnlKagit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKagit.Name = "pnlKagit";
            this.pnlKagit.Size = new System.Drawing.Size(148, 260);
            this.pnlKagit.TabIndex = 30;
            // 
            // btnKagit
            // 
            this.btnKagit.Location = new System.Drawing.Point(20, 12);
            this.btnKagit.Margin = new System.Windows.Forms.Padding(2);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(115, 24);
            this.btnKagit.TabIndex = 19;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = true;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // lstKagit
            // 
            this.lstKagit.BackColor = System.Drawing.Color.Linen;
            this.lstKagit.FormattingEnabled = true;
            this.lstKagit.Location = new System.Drawing.Point(20, 41);
            this.lstKagit.Margin = new System.Windows.Forms.Padding(2);
            this.lstKagit.Name = "lstKagit";
            this.lstKagit.Size = new System.Drawing.Size(116, 147);
            this.lstKagit.TabIndex = 15;
            // 
            // btnKagitBosalt
            // 
            this.btnKagitBosalt.ForeColor = System.Drawing.Color.Black;
            this.btnKagitBosalt.Location = new System.Drawing.Point(20, 214);
            this.btnKagitBosalt.Margin = new System.Windows.Forms.Padding(2);
            this.btnKagitBosalt.Name = "btnKagitBosalt";
            this.btnKagitBosalt.Size = new System.Drawing.Size(115, 30);
            this.btnKagitBosalt.TabIndex = 17;
            this.btnKagitBosalt.Text = "BOŞALT";
            this.btnKagitBosalt.UseVisualStyleBackColor = true;
            this.btnKagitBosalt.Click += new System.EventHandler(this.btnKagitBosalt_Click);
            // 
            // progresKagit
            // 
            this.progresKagit.Location = new System.Drawing.Point(20, 190);
            this.progresKagit.Margin = new System.Windows.Forms.Padding(2);
            this.progresKagit.Name = "progresKagit";
            this.progresKagit.Size = new System.Drawing.Size(115, 19);
            this.progresKagit.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Bisque;
            this.textBox11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox11.Location = new System.Drawing.Point(208, 10);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(301, 26);
            this.textBox11.TabIndex = 29;
            this.textBox11.Text = "ATIK KUTULARI";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.txtPuan);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.txtSure);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnCikis);
            this.groupBox2.Controls.Add(this.btnYeniOyun);
            this.groupBox2.Location = new System.Drawing.Point(8, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(182, 355);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // txtPuan
            // 
            this.txtPuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPuan.ForeColor = System.Drawing.Color.Teal;
            this.txtPuan.Location = new System.Drawing.Point(4, 223);
            this.txtPuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuan.Multiline = true;
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(178, 56);
            this.txtPuan.TabIndex = 9;
            this.txtPuan.Text = "0";
            this.txtPuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Teal;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(4, 199);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 41);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "PUAN";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSure
            // 
            this.txtSure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSure.ForeColor = System.Drawing.Color.Teal;
            this.txtSure.Location = new System.Drawing.Point(4, 120);
            this.txtSure.Margin = new System.Windows.Forms.Padding(2);
            this.txtSure.Multiline = true;
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(178, 63);
            this.txtSure.TabIndex = 7;
            this.txtSure.Text = "60";
            this.txtSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(4, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 28);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "SÜRE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(14, 285);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(154, 43);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeniOyun.Location = new System.Drawing.Point(4, 9);
            this.btnYeniOyun.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(177, 74);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.pctrboxResimler);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 191);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // pctrboxResimler
            // 
            this.pctrboxResimler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pctrboxResimler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrboxResimler.Location = new System.Drawing.Point(4, 11);
            this.pctrboxResimler.Margin = new System.Windows.Forms.Padding(2);
            this.pctrboxResimler.Name = "pctrboxResimler";
            this.pctrboxResimler.Size = new System.Drawing.Size(172, 177);
            this.pctrboxResimler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrboxResimler.TabIndex = 0;
            this.pctrboxResimler.TabStop = false;
            // 
            // zaman
            // 
            this.zaman.Interval = 1000;
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // AtikToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(532, 575);
            this.Controls.Add(this.pnlMetal);
            this.Controls.Add(this.pnlCam);
            this.Controls.Add(this.pnlOrganikAtik);
            this.Controls.Add(this.pnlKagit);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AtikToplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.AtikToplama_Load);
            this.pnlMetal.ResumeLayout(false);
            this.pnlCam.ResumeLayout(false);
            this.pnlOrganikAtik.ResumeLayout(false);
            this.pnlKagit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrboxResimler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMetal;
        private System.Windows.Forms.Button btnMetal;
        private System.Windows.Forms.ListBox lstMetal;
        private System.Windows.Forms.Button btnMetalBosalt;
        private System.Windows.Forms.ProgressBar progresMetal;
        private System.Windows.Forms.Panel pnlCam;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.ListBox lstCam;
        private System.Windows.Forms.Button btnCamBosalt;
        private System.Windows.Forms.ProgressBar progresCam;
        private System.Windows.Forms.Panel pnlOrganikAtik;
        private System.Windows.Forms.Button btnOrganikAtik;
        private System.Windows.Forms.ListBox lstOrganikAtik;
        private System.Windows.Forms.Button btnOrganikAtıkBosalt;
        private System.Windows.Forms.ProgressBar progresOrganikAtik;
        private System.Windows.Forms.Panel pnlKagit;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.ListBox lstKagit;
        private System.Windows.Forms.Button btnKagitBosalt;
        private System.Windows.Forms.ProgressBar progresKagit;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctrboxResimler;
        private System.Windows.Forms.Timer zaman;
        
    }
}

