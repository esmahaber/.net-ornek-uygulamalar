namespace BankaSimulasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.linkLabelKaydol = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No:";
            // 
            // maskedTextBoxHesapNo
            // 
            this.maskedTextBoxHesapNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBoxHesapNo.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBoxHesapNo.Location = new System.Drawing.Point(119, 108);
            this.maskedTextBoxHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxHesapNo.Mask = "000000";
            this.maskedTextBoxHesapNo.Name = "maskedTextBoxHesapNo";
            this.maskedTextBoxHesapNo.Size = new System.Drawing.Size(132, 25);
            this.maskedTextBoxHesapNo.TabIndex = 1;
            this.maskedTextBoxHesapNo.ValidatingType = typeof(int);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSifre.ForeColor = System.Drawing.Color.Black;
            this.textBoxSifre.Location = new System.Drawing.Point(119, 162);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(132, 25);
            this.textBoxSifre.TabIndex = 2;
            // 
            // linkLabelKaydol
            // 
            this.linkLabelKaydol.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelKaydol.AutoSize = true;
            this.linkLabelKaydol.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabelKaydol.Location = new System.Drawing.Point(158, 258);
            this.linkLabelKaydol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelKaydol.Name = "linkLabelKaydol";
            this.linkLabelKaydol.Size = new System.Drawing.Size(59, 17);
            this.linkLabelKaydol.TabIndex = 3;
            this.linkLabelKaydol.TabStop = true;
            this.linkLabelKaydol.Text = "Kayıt Ol";
            this.linkLabelKaydol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKaydol_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(141, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(333, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelKaydol);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.maskedTextBoxHesapNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHesapNo;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.LinkLabel linkLabelKaydol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

