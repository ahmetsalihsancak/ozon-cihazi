
namespace OZON__
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.baglan_button = new System.Windows.Forms.Button();
            this.baglanti_info_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.led1_button = new System.Windows.Forms.Button();
            this.led2_button = new System.Windows.Forms.Button();
            this.led3_button = new System.Windows.Forms.Button();
            this.led4_button = new System.Windows.Forms.Button();
            this.led1_yesil = new System.Windows.Forms.Button();
            this.led2_turuncu = new System.Windows.Forms.Button();
            this.led3_kirmizi = new System.Windows.Forms.Button();
            this.led4_mavi = new System.Windows.Forms.Button();
            this.RTC_senkron_button = new System.Windows.Forms.Button();
            this.timer_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.baslama_saat_combo = new System.Windows.Forms.ComboBox();
            this.baslama_dakika_combo = new System.Windows.Forms.ComboBox();
            this.bitis_dakika_combo = new System.Windows.Forms.ComboBox();
            this.bitis_saat_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gun_combo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kur_button = new System.Windows.Forms.Button();
            this.deneme_label = new System.Windows.Forms.Label();
            this.loop_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.alarm_sifirlama_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.alarm_sifirlama_combo = new System.Windows.Forms.ComboBox();
            this.hepsini_sifirla_button = new System.Windows.Forms.Button();
            this.transmit_data_text = new System.Windows.Forms.TextBox();
            this.send_data_button = new System.Windows.Forms.Button();
            this.incoming_data_text = new System.Windows.Forms.TextBox();
            this.tekrar_check_box = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // baglan_button
            // 
            this.baglan_button.Location = new System.Drawing.Point(137, 7);
            this.baglan_button.Name = "baglan_button";
            this.baglan_button.Size = new System.Drawing.Size(75, 23);
            this.baglan_button.TabIndex = 0;
            this.baglan_button.Text = "BAĞLAN";
            this.baglan_button.UseVisualStyleBackColor = true;
            this.baglan_button.Click += new System.EventHandler(this.baglan_button_Click);
            // 
            // baglanti_info_label
            // 
            this.baglanti_info_label.AutoSize = true;
            this.baglanti_info_label.ForeColor = System.Drawing.Color.Red;
            this.baglanti_info_label.Location = new System.Drawing.Point(134, 33);
            this.baglanti_info_label.Name = "baglanti_info_label";
            this.baglanti_info_label.Size = new System.Drawing.Size(85, 13);
            this.baglanti_info_label.TabIndex = 1;
            this.baglanti_info_label.Text = "BAĞLANTI YOK";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // led1_button
            // 
            this.led1_button.Location = new System.Drawing.Point(23, 45);
            this.led1_button.Name = "led1_button";
            this.led1_button.Size = new System.Drawing.Size(75, 23);
            this.led1_button.TabIndex = 3;
            this.led1_button.Text = "LED 1";
            this.led1_button.UseVisualStyleBackColor = true;
            this.led1_button.Click += new System.EventHandler(this.led1_button_Click);
            // 
            // led2_button
            // 
            this.led2_button.Location = new System.Drawing.Point(23, 74);
            this.led2_button.Name = "led2_button";
            this.led2_button.Size = new System.Drawing.Size(75, 23);
            this.led2_button.TabIndex = 4;
            this.led2_button.Text = "LED 2";
            this.led2_button.UseVisualStyleBackColor = true;
            this.led2_button.Click += new System.EventHandler(this.led2_button_Click);
            // 
            // led3_button
            // 
            this.led3_button.Enabled = false;
            this.led3_button.Location = new System.Drawing.Point(23, 103);
            this.led3_button.Name = "led3_button";
            this.led3_button.Size = new System.Drawing.Size(75, 23);
            this.led3_button.TabIndex = 5;
            this.led3_button.Text = "LED 3";
            this.led3_button.UseVisualStyleBackColor = true;
            this.led3_button.Click += new System.EventHandler(this.led3_button_Click);
            // 
            // led4_button
            // 
            this.led4_button.Enabled = false;
            this.led4_button.Location = new System.Drawing.Point(23, 132);
            this.led4_button.Name = "led4_button";
            this.led4_button.Size = new System.Drawing.Size(75, 23);
            this.led4_button.TabIndex = 6;
            this.led4_button.Text = "LED 4";
            this.led4_button.UseVisualStyleBackColor = true;
            this.led4_button.Click += new System.EventHandler(this.led4_button_Click);
            // 
            // led1_yesil
            // 
            this.led1_yesil.BackColor = System.Drawing.Color.Lime;
            this.led1_yesil.Enabled = false;
            this.led1_yesil.ForeColor = System.Drawing.Color.Snow;
            this.led1_yesil.Location = new System.Drawing.Point(104, 45);
            this.led1_yesil.Name = "led1_yesil";
            this.led1_yesil.Size = new System.Drawing.Size(23, 23);
            this.led1_yesil.TabIndex = 7;
            this.led1_yesil.UseVisualStyleBackColor = false;
            // 
            // led2_turuncu
            // 
            this.led2_turuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led2_turuncu.Enabled = false;
            this.led2_turuncu.Location = new System.Drawing.Point(104, 74);
            this.led2_turuncu.Name = "led2_turuncu";
            this.led2_turuncu.Size = new System.Drawing.Size(23, 23);
            this.led2_turuncu.TabIndex = 8;
            this.led2_turuncu.UseVisualStyleBackColor = false;
            // 
            // led3_kirmizi
            // 
            this.led3_kirmizi.BackColor = System.Drawing.Color.Red;
            this.led3_kirmizi.Enabled = false;
            this.led3_kirmizi.Location = new System.Drawing.Point(104, 103);
            this.led3_kirmizi.Name = "led3_kirmizi";
            this.led3_kirmizi.Size = new System.Drawing.Size(23, 23);
            this.led3_kirmizi.TabIndex = 9;
            this.led3_kirmizi.UseVisualStyleBackColor = false;
            // 
            // led4_mavi
            // 
            this.led4_mavi.BackColor = System.Drawing.Color.Blue;
            this.led4_mavi.Enabled = false;
            this.led4_mavi.Location = new System.Drawing.Point(104, 132);
            this.led4_mavi.Name = "led4_mavi";
            this.led4_mavi.Size = new System.Drawing.Size(23, 23);
            this.led4_mavi.TabIndex = 10;
            this.led4_mavi.UseVisualStyleBackColor = false;
            // 
            // RTC_senkron_button
            // 
            this.RTC_senkron_button.Location = new System.Drawing.Point(56, 193);
            this.RTC_senkron_button.Name = "RTC_senkron_button";
            this.RTC_senkron_button.Size = new System.Drawing.Size(108, 23);
            this.RTC_senkron_button.TabIndex = 11;
            this.RTC_senkron_button.Text = "RTC Senkron";
            this.RTC_senkron_button.UseVisualStyleBackColor = true;
            this.RTC_senkron_button.Click += new System.EventHandler(this.RTC_senkron_button_Click);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(52, 177);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(118, 13);
            this.timer_label.TabIndex = 12;
            this.timer_label.Text = "00.00.00 XXX 00:00:00";
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // baslama_saat_combo
            // 
            this.baslama_saat_combo.FormattingEnabled = true;
            this.baslama_saat_combo.Location = new System.Drawing.Point(252, 47);
            this.baslama_saat_combo.Name = "baslama_saat_combo";
            this.baslama_saat_combo.Size = new System.Drawing.Size(42, 21);
            this.baslama_saat_combo.TabIndex = 13;
            // 
            // baslama_dakika_combo
            // 
            this.baslama_dakika_combo.FormattingEnabled = true;
            this.baslama_dakika_combo.Location = new System.Drawing.Point(300, 47);
            this.baslama_dakika_combo.Name = "baslama_dakika_combo";
            this.baslama_dakika_combo.Size = new System.Drawing.Size(42, 21);
            this.baslama_dakika_combo.TabIndex = 14;
            // 
            // bitis_dakika_combo
            // 
            this.bitis_dakika_combo.FormattingEnabled = true;
            this.bitis_dakika_combo.Location = new System.Drawing.Point(429, 47);
            this.bitis_dakika_combo.Name = "bitis_dakika_combo";
            this.bitis_dakika_combo.Size = new System.Drawing.Size(42, 21);
            this.bitis_dakika_combo.TabIndex = 16;
            // 
            // bitis_saat_combo
            // 
            this.bitis_saat_combo.FormattingEnabled = true;
            this.bitis_saat_combo.Location = new System.Drawing.Point(381, 47);
            this.bitis_saat_combo.Name = "bitis_saat_combo";
            this.bitis_saat_combo.Size = new System.Drawing.Size(42, 21);
            this.bitis_saat_combo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SAAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "DAKİKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "BAŞLANGIÇ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "BİTİŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "DAKİKA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SAAT";
            // 
            // gun_combo
            // 
            this.gun_combo.FormattingEnabled = true;
            this.gun_combo.Location = new System.Drawing.Point(301, 93);
            this.gun_combo.Name = "gun_combo";
            this.gun_combo.Size = new System.Drawing.Size(122, 21);
            this.gun_combo.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "GÜN";
            // 
            // kur_button
            // 
            this.kur_button.Location = new System.Drawing.Point(326, 167);
            this.kur_button.Name = "kur_button";
            this.kur_button.Size = new System.Drawing.Size(75, 23);
            this.kur_button.TabIndex = 25;
            this.kur_button.Text = "KUR";
            this.kur_button.UseVisualStyleBackColor = true;
            this.kur_button.Click += new System.EventHandler(this.kur_button_Click);
            // 
            // deneme_label
            // 
            this.deneme_label.AutoSize = true;
            this.deneme_label.Location = new System.Drawing.Point(311, 151);
            this.deneme_label.Name = "deneme_label";
            this.deneme_label.Size = new System.Drawing.Size(35, 13);
            this.deneme_label.TabIndex = 26;
            this.deneme_label.Text = "label8";
            // 
            // loop_combo
            // 
            this.loop_combo.FormattingEnabled = true;
            this.loop_combo.Location = new System.Drawing.Point(520, 47);
            this.loop_combo.Name = "loop_combo";
            this.loop_combo.Size = new System.Drawing.Size(42, 21);
            this.loop_combo.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "ÇALIŞMA PERİYODU";
            // 
            // alarm_sifirlama_button
            // 
            this.alarm_sifirlama_button.Location = new System.Drawing.Point(507, 132);
            this.alarm_sifirlama_button.Name = "alarm_sifirlama_button";
            this.alarm_sifirlama_button.Size = new System.Drawing.Size(75, 23);
            this.alarm_sifirlama_button.TabIndex = 30;
            this.alarm_sifirlama_button.Text = "SIFIRLA";
            this.alarm_sifirlama_button.UseVisualStyleBackColor = true;
            this.alarm_sifirlama_button.Click += new System.EventHandler(this.alarm_sifirlama_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "ALARM NO";
            // 
            // alarm_sifirlama_combo
            // 
            this.alarm_sifirlama_combo.FormattingEnabled = true;
            this.alarm_sifirlama_combo.Location = new System.Drawing.Point(524, 108);
            this.alarm_sifirlama_combo.Name = "alarm_sifirlama_combo";
            this.alarm_sifirlama_combo.Size = new System.Drawing.Size(39, 21);
            this.alarm_sifirlama_combo.TabIndex = 32;
            // 
            // hepsini_sifirla_button
            // 
            this.hepsini_sifirla_button.Location = new System.Drawing.Point(490, 161);
            this.hepsini_sifirla_button.Name = "hepsini_sifirla_button";
            this.hepsini_sifirla_button.Size = new System.Drawing.Size(110, 23);
            this.hepsini_sifirla_button.TabIndex = 33;
            this.hepsini_sifirla_button.Text = "HEPSİNİ SIFIRLA";
            this.hepsini_sifirla_button.UseVisualStyleBackColor = true;
            this.hepsini_sifirla_button.Click += new System.EventHandler(this.hepsini_sifirla_button_Click);
            // 
            // transmit_data_text
            // 
            this.transmit_data_text.Location = new System.Drawing.Point(12, 251);
            this.transmit_data_text.Multiline = true;
            this.transmit_data_text.Name = "transmit_data_text";
            this.transmit_data_text.Size = new System.Drawing.Size(334, 102);
            this.transmit_data_text.TabIndex = 34;
            // 
            // send_data_button
            // 
            this.send_data_button.Location = new System.Drawing.Point(137, 362);
            this.send_data_button.Name = "send_data_button";
            this.send_data_button.Size = new System.Drawing.Size(75, 23);
            this.send_data_button.TabIndex = 35;
            this.send_data_button.Text = "GÖNDER";
            this.send_data_button.UseVisualStyleBackColor = true;
            this.send_data_button.Click += new System.EventHandler(this.send_data_button_Click);
            // 
            // incoming_data_text
            // 
            this.incoming_data_text.Location = new System.Drawing.Point(363, 251);
            this.incoming_data_text.Multiline = true;
            this.incoming_data_text.Name = "incoming_data_text";
            this.incoming_data_text.ReadOnly = true;
            this.incoming_data_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.incoming_data_text.Size = new System.Drawing.Size(250, 134);
            this.incoming_data_text.TabIndex = 36;
            // 
            // tekrar_check_box
            // 
            this.tekrar_check_box.AutoSize = true;
            this.tekrar_check_box.Enabled = false;
            this.tekrar_check_box.Location = new System.Drawing.Point(326, 120);
            this.tekrar_check_box.Name = "tekrar_check_box";
            this.tekrar_check_box.Size = new System.Drawing.Size(79, 17);
            this.tekrar_check_box.TabIndex = 37;
            this.tekrar_check_box.Text = "TEKRARLI";
            this.tekrar_check_box.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 397);
            this.Controls.Add(this.tekrar_check_box);
            this.Controls.Add(this.incoming_data_text);
            this.Controls.Add(this.send_data_button);
            this.Controls.Add(this.transmit_data_text);
            this.Controls.Add(this.hepsini_sifirla_button);
            this.Controls.Add(this.alarm_sifirlama_combo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.alarm_sifirlama_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.loop_combo);
            this.Controls.Add(this.deneme_label);
            this.Controls.Add(this.kur_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gun_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitis_dakika_combo);
            this.Controls.Add(this.bitis_saat_combo);
            this.Controls.Add(this.baslama_dakika_combo);
            this.Controls.Add(this.baslama_saat_combo);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.RTC_senkron_button);
            this.Controls.Add(this.led4_mavi);
            this.Controls.Add(this.led3_kirmizi);
            this.Controls.Add(this.led2_turuncu);
            this.Controls.Add(this.led1_yesil);
            this.Controls.Add(this.led4_button);
            this.Controls.Add(this.led3_button);
            this.Controls.Add(this.led2_button);
            this.Controls.Add(this.led1_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.baglanti_info_label);
            this.Controls.Add(this.baglan_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button baglan_button;
        private System.Windows.Forms.Label baglanti_info_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button led1_button;
        private System.Windows.Forms.Button led2_button;
        private System.Windows.Forms.Button led3_button;
        private System.Windows.Forms.Button led4_button;
        private System.Windows.Forms.Button led1_yesil;
        private System.Windows.Forms.Button led2_turuncu;
        private System.Windows.Forms.Button led3_kirmizi;
        private System.Windows.Forms.Button led4_mavi;
        private System.Windows.Forms.Button RTC_senkron_button;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox baslama_saat_combo;
        private System.Windows.Forms.ComboBox baslama_dakika_combo;
        private System.Windows.Forms.ComboBox bitis_dakika_combo;
        private System.Windows.Forms.ComboBox bitis_saat_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gun_combo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kur_button;
        private System.Windows.Forms.Label deneme_label;
        private System.Windows.Forms.ComboBox loop_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button alarm_sifirlama_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox alarm_sifirlama_combo;
        private System.Windows.Forms.Button hepsini_sifirla_button;
        private System.Windows.Forms.TextBox transmit_data_text;
        private System.Windows.Forms.Button send_data_button;
        private System.Windows.Forms.TextBox incoming_data_text;
        private System.Windows.Forms.CheckBox tekrar_check_box;
    }
}

