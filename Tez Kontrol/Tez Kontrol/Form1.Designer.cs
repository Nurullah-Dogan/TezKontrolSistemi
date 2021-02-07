namespace Tez_Kontrol
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
            this.dosya_sec_btn = new System.Windows.Forms.Button();
            this.dosya_yolu_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dosya_sec_btn
            // 
            this.dosya_sec_btn.Location = new System.Drawing.Point(25, 12);
            this.dosya_sec_btn.Name = "dosya_sec_btn";
            this.dosya_sec_btn.Size = new System.Drawing.Size(85, 23);
            this.dosya_sec_btn.TabIndex = 0;
            this.dosya_sec_btn.Text = "Dosya Seç";
            this.dosya_sec_btn.UseVisualStyleBackColor = true;
            this.dosya_sec_btn.Click += new System.EventHandler(this.dosya_sec_btn_Click);
            // 
            // dosya_yolu_label
            // 
            this.dosya_yolu_label.AutoSize = true;
            this.dosya_yolu_label.Location = new System.Drawing.Point(118, 17);
            this.dosya_yolu_label.Name = "dosya_yolu_label";
            this.dosya_yolu_label.Size = new System.Drawing.Size(85, 13);
            this.dosya_yolu_label.TabIndex = 1;
            this.dosya_yolu_label.Text = "Dosya Seçilmedi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tez Kontrol Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(25, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 251);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(212, 103);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(151, 251);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.Location = new System.Drawing.Point(785, 103);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(151, 251);
            this.listBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlıklar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Metinler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resimler ve Tablolar";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.Location = new System.Drawing.Point(403, 103);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(151, 251);
            this.listBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Önsöz";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.HorizontalScrollbar = true;
            this.listBox5.Location = new System.Drawing.Point(982, 103);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(151, 251);
            this.listBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(995, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Çift Tırnak İçindeki Cümleler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Başlık Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(782, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Şekil Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "\"Teşekkür\" ibaresi var mı?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1192, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doğrudan Alıntı Cümleler";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.HorizontalScrollbar = true;
            this.listBox6.Location = new System.Drawing.Point(1177, 103);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(151, 251);
            this.listBox6.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(995, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cümle Sayısı: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1192, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Alıntı Sayısı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(782, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tablo Sayısı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(599, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Büyük-Küçük harf hatası:";
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.HorizontalScrollbar = true;
            this.listBox7.Location = new System.Drawing.Point(593, 103);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(151, 251);
            this.listBox7.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1192, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "50 Kelimeden Fazla";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(995, 371);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Çift Tırnak İçindeki";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(599, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Büyük-Küçük Harf Hatası";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(413, 371);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Önsöz ilk paragrafta ";
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.HorizontalScrollbar = true;
            this.listBox8.Location = new System.Drawing.Point(25, 459);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(338, 199);
            this.listBox8.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 671);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kaynak Sayısı:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(121, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(433, 23);
            this.progressBar1.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(149, 442);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Kaynaklar";
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Location = new System.Drawing.Point(593, 459);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(151, 199);
            this.listBox9.TabIndex = 33;
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.Location = new System.Drawing.Point(982, 459);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(151, 199);
            this.listBox10.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(581, 442);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Metin İçinde Atıf Yapılmayan Şekiller";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(966, 443);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(181, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "Metin İçinde Atıf Yapılmayan Tablolar";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(589, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(606, 24);
            this.label22.TabIndex = 37;
            this.label22.Text = "UYARI: Kontrol edilecek word belgesinin dosya adında boşluk olmamalı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 712);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.listBox9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dosya_yolu_label);
            this.Controls.Add(this.dosya_sec_btn);
            this.Name = "Form1";
            this.Text = "TEZ KONTROL SİSTEMİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dosya_sec_btn;
        private System.Windows.Forms.Label dosya_yolu_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

