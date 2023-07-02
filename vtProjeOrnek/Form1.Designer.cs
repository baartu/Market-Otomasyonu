namespace vtProjeOrnek
{
    partial class formSatis
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
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnSatışlarıListeleme = new System.Windows.Forms.Button();
            this.btnÜrünListeleme = new System.Windows.Forms.Button();
            this.btnÜrünEkleme = new System.Windows.Forms.Button();
            this.btnMüşteriListeleme = new System.Windows.Forms.Button();
            this.btnKasiyerEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSatisSayfası = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(142, 34);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(112, 51);
            this.btnMarka.TabIndex = 7;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(14, 34);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(110, 51);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnSatışlarıListeleme
            // 
            this.btnSatışlarıListeleme.Location = new System.Drawing.Point(14, 33);
            this.btnSatışlarıListeleme.Name = "btnSatışlarıListeleme";
            this.btnSatışlarıListeleme.Size = new System.Drawing.Size(110, 51);
            this.btnSatışlarıListeleme.TabIndex = 4;
            this.btnSatışlarıListeleme.Text = "Satışları Listeleme";
            this.btnSatışlarıListeleme.UseVisualStyleBackColor = true;
            this.btnSatışlarıListeleme.Click += new System.EventHandler(this.btnSatışlarıListeleme_Click);
            // 
            // btnÜrünListeleme
            // 
            this.btnÜrünListeleme.Location = new System.Drawing.Point(142, 34);
            this.btnÜrünListeleme.Name = "btnÜrünListeleme";
            this.btnÜrünListeleme.Size = new System.Drawing.Size(121, 51);
            this.btnÜrünListeleme.TabIndex = 3;
            this.btnÜrünListeleme.Text = "Ürün Listeleme";
            this.btnÜrünListeleme.UseVisualStyleBackColor = true;
            this.btnÜrünListeleme.Click += new System.EventHandler(this.btnÜrünListeleme_Click);
            // 
            // btnÜrünEkleme
            // 
            this.btnÜrünEkleme.Location = new System.Drawing.Point(6, 34);
            this.btnÜrünEkleme.Name = "btnÜrünEkleme";
            this.btnÜrünEkleme.Size = new System.Drawing.Size(118, 51);
            this.btnÜrünEkleme.TabIndex = 2;
            this.btnÜrünEkleme.Text = "Ürün Ekleme";
            this.btnÜrünEkleme.UseVisualStyleBackColor = true;
            this.btnÜrünEkleme.Click += new System.EventHandler(this.btnÜrünEkleme_Click);
            // 
            // btnMüşteriListeleme
            // 
            this.btnMüşteriListeleme.Location = new System.Drawing.Point(142, 34);
            this.btnMüşteriListeleme.Name = "btnMüşteriListeleme";
            this.btnMüşteriListeleme.Size = new System.Drawing.Size(117, 51);
            this.btnMüşteriListeleme.TabIndex = 1;
            this.btnMüşteriListeleme.Text = "Kasiyer Listeleme";
            this.btnMüşteriListeleme.UseVisualStyleBackColor = true;
            this.btnMüşteriListeleme.Click += new System.EventHandler(this.btnMüşteriListeleme_Click);
            // 
            // btnKasiyerEkle
            // 
            this.btnKasiyerEkle.Location = new System.Drawing.Point(14, 34);
            this.btnKasiyerEkle.Name = "btnKasiyerEkle";
            this.btnKasiyerEkle.Size = new System.Drawing.Size(96, 51);
            this.btnKasiyerEkle.TabIndex = 0;
            this.btnKasiyerEkle.Text = "Kasiyer Ekleme";
            this.btnKasiyerEkle.UseVisualStyleBackColor = true;
            this.btnKasiyerEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKasiyerEkle);
            this.groupBox3.Controls.Add(this.btnMüşteriListeleme);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(20, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 113);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasiyer İşlemleri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnÜrünEkleme);
            this.groupBox4.Controls.Add(this.btnÜrünListeleme);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(20, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 113);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün İşlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 113);
            this.button1.TabIndex = 5;
            this.button1.Text = "Uygulamadan Çıkış Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSatisSayfası);
            this.groupBox1.Controls.Add(this.btnSatışlarıListeleme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(353, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 113);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İşlemleri";
            // 
            // btnSatisSayfası
            // 
            this.btnSatisSayfası.Location = new System.Drawing.Point(142, 33);
            this.btnSatisSayfası.Name = "btnSatisSayfası";
            this.btnSatisSayfası.Size = new System.Drawing.Size(112, 51);
            this.btnSatisSayfası.TabIndex = 5;
            this.btnSatisSayfası.Text = "Satış Sayfası";
            this.btnSatisSayfası.UseVisualStyleBackColor = true;
            this.btnSatisSayfası.Click += new System.EventHandler(this.btnSatisSayfası_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMarka);
            this.groupBox2.Controls.Add(this.btnKategori);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(353, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 113);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marka İşlemleri";
            // 
            // formSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Name = "formSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSatışlarıListeleme;
        private System.Windows.Forms.Button btnÜrünListeleme;
        private System.Windows.Forms.Button btnÜrünEkleme;
        private System.Windows.Forms.Button btnMüşteriListeleme;
        private System.Windows.Forms.Button btnKasiyerEkle;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSatisSayfası;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

