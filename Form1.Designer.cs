namespace CokluDilCeviri
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
            this.lblKarsilama = new System.Windows.Forms.Label();
            this.btnDilTR = new System.Windows.Forms.Button();
            this.btnDilEN = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDilDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKarsilama
            // 
            this.lblKarsilama.AutoSize = true;
            this.lblKarsilama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKarsilama.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarsilama.Location = new System.Drawing.Point(50, 26);
            this.lblKarsilama.Name = "lblKarsilama";
            this.lblKarsilama.Size = new System.Drawing.Size(154, 45);
            this.lblKarsilama.TabIndex = 0;
            this.lblKarsilama.Text = "Merhaba";
            // 
            // btnDilTR
            // 
            this.btnDilTR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDilTR.Location = new System.Drawing.Point(21, 212);
            this.btnDilTR.Name = "btnDilTR";
            this.btnDilTR.Size = new System.Drawing.Size(183, 64);
            this.btnDilTR.TabIndex = 1;
            this.btnDilTR.Text = "Türkçe";
            this.btnDilTR.UseVisualStyleBackColor = true;
            this.btnDilTR.Click += new System.EventHandler(this.btnDilTR_Click);
            // 
            // btnDilEN
            // 
            this.btnDilEN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDilEN.Location = new System.Drawing.Point(264, 212);
            this.btnDilEN.Name = "btnDilEN";
            this.btnDilEN.Size = new System.Drawing.Size(183, 64);
            this.btnDilEN.TabIndex = 2;
            this.btnDilEN.Text = "English";
            this.btnDilEN.UseVisualStyleBackColor = true;
            this.btnDilEN.Click += new System.EventHandler(this.btnDilEN_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(39, 112);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(174, 47);
            this.lblKullanici.TabIndex = 3;
            this.lblKullanici.Text = "Kullanıcı Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(233, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 39);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Zehra";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDilDE
            // 
            this.btnDilDE.BackColor = System.Drawing.SystemColors.Control;
            this.btnDilDE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDilDE.Location = new System.Drawing.Point(497, 212);
            this.btnDilDE.Name = "btnDilDE";
            this.btnDilDE.Size = new System.Drawing.Size(183, 64);
            this.btnDilDE.TabIndex = 5;
            this.btnDilDE.Text = "Deutsch";
            this.btnDilDE.UseVisualStyleBackColor = false;
            this.btnDilDE.Click += new System.EventHandler(this.btnDilDE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDilDE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnDilEN);
            this.Controls.Add(this.btnDilTR);
            this.Controls.Add(this.lblKarsilama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKarsilama;
        private System.Windows.Forms.Button btnDilTR;
        private System.Windows.Forms.Button btnDilEN;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDilDE;
    }
}

