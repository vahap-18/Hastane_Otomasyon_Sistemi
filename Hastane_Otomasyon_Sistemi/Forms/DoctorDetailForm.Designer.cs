namespace Hastane_Otomasyon_Sistemi.Forms
{
    partial class DoctorDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetailForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBoxHastaDetail = new System.Windows.Forms.GroupBox();
            this.btnEditProfil = new System.Windows.Forms.Button();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPersonalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSickSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSickName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSickPersonelNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richComplaint = new System.Windows.Forms.RichTextBox();
            this.btnAnnoucement = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxHastaDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(474, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 732);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(742, 703);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBoxHastaDetail
            // 
            this.groupBoxHastaDetail.BackColor = System.Drawing.Color.White;
            this.groupBoxHastaDetail.Controls.Add(this.btnEditProfil);
            this.groupBoxHastaDetail.Controls.Add(this.tbGender);
            this.groupBoxHastaDetail.Controls.Add(this.label6);
            this.groupBoxHastaDetail.Controls.Add(this.tbPhone);
            this.groupBoxHastaDetail.Controls.Add(this.label5);
            this.groupBoxHastaDetail.Controls.Add(this.tbSurname);
            this.groupBoxHastaDetail.Controls.Add(this.label3);
            this.groupBoxHastaDetail.Controls.Add(this.tbName);
            this.groupBoxHastaDetail.Controls.Add(this.label2);
            this.groupBoxHastaDetail.Controls.Add(this.tbPersonalNumber);
            this.groupBoxHastaDetail.Controls.Add(this.label1);
            this.groupBoxHastaDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxHastaDetail.Location = new System.Drawing.Point(13, 28);
            this.groupBoxHastaDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxHastaDetail.Name = "groupBoxHastaDetail";
            this.groupBoxHastaDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxHastaDetail.Size = new System.Drawing.Size(445, 387);
            this.groupBoxHastaDetail.TabIndex = 21;
            this.groupBoxHastaDetail.TabStop = false;
            this.groupBoxHastaDetail.Text = "Doktor Bilgileri";
            // 
            // btnEditProfil
            // 
            this.btnEditProfil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProfil.Location = new System.Drawing.Point(123, 315);
            this.btnEditProfil.Name = "btnEditProfil";
            this.btnEditProfil.Size = new System.Drawing.Size(283, 50);
            this.btnEditProfil.TabIndex = 2;
            this.btnEditProfil.Text = "Bilgilerimi Güncelle";
            this.btnEditProfil.UseVisualStyleBackColor = false;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(123, 266);
            this.tbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(283, 30);
            this.tbGender.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cinsiyet :";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(123, 212);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(283, 30);
            this.tbPhone.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon :";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(123, 158);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(283, 30);
            this.tbSurname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(123, 104);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(283, 30);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad :";
            // 
            // tbPersonalNumber
            // 
            this.tbPersonalNumber.Location = new System.Drawing.Point(122, 50);
            this.tbPersonalNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPersonalNumber.Name = "tbPersonalNumber";
            this.tbPersonalNumber.ReadOnly = true;
            this.tbPersonalNumber.Size = new System.Drawing.Size(283, 30);
            this.tbPersonalNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.richComplaint);
            this.groupBox1.Controls.Add(this.tbSickSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbSickName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbSickPersonelNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 436);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(445, 374);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Detay";
            // 
            // tbSickSurname
            // 
            this.tbSickSurname.Location = new System.Drawing.Point(123, 158);
            this.tbSickSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSickSurname.Name = "tbSickSurname";
            this.tbSickSurname.ReadOnly = true;
            this.tbSickSurname.Size = new System.Drawing.Size(283, 30);
            this.tbSickSurname.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Soyad :";
            // 
            // tbSickName
            // 
            this.tbSickName.Location = new System.Drawing.Point(123, 104);
            this.tbSickName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSickName.Name = "tbSickName";
            this.tbSickName.ReadOnly = true;
            this.tbSickName.Size = new System.Drawing.Size(283, 30);
            this.tbSickName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ad :";
            // 
            // tbSickPersonelNumber
            // 
            this.tbSickPersonelNumber.Location = new System.Drawing.Point(123, 50);
            this.tbSickPersonelNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSickPersonelNumber.Name = "tbSickPersonelNumber";
            this.tbSickPersonelNumber.ReadOnly = true;
            this.tbSickPersonelNumber.Size = new System.Drawing.Size(283, 30);
            this.tbSickPersonelNumber.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "T.C. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şikayet :";
            // 
            // richComplaint
            // 
            this.richComplaint.Location = new System.Drawing.Point(123, 221);
            this.richComplaint.Name = "richComplaint";
            this.richComplaint.ReadOnly = true;
            this.richComplaint.Size = new System.Drawing.Size(282, 125);
            this.richComplaint.TabIndex = 2;
            this.richComplaint.Text = "";
            // 
            // btnAnnoucement
            // 
            this.btnAnnoucement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnnoucement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnnoucement.Location = new System.Drawing.Point(474, 28);
            this.btnAnnoucement.Name = "btnAnnoucement";
            this.btnAnnoucement.Size = new System.Drawing.Size(745, 36);
            this.btnAnnoucement.TabIndex = 22;
            this.btnAnnoucement.Text = "Duyurular";
            this.btnAnnoucement.UseVisualStyleBackColor = false;
            // 
            // DoctorDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 824);
            this.Controls.Add(this.btnAnnoucement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHastaDetail);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DoctorDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doktor Bilgi Ekranı";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxHastaDetail.ResumeLayout(false);
            this.groupBoxHastaDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxHastaDetail;
        private System.Windows.Forms.Button btnEditProfil;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPersonalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richComplaint;
        private System.Windows.Forms.TextBox tbSickSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSickName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSickPersonelNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAnnoucement;
    }
}