
namespace AtYarısı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAt = new System.Windows.Forms.PictureBox();
            this.pictureBoxKedi = new System.Windows.Forms.PictureBox();
            this.pictureBoxKopek = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBitis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTekrarla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTahminKedi = new System.Windows.Forms.Button();
            this.buttonTahminAt = new System.Windows.Forms.Button();
            this.buttonTahminKöpek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKopek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAt
            // 
            this.pictureBoxAt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAt.Image")));
            this.pictureBoxAt.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxAt.Name = "pictureBoxAt";
            this.pictureBoxAt.Size = new System.Drawing.Size(113, 68);
            this.pictureBoxAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAt.TabIndex = 0;
            this.pictureBoxAt.TabStop = false;
            // 
            // pictureBoxKedi
            // 
            this.pictureBoxKedi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKedi.Image")));
            this.pictureBoxKedi.Location = new System.Drawing.Point(0, 218);
            this.pictureBoxKedi.Name = "pictureBoxKedi";
            this.pictureBoxKedi.Size = new System.Drawing.Size(113, 68);
            this.pictureBoxKedi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKedi.TabIndex = 1;
            this.pictureBoxKedi.TabStop = false;
            // 
            // pictureBoxKopek
            // 
            this.pictureBoxKopek.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKopek.Image")));
            this.pictureBoxKopek.Location = new System.Drawing.Point(0, 121);
            this.pictureBoxKopek.Name = "pictureBoxKopek";
            this.pictureBoxKopek.Size = new System.Drawing.Size(113, 68);
            this.pictureBoxKopek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKopek.TabIndex = 2;
            this.pictureBoxKopek.TabStop = false;
            this.pictureBoxKopek.Click += new System.EventHandler(this.pictureBoxKopek_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonBasla
            // 
            this.buttonBasla.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(2, 348);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(160, 70);
            this.buttonBasla.TabIndex = 3;
            this.buttonBasla.Text = "BAŞLA";
            this.buttonBasla.UseVisualStyleBackColor = false;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1078, 23);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBitis
            // 
            this.labelBitis.BackColor = System.Drawing.Color.Black;
            this.labelBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBitis.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelBitis.Location = new System.Drawing.Point(1049, -2);
            this.labelBitis.Name = "labelBitis";
            this.labelBitis.Size = new System.Drawing.Size(26, 315);
            this.labelBitis.TabIndex = 4;
            this.labelBitis.Text = "F\r\nI\r\nN\r\nI\r\nS\r\nH";
            this.labelBitis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBitis.Click += new System.EventHandler(this.labelBitis_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(-3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1078, 23);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(-3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1078, 23);
            this.label3.TabIndex = 4;
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(-3, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1078, 23);
            this.label5.TabIndex = 4;
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonTekrarla
            // 
            this.buttonTekrarla.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonTekrarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrarla.Location = new System.Drawing.Point(168, 348);
            this.buttonTekrarla.Name = "buttonTekrarla";
            this.buttonTekrarla.Size = new System.Drawing.Size(160, 70);
            this.buttonTekrarla.TabIndex = 3;
            this.buttonTekrarla.Text = "TEKRARLA";
            this.buttonTekrarla.UseVisualStyleBackColor = false;
            this.buttonTekrarla.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.groupBox1.Controls.Add(this.buttonTahminKedi);
            this.groupBox1.Controls.Add(this.buttonTahminAt);
            this.groupBox1.Controls.Add(this.buttonTahminKöpek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Beige;
            this.groupBox1.Location = new System.Drawing.Point(724, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahmin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonTahminKedi
            // 
            this.buttonTahminKedi.BackColor = System.Drawing.Color.Khaki;
            this.buttonTahminKedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahminKedi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTahminKedi.Location = new System.Drawing.Point(88, 101);
            this.buttonTahminKedi.Name = "buttonTahminKedi";
            this.buttonTahminKedi.Size = new System.Drawing.Size(160, 70);
            this.buttonTahminKedi.TabIndex = 3;
            this.buttonTahminKedi.Text = "KEDİ";
            this.buttonTahminKedi.UseVisualStyleBackColor = false;
            this.buttonTahminKedi.Click += new System.EventHandler(this.buttonTahminKedi_Click);
            // 
            // buttonTahminAt
            // 
            this.buttonTahminAt.BackColor = System.Drawing.Color.Khaki;
            this.buttonTahminAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahminAt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTahminAt.Location = new System.Drawing.Point(6, 25);
            this.buttonTahminAt.Name = "buttonTahminAt";
            this.buttonTahminAt.Size = new System.Drawing.Size(160, 70);
            this.buttonTahminAt.TabIndex = 3;
            this.buttonTahminAt.Text = "AT";
            this.buttonTahminAt.UseVisualStyleBackColor = false;
            this.buttonTahminAt.Click += new System.EventHandler(this.buttonTahminAt_Click);
            // 
            // buttonTahminKöpek
            // 
            this.buttonTahminKöpek.BackColor = System.Drawing.Color.Khaki;
            this.buttonTahminKöpek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahminKöpek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTahminKöpek.Location = new System.Drawing.Point(172, 25);
            this.buttonTahminKöpek.Name = "buttonTahminKöpek";
            this.buttonTahminKöpek.Size = new System.Drawing.Size(160, 70);
            this.buttonTahminKöpek.TabIndex = 3;
            this.buttonTahminKöpek.Text = "KÖPEK";
            this.buttonTahminKöpek.UseVisualStyleBackColor = false;
            this.buttonTahminKöpek.Click += new System.EventHandler(this.buttonTahminKöpek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1074, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelBitis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTekrarla);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.pictureBoxKopek);
            this.Controls.Add(this.pictureBoxKedi);
            this.Controls.Add(this.pictureBoxAt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Animal Run";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKopek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAt;
        private System.Windows.Forms.PictureBox pictureBoxKedi;
        private System.Windows.Forms.PictureBox pictureBoxKopek;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTekrarla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTahminKedi;
        private System.Windows.Forms.Button buttonTahminKöpek;
        private System.Windows.Forms.Button buttonTahminAt;
    }
}

