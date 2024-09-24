namespace Hastane_Otomasyon_Sistemi
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLoginDoctor = new System.Windows.Forms.Button();
            this.btnLoginSick = new System.Windows.Forms.Button();
            this.btnLoginSecretary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLoginDoctor = new System.Windows.Forms.PictureBox();
            this.picLoginSick = new System.Windows.Forms.PictureBox();
            this.picLoginSecretary = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginSick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginSecretary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginDoctor
            // 
            this.btnLoginDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginDoctor.FlatAppearance.BorderSize = 0;
            this.btnLoginDoctor.Location = new System.Drawing.Point(163, 455);
            this.btnLoginDoctor.Name = "btnLoginDoctor";
            this.btnLoginDoctor.Size = new System.Drawing.Size(376, 62);
            this.btnLoginDoctor.TabIndex = 0;
            this.btnLoginDoctor.Text = "Doktor";
            this.btnLoginDoctor.UseVisualStyleBackColor = true;
            this.btnLoginDoctor.Click += new System.EventHandler(this.btnLoginDoctor_Click);
            // 
            // btnLoginSick
            // 
            this.btnLoginSick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginSick.Location = new System.Drawing.Point(163, 525);
            this.btnLoginSick.Name = "btnLoginSick";
            this.btnLoginSick.Size = new System.Drawing.Size(376, 62);
            this.btnLoginSick.TabIndex = 0;
            this.btnLoginSick.Text = "Hasta";
            this.btnLoginSick.UseVisualStyleBackColor = true;
            // 
            // btnLoginSecretary
            // 
            this.btnLoginSecretary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginSecretary.Location = new System.Drawing.Point(163, 595);
            this.btnLoginSecretary.Name = "btnLoginSecretary";
            this.btnLoginSecretary.Size = new System.Drawing.Size(376, 62);
            this.btnLoginSecretary.TabIndex = 0;
            this.btnLoginSecretary.Text = "Sekreter";
            this.btnLoginSecretary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğan Hospital Giriş Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Aşağıdan giriş yetkisi seçiniz.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picLoginDoctor
            // 
            this.picLoginDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoginDoctor.Image = ((System.Drawing.Image)(resources.GetObject("picLoginDoctor.Image")));
            this.picLoginDoctor.Location = new System.Drawing.Point(100, 456);
            this.picLoginDoctor.Name = "picLoginDoctor";
            this.picLoginDoctor.Size = new System.Drawing.Size(57, 61);
            this.picLoginDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginDoctor.TabIndex = 3;
            this.picLoginDoctor.TabStop = false;
            // 
            // picLoginSick
            // 
            this.picLoginSick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoginSick.Image = ((System.Drawing.Image)(resources.GetObject("picLoginSick.Image")));
            this.picLoginSick.Location = new System.Drawing.Point(100, 526);
            this.picLoginSick.Name = "picLoginSick";
            this.picLoginSick.Size = new System.Drawing.Size(57, 61);
            this.picLoginSick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginSick.TabIndex = 3;
            this.picLoginSick.TabStop = false;
            // 
            // picLoginSecretary
            // 
            this.picLoginSecretary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoginSecretary.Image = ((System.Drawing.Image)(resources.GetObject("picLoginSecretary.Image")));
            this.picLoginSecretary.Location = new System.Drawing.Point(100, 596);
            this.picLoginSecretary.Name = "picLoginSecretary";
            this.picLoginSecretary.Size = new System.Drawing.Size(57, 61);
            this.picLoginSecretary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoginSecretary.TabIndex = 3;
            this.picLoginSecretary.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("picClose.InitialImage")));
            this.picClose.Location = new System.Drawing.Point(609, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(29, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 16;
            this.picClose.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(281, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giriş Ekranı";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 750);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picLoginSecretary);
            this.Controls.Add(this.picLoginSick);
            this.Controls.Add(this.picLoginDoctor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginSecretary);
            this.Controls.Add(this.btnLoginSick);
            this.Controls.Add(this.btnLoginDoctor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginSick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginSecretary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginDoctor;
        private System.Windows.Forms.Button btnLoginSick;
        private System.Windows.Forms.Button btnLoginSecretary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picLoginDoctor;
        private System.Windows.Forms.PictureBox picLoginSick;
        private System.Windows.Forms.PictureBox picLoginSecretary;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}

