namespace vtProjeOrnek
{
    partial class frmAdminKasiyerGiris
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
            this.btnKasiyerGiris = new System.Windows.Forms.Button();
            this.btnAdminGiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKasiyerGiris
            // 
            this.btnKasiyerGiris.Location = new System.Drawing.Point(51, 104);
            this.btnKasiyerGiris.Name = "btnKasiyerGiris";
            this.btnKasiyerGiris.Size = new System.Drawing.Size(141, 50);
            this.btnKasiyerGiris.TabIndex = 0;
            this.btnKasiyerGiris.Text = "Giriş Yap";
            this.btnKasiyerGiris.UseVisualStyleBackColor = true;
            this.btnKasiyerGiris.Click += new System.EventHandler(this.btnKasiyerGiris_Click);
            // 
            // btnAdminGiriş
            // 
            this.btnAdminGiriş.Location = new System.Drawing.Point(266, 104);
            this.btnAdminGiriş.Name = "btnAdminGiriş";
            this.btnAdminGiriş.Size = new System.Drawing.Size(141, 50);
            this.btnAdminGiriş.TabIndex = 1;
            this.btnAdminGiriş.Text = "Giriş yap";
            this.btnAdminGiriş.UseVisualStyleBackColor = true;
            this.btnAdminGiriş.Click += new System.EventHandler(this.btnAdminGiriş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kasiyer Olarak\r\n Giriş Yap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(275, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin Olarak\r\n Giriş Yap";
            // 
            // frmAdminKasiyerGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 251);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminGiriş);
            this.Controls.Add(this.btnKasiyerGiris);
            this.Name = "frmAdminKasiyerGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKasiyerGiris;
        private System.Windows.Forms.Button btnAdminGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}