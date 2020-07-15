namespace NotKayit
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.giris_btn = new System.Windows.Forms.Button();
            this.ogr_no_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası:";
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_btn.ForeColor = System.Drawing.Color.White;
            this.giris_btn.Location = new System.Drawing.Point(298, 89);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(99, 37);
            this.giris_btn.TabIndex = 1;
            this.giris_btn.Text = "Giriş Yap";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // ogr_no_maskedTextBox
            // 
            this.ogr_no_maskedTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ogr_no_maskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ogr_no_maskedTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogr_no_maskedTextBox.Location = new System.Drawing.Point(157, 94);
            this.ogr_no_maskedTextBox.Mask = "0000";
            this.ogr_no_maskedTextBox.Name = "ogr_no_maskedTextBox";
            this.ogr_no_maskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.ogr_no_maskedTextBox.TabIndex = 2;
            this.ogr_no_maskedTextBox.ValidatingType = typeof(int);
            this.ogr_no_maskedTextBox.TextChanged += new System.EventHandler(this.ogr_no_maskedTextBox_TextChanged);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 272);
            this.Controls.Add(this.ogr_no_maskedTextBox);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.MaskedTextBox ogr_no_maskedTextBox;
    }
}

