
namespace Ders_Calısma_Programı
{
    partial class DersPrgrmFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DersPrgrmFrm));
            this.DersCalısmaProgramı = new System.Windows.Forms.Label();
            this.ElktrkBtn = new System.Windows.Forms.Button();
            this.ElktrkGrpBox = new System.Windows.Forms.GroupBox();
            this.BlgsyrGrpBox = new System.Windows.Forms.GroupBox();
            this.BlgsyrBtn = new System.Windows.Forms.Button();
            this.InstGrpBox = new System.Windows.Forms.GroupBox();
            this.InstBtn = new System.Windows.Forms.Button();
            this.MknGrpBox = new System.Windows.Forms.GroupBox();
            this.MknBtn = new System.Windows.Forms.Button();
            this.PtrlGrpBox = new System.Windows.Forms.GroupBox();
            this.PtrlBtn = new System.Windows.Forms.Button();
            this.BymdklGrpBox = new System.Windows.Forms.GroupBox();
            this.BymdklBtn = new System.Windows.Forms.Button();
            this.ElktrkGrpBox.SuspendLayout();
            this.BlgsyrGrpBox.SuspendLayout();
            this.InstGrpBox.SuspendLayout();
            this.MknGrpBox.SuspendLayout();
            this.PtrlGrpBox.SuspendLayout();
            this.BymdklGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DersCalısmaProgramı
            // 
            this.DersCalısmaProgramı.BackColor = System.Drawing.Color.Transparent;
            this.DersCalısmaProgramı.Font = new System.Drawing.Font("MV Boli", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DersCalısmaProgramı.Location = new System.Drawing.Point(214, 9);
            this.DersCalısmaProgramı.Name = "DersCalısmaProgramı";
            this.DersCalısmaProgramı.Size = new System.Drawing.Size(634, 75);
            this.DersCalısmaProgramı.TabIndex = 1;
            this.DersCalısmaProgramı.Text = "Ders Çalısma Programı";
            // 
            // ElktrkBtn
            // 
            this.ElktrkBtn.BackColor = System.Drawing.Color.Transparent;
            this.ElktrkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ElktrkBtn.Location = new System.Drawing.Point(85, 138);
            this.ElktrkBtn.Name = "ElktrkBtn";
            this.ElktrkBtn.Size = new System.Drawing.Size(116, 36);
            this.ElktrkBtn.TabIndex = 2;
            this.ElktrkBtn.Text = "Program";
            this.ElktrkBtn.UseVisualStyleBackColor = false;
            this.ElktrkBtn.Click += new System.EventHandler(this.ElktrkBtn_Click);
            // 
            // ElktrkGrpBox
            // 
            this.ElktrkGrpBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ElktrkGrpBox.BackgroundImage")));
            this.ElktrkGrpBox.Controls.Add(this.ElktrkBtn);
            this.ElktrkGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ElktrkGrpBox.Location = new System.Drawing.Point(12, 105);
            this.ElktrkGrpBox.Name = "ElktrkGrpBox";
            this.ElktrkGrpBox.Size = new System.Drawing.Size(309, 180);
            this.ElktrkGrpBox.TabIndex = 3;
            this.ElktrkGrpBox.TabStop = false;
            this.ElktrkGrpBox.Text = "Elektrik Elektronik Mühendisliği";
            // 
            // BlgsyrGrpBox
            // 
            this.BlgsyrGrpBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlgsyrGrpBox.BackgroundImage")));
            this.BlgsyrGrpBox.Controls.Add(this.BlgsyrBtn);
            this.BlgsyrGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BlgsyrGrpBox.ForeColor = System.Drawing.Color.White;
            this.BlgsyrGrpBox.Location = new System.Drawing.Point(338, 105);
            this.BlgsyrGrpBox.Name = "BlgsyrGrpBox";
            this.BlgsyrGrpBox.Size = new System.Drawing.Size(309, 180);
            this.BlgsyrGrpBox.TabIndex = 4;
            this.BlgsyrGrpBox.TabStop = false;
            this.BlgsyrGrpBox.Text = "Bilgisayar Mühendisliği";
            // 
            // BlgsyrBtn
            // 
            this.BlgsyrBtn.BackColor = System.Drawing.Color.Transparent;
            this.BlgsyrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BlgsyrBtn.ForeColor = System.Drawing.Color.Black;
            this.BlgsyrBtn.Location = new System.Drawing.Point(87, 138);
            this.BlgsyrBtn.Name = "BlgsyrBtn";
            this.BlgsyrBtn.Size = new System.Drawing.Size(116, 36);
            this.BlgsyrBtn.TabIndex = 2;
            this.BlgsyrBtn.Text = "Program";
            this.BlgsyrBtn.UseVisualStyleBackColor = false;
            this.BlgsyrBtn.Click += new System.EventHandler(this.BlgsyrBtn_Click);
            // 
            // InstGrpBox
            // 
            this.InstGrpBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InstGrpBox.BackgroundImage")));
            this.InstGrpBox.Controls.Add(this.InstBtn);
            this.InstGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InstGrpBox.Location = new System.Drawing.Point(666, 105);
            this.InstGrpBox.Name = "InstGrpBox";
            this.InstGrpBox.Size = new System.Drawing.Size(309, 180);
            this.InstGrpBox.TabIndex = 5;
            this.InstGrpBox.TabStop = false;
            this.InstGrpBox.Text = "İnşaat Mühendisliği";
            // 
            // InstBtn
            // 
            this.InstBtn.BackColor = System.Drawing.Color.Transparent;
            this.InstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InstBtn.ForeColor = System.Drawing.Color.Black;
            this.InstBtn.Location = new System.Drawing.Point(93, 138);
            this.InstBtn.Name = "InstBtn";
            this.InstBtn.Size = new System.Drawing.Size(116, 36);
            this.InstBtn.TabIndex = 2;
            this.InstBtn.Text = "Program";
            this.InstBtn.UseVisualStyleBackColor = false;
            // 
            // MknGrpBox
            // 
            this.MknGrpBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MknGrpBox.BackgroundImage")));
            this.MknGrpBox.Controls.Add(this.MknBtn);
            this.MknGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MknGrpBox.Location = new System.Drawing.Point(12, 303);
            this.MknGrpBox.Name = "MknGrpBox";
            this.MknGrpBox.Size = new System.Drawing.Size(309, 180);
            this.MknGrpBox.TabIndex = 5;
            this.MknGrpBox.TabStop = false;
            this.MknGrpBox.Text = "Makine Mühendisliği";
            // 
            // MknBtn
            // 
            this.MknBtn.BackColor = System.Drawing.Color.Transparent;
            this.MknBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MknBtn.ForeColor = System.Drawing.Color.Black;
            this.MknBtn.Location = new System.Drawing.Point(85, 138);
            this.MknBtn.Name = "MknBtn";
            this.MknBtn.Size = new System.Drawing.Size(116, 36);
            this.MknBtn.TabIndex = 2;
            this.MknBtn.Text = "Program";
            this.MknBtn.UseVisualStyleBackColor = false;
            // 
            // PtrlGrpBox
            // 
            this.PtrlGrpBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PtrlGrpBox.BackgroundImage")));
            this.PtrlGrpBox.Controls.Add(this.PtrlBtn);
            this.PtrlGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PtrlGrpBox.Location = new System.Drawing.Point(338, 303);
            this.PtrlGrpBox.Name = "PtrlGrpBox";
            this.PtrlGrpBox.Size = new System.Drawing.Size(309, 180);
            this.PtrlGrpBox.TabIndex = 5;
            this.PtrlGrpBox.TabStop = false;
            this.PtrlGrpBox.Text = "Petrol ve Doğalgaz Mühendisliği";
            // 
            // PtrlBtn
            // 
            this.PtrlBtn.BackColor = System.Drawing.Color.Transparent;
            this.PtrlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PtrlBtn.ForeColor = System.Drawing.Color.Black;
            this.PtrlBtn.Location = new System.Drawing.Point(87, 138);
            this.PtrlBtn.Name = "PtrlBtn";
            this.PtrlBtn.Size = new System.Drawing.Size(116, 36);
            this.PtrlBtn.TabIndex = 2;
            this.PtrlBtn.Text = "Program";
            this.PtrlBtn.UseVisualStyleBackColor = false;
            // 
            // BymdklGrpBox
            // 
            this.BymdklGrpBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BymdklGrpBox.BackgroundImage")));
            this.BymdklGrpBox.Controls.Add(this.BymdklBtn);
            this.BymdklGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BymdklGrpBox.ForeColor = System.Drawing.Color.White;
            this.BymdklGrpBox.Location = new System.Drawing.Point(666, 303);
            this.BymdklGrpBox.Name = "BymdklGrpBox";
            this.BymdklGrpBox.Size = new System.Drawing.Size(309, 180);
            this.BymdklGrpBox.TabIndex = 5;
            this.BymdklGrpBox.TabStop = false;
            this.BymdklGrpBox.Text = "Biyomedikal Mühendisliği";
            // 
            // BymdklBtn
            // 
            this.BymdklBtn.BackColor = System.Drawing.Color.Transparent;
            this.BymdklBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BymdklBtn.ForeColor = System.Drawing.Color.Black;
            this.BymdklBtn.Location = new System.Drawing.Point(93, 138);
            this.BymdklBtn.Name = "BymdklBtn";
            this.BymdklBtn.Size = new System.Drawing.Size(116, 36);
            this.BymdklBtn.TabIndex = 2;
            this.BymdklBtn.Text = "Program";
            this.BymdklBtn.UseVisualStyleBackColor = false;
            // 
            // DersPrgrmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1015, 508);
            this.Controls.Add(this.BymdklGrpBox);
            this.Controls.Add(this.PtrlGrpBox);
            this.Controls.Add(this.MknGrpBox);
            this.Controls.Add(this.InstGrpBox);
            this.Controls.Add(this.BlgsyrGrpBox);
            this.Controls.Add(this.ElktrkGrpBox);
            this.Controls.Add(this.DersCalısmaProgramı);
            this.Name = "DersPrgrmFrm";
            this.Text = "Ders Çalışma Programı";
            this.ElktrkGrpBox.ResumeLayout(false);
            this.BlgsyrGrpBox.ResumeLayout(false);
            this.InstGrpBox.ResumeLayout(false);
            this.MknGrpBox.ResumeLayout(false);
            this.PtrlGrpBox.ResumeLayout(false);
            this.BymdklGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DersCalısmaProgramı;
        private System.Windows.Forms.Button ElktrkBtn;
        private System.Windows.Forms.GroupBox ElktrkGrpBox;
        private System.Windows.Forms.GroupBox BlgsyrGrpBox;
        private System.Windows.Forms.Button BlgsyrBtn;
        private System.Windows.Forms.GroupBox InstGrpBox;
        private System.Windows.Forms.Button InstBtn;
        private System.Windows.Forms.GroupBox MknGrpBox;
        private System.Windows.Forms.Button MknBtn;
        private System.Windows.Forms.GroupBox PtrlGrpBox;
        private System.Windows.Forms.Button PtrlBtn;
        private System.Windows.Forms.GroupBox BymdklGrpBox;
        private System.Windows.Forms.Button BymdklBtn;
    }
}

