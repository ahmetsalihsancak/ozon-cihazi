using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace OZON__
{
    public partial class Form1 : Form
    {
        int baslama_saat = 0, baslama_dakika = 0, bitis_saat = 0, bitis_dakika = 0, loop_to_label = 0;
        string gun_to_label = "0";
        private string incoming_data;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; //bu kod form1'in tekrar yüklenmesini sağlıyor, yazmayınca port'ları alamıyor niye bilmiyorum
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            object[] saatler = new object[24];
            object[] dakikalar = new object[60];
            object[] gunler = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            object[] alarm__no = new object[5];
            for (int i = 0; i < 60; i++)
            {
                dakikalar[i] = i;
                if (i < 5) alarm__no[i] = i + 1;
                if (i < 24) saatler[i] = i;
            }
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            baslama_saat_combo.Items.AddRange(saatler);
            bitis_saat_combo.Items.AddRange(saatler);
            baslama_dakika_combo.Items.AddRange(dakikalar);
            bitis_dakika_combo.Items.AddRange(dakikalar);
            gun_combo.Items.AddRange(gunler);
            loop_combo.Items.AddRange(dakikalar);
            alarm_sifirlama_combo.Items.AddRange(alarm__no);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
            timer1.Start();
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                incoming_data = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(displayData_event));
            }
        }
        private void displayData_event(object sender, EventArgs e)
        {
            incoming_data_text.Text += incoming_data + "    " + Environment.NewLine; //Gelen veri
            //Console.WriteLine(incoming_data_text);
            incoming_data_text.SelectionStart = incoming_data_text.Text.Length;
            incoming_data_text.ScrollToCaret(); //textbox'ı kaydır
        }

        private void baglan_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBox1.Text; //ComboBox1'de seçili nesneyi port ismine ata
                    serialPort1.BaudRate = 9600; //BaudRate ayarla
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open(); //Seri portu aç
                    baglanti_info_label.Text = "BAĞLANTI VAR";
                    baglanti_info_label.ForeColor = Color.Green;
                }
                else
                {
                    serialPort1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BAĞLANTI BAŞARISIZ"); //Hata mesajı göster
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }

        private void led1_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Write("A111111111111Z");
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private void led2_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Write("A222222222222Z");
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private void led3_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Write("A333333333333Z");
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private void led4_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Write("A444444444444Z");
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private void alarm_sifirlama_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen & (alarm_sifirlama_combo.Text != "")) serialPort1.Write("A7"+alarm_sifirlama_combo.Text+"0000000000Z");
            else MessageBox.Show("BAĞLANTI YOK veya ALARM SIFIRLAMA BOŞ BIRAKILAMAZ");
        }

        private void hepsini_sifirla_button_Click(object sender, EventArgs e)
        {
            string data = "A710000000000ZA720000000000ZA730000000000ZA740000000000ZA750000000000Z";
            if (serialPort1.IsOpen) serialPort1.Write(data);
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private void send_data_button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Write(transmit_data_text.Text);
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private void RTC_senkron_button_Click(object sender, EventArgs e)
        {
            int hour_ = DateTime.Now.Hour;
            int hour_1 = hour_ / 10;
            int hour_2 = hour_ % 10;

            int min_ = DateTime.Now.Minute;
            int min_1 = min_ / 10;
            int min_2 = min_ % 10;

            int sec_ = DateTime.Now.Second;
            int sec_1 = sec_ / 10;
            int sec_2 = sec_ % 10;

            int day_ = DateTime.Now.Day;
            int day_1 = day_ / 10;
            int day_2 = day_ % 10;

            int month_ = DateTime.Now.Month;

            int year_ = DateTime.Now.Year;
            year_ = year_ % 100;
            int year_1 = year_ / 10;
            int year_2 = year_ % 10;

            string weekDay_ = DAY_OF_WEEK_TO_INT(DateTime.Now.DayOfWeek.ToString());

            string time_transmit = "A5" + hour_1.ToString() + hour_2.ToString() + min_1.ToString() + min_2.ToString() + sec_1.ToString() +
                sec_2.ToString() + day_1.ToString() + day_2.ToString() + month_.ToString() + year_1.ToString() + year_2.ToString() + "Z" +
                "A8" + weekDay_ + "0000000000Z";

            if (serialPort1.IsOpen) serialPort1.Write(time_transmit);
            else MessageBox.Show("BAĞLANTI YOK");
        }

        private string DAY_OF_WEEK_TO_INT(string DATA_)
        {
            switch (DATA_)
            {
                case "Monday": return "1";
                case "Tuesday": return "2";
                case "Wednesday": return "3";
                case "Thursday": return "4";
                case "Friday": return "5";
                case "Saturday": return "6";
                case "Sunday": return "7";
                default: return "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_label.Text = DateTime.Now.ToString("dd/MM/yy ddd HH:mm:ss");
            if (loop_combo.Text != "") loop_to_label = int.Parse(loop_combo.Text);
            if (baslama_dakika_combo.Text != "") baslama_dakika = int.Parse(baslama_dakika_combo.Text);
            if (baslama_saat_combo.Text != "") baslama_saat = int.Parse(baslama_saat_combo.Text);
            if (bitis_dakika_combo.Text != "") bitis_dakika = int.Parse(bitis_dakika_combo.Text);
            if (bitis_saat_combo.Text != "") bitis_saat = int.Parse(bitis_saat_combo.Text);
            if (gun_combo.Text != "") gun_to_label = DAY_OF_WEEK_TO_INT(gun_combo.Text);
            string txt = baslama_saat_combo.Text + ":" + baslama_dakika_combo.Text + " - " + bitis_saat_combo.Text + ":" + bitis_dakika_combo.Text + 
                " Periyot:" + loop_combo.Text + " Gün: " + gun_combo.Text;
            deneme_label.Text = txt;
            if (!serialPort1.IsOpen) 
            {
                baglanti_info_label.Text = "BAĞLANTI YOK";
                baglanti_info_label.ForeColor = Color.Red;
            }
        }

        private void kur_button_Click(object sender, EventArgs e)
        {
            int loop_1 = loop_to_label / 10;
            int loop_2 = loop_to_label % 10;

            int baslama_saat_1 = baslama_saat / 10;
            int baslama_saat_2 = baslama_saat % 10;

            int baslama_dakika_1 = baslama_dakika / 10;
            int baslama_dakika_2 = baslama_dakika % 10;

            int bitis_saat_1 = bitis_saat / 10;
            int bitis_saat_2 = bitis_saat % 10;

            int bitis_dakika_1 = bitis_dakika / 10;
            int bitis_dakika_2 = bitis_dakika % 10;

            string data_transmit = "A6" + baslama_saat_1.ToString() + baslama_saat_2.ToString() + baslama_dakika_1.ToString() +
                baslama_dakika_2.ToString() + bitis_saat_1.ToString() + bitis_saat_2.ToString() + bitis_dakika_1.ToString() +
                bitis_dakika_2.ToString() + gun_to_label + loop_1.ToString() + loop_2.ToString() + "Z";
            int check_box_F;
            if (tekrar_check_box.Checked == true) check_box_F = 1;
            else check_box_F = 0;
            string tekrarli_data_transmit = "A9"+ check_box_F.ToString()+"0000000000Z";
            if (serialPort1.IsOpen & (loop_combo.Text != "" | baslama_dakika_combo.Text != "" | baslama_saat_combo.Text != "" |
                bitis_dakika_combo.Text != "" | bitis_saat_combo.Text != "" | gun_combo.Text != "")) serialPort1.Write(data_transmit+ tekrarli_data_transmit);
            else MessageBox.Show("BAĞLANTI YOK veya ZAMAN AYARLARI BOŞ BIRAKILAMAZ");
        }
    }
}
