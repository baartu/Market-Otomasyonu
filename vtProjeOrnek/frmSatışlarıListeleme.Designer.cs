namespace vtProjeOrnek
{
    partial class frmSatışlarıListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKasiyerNo = new System.Windows.Forms.TextBox();
            this.btnSatışlarıTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kasiyer No";
            // 
            // txtKasiyerNo
            // 
            this.txtKasiyerNo.Location = new System.Drawing.Point(468, 56);
            this.txtKasiyerNo.Multiline = true;
            this.txtKasiyerNo.Name = "txtKasiyerNo";
            this.txtKasiyerNo.Size = new System.Drawing.Size(153, 22);
            this.txtKasiyerNo.TabIndex = 2;
            this.txtKasiyerNo.TextChanged += new System.EventHandler(this.txtKasiyerNo_TextChanged);
            // 
            // btnSatışlarıTemizle
            // 
            this.btnSatışlarıTemizle.Location = new System.Drawing.Point(897, 532);
            this.btnSatışlarıTemizle.Name = "btnSatışlarıTemizle";
            this.btnSatışlarıTemizle.Size = new System.Drawing.Size(107, 54);
            this.btnSatışlarıTemizle.TabIndex = 3;
            this.btnSatışlarıTemizle.Text = "Satışları Temizle";
            this.btnSatışlarıTemizle.UseVisualStyleBackColor = true;
            this.btnSatışlarıTemizle.Click += new System.EventHandler(this.btnSatışlarıTemizle_Click);
            // 
            // frmSatışlarıListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1032, 614);
            this.Controls.Add(this.btnSatışlarıTemizle);
            this.Controls.Add(this.txtKasiyerNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatışlarıListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışları Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmSatışlarıListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKasiyerNo;
        private System.Windows.Forms.Button btnSatışlarıTemizle;
    }
}