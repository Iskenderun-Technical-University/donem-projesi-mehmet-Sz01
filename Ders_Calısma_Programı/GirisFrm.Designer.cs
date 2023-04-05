
namespace Ders_Calısma_Programı
{
    partial class GirisFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFrm));
            this.GirisBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayitBtn = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GirisBtn
            // 
            this.GirisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisBtn.Location = new System.Drawing.Point(352, 288);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(113, 28);
            this.GirisBtn.TabIndex = 11;
            this.GirisBtn.Text = "Giriş Yap";
            this.GirisBtn.UseVisualStyleBackColor = true;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "Üye Giriş Paneli";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // KayitBtn
            // 
            this.KayitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitBtn.Location = new System.Drawing.Point(352, 322);
            this.KayitBtn.Name = "KayitBtn";
            this.KayitBtn.Size = new System.Drawing.Size(113, 28);
            this.KayitBtn.TabIndex = 12;
            this.KayitBtn.Text = "Kayıt Ol";
            this.KayitBtn.UseVisualStyleBackColor = true;
            this.KayitBtn.Click += new System.EventHandler(this.KayitBtn_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(333, 255);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(146, 22);
            this.TxtSifre.TabIndex = 13;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(333, 217);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(146, 22);
            this.TxtAd.TabIndex = 13;
            // 
            // GirisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.KayitBtn);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "GirisFrm";
            this.Text = "GirisFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KayitBtn;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtAd;
    }
}