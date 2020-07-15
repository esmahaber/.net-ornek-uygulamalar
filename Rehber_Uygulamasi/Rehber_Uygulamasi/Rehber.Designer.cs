namespace Rehber_Uygulamasi
{
    partial class Rehber
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
            this.Kişiler = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonKisiEkle = new System.Windows.Forms.Button();
            this.Kişiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kişiler
            // 
            this.Kişiler.BackColor = System.Drawing.SystemColors.Control;
            this.Kişiler.Controls.Add(this.dataGridView1);
            this.Kişiler.Location = new System.Drawing.Point(15, 15);
            this.Kişiler.Name = "Kişiler";
            this.Kişiler.Size = new System.Drawing.Size(579, 321);
            this.Kişiler.TabIndex = 0;
            this.Kişiler.TabStop = false;
            this.Kişiler.Text = "Kişilerim";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 299);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuncelle.Location = new System.Drawing.Point(600, 34);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(72, 27);
            this.buttonGuncelle.TabIndex = 1;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSil.Location = new System.Drawing.Point(600, 69);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(72, 27);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            // 
            // buttonKisiEkle
            // 
            this.buttonKisiEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKisiEkle.Location = new System.Drawing.Point(600, 153);
            this.buttonKisiEkle.Name = "buttonKisiEkle";
            this.buttonKisiEkle.Size = new System.Drawing.Size(72, 27);
            this.buttonKisiEkle.TabIndex = 3;
            this.buttonKisiEkle.Text = "KİŞİ EKLE";
            this.buttonKisiEkle.UseVisualStyleBackColor = false;
            this.buttonKisiEkle.Click += new System.EventHandler(this.buttonKisiEkle_Click);
            // 
            // Rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonKisiEkle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.Kişiler);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Rehber";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.Rehber_Load);
            this.Kişiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Kişiler;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKisiEkle;
    }
}