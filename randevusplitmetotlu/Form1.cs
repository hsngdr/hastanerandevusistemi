using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randevusplitmetotlu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //for github
        private void button1_Click(object sender, EventArgs e)
        {
            string tcno = textBox1.Text;
            string adi = textBox2.Text;
            string soyadi = textBox3.Text;
            string bolum = comboBox1.SelectedItem.ToString();
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string saat = comboBox2.SelectedItem.ToString();
            
            string satir = tcno + "*" + adi + "*" + soyadi + "*" + bolum + "*" + tarih + "*" + saat;
         
            bool s = randevu.varmıdır(bolum, tarih, saat);
            if (s == true)
                MessageBox.Show("Bu tarihte daha önce randevu alınmış lütfen yeniden deneyiniz!!");
            else
            { 
                randevu.ekle(satir);
                MessageBox.Show("Giriş başarılı , randevunuz belirtilen tarihe oluşturulmuştur");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string randevulistele = randevu.listele();
            textBox4.Text = randevulistele;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string arananbolum = comboBox3.SelectedItem.ToString();
            string aranantarih = dateTimePicker2.Value.ToShortDateString();           

            string aranansatir = arananbolum + "*" + aranantarih;

            string arananlistedir = randevu.Ogununrandevuları(arananbolum,aranantarih);
            textBox4.Text = arananlistedir;
        }
    }
}
