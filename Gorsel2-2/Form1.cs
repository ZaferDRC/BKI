using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_2
{
    public partial class Form1 : Form
    {
        VisibleS control = new VisibleS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            control.HideControl(label5,label6,label_Durum,label_Bki,picture_Zayif,picture_Normal,picture_Kilolu,picture_Obez);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                control.HideThePicture(picture_Zayif,picture_Normal,picture_Kilolu,picture_Obez);

                byte kilo, boyCM;
                double sonuc, boyM;

                kilo  = Convert.ToByte(textBox_Kilo.Text);
                boyCM = Convert.ToByte(textBox_Boy.Text);

                boyM  = boyCM / 100.0;

                sonuc = kilo / (boyM * boyM);

                if (radio_Erkek.Checked)
                {
                    if (sonuc < 18.5)
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki,picture_Zayif);

                        label_Bki.Text        = sonuc.ToString();
                        label_Durum.Text      = "ZAYIF";
                        
                    }

                    else if (sonuc >= 18.5 && sonuc <= 24.9)
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki, picture_Normal);

                        label_Bki.Text         = sonuc.ToString();
                        label_Durum.Text       = "NORMAL";
                        
                    }

                    else if (sonuc >= 25 && sonuc <= 30)
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki, picture_Kilolu);

                        label_Bki.Text         = sonuc.ToString();
                        label_Durum.Text       = "KİLOLU";
                    }

                    else
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki, picture_Obez);

                        label_Bki.Text       = sonuc.ToString();
                        label_Durum.Text     = "OBEZ";
                        
                    }
                }

                else if (radio_Kadin.Checked)
                {
                    if (sonuc < 18.5)
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki, picture_Zayif);

                        label_Bki.Text        = sonuc.ToString();
                        label_Durum.Text      = "ZAYIF";
                    }

                    else if (sonuc >= 18.5 && sonuc <= 24.9)
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki, picture_Kilolu);
                        
                        label_Bki.Text         = sonuc.ToString();
                        label_Durum.Text       = "KİLOLU";
                        
                    }

                    else
                    {
                        control.ShowControlOnePicture(label5, label6, label_Durum, label_Bki, picture_Obez);
                        
                        label_Bki.Text       = sonuc.ToString();
                        label_Durum.Text     = "OBEZ";
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen bir cinsiyet seçin!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Sadece Rakam Giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                control.HideControl(label5, label6, label_Durum, label_Bki, picture_Zayif, picture_Normal, picture_Kilolu, picture_Obez);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lütfen Gerçekçi Değerler Giriniz!","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);

                control.HideControl(label5, label6, label_Durum, label_Bki, picture_Zayif, picture_Normal, picture_Kilolu, picture_Obez);
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hata Oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                control.HideControl(label5, label6, label_Durum, label_Bki, picture_Zayif, picture_Normal, picture_Kilolu, picture_Obez);
            }

        }

        private void textBox_Kilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox'a girilen değer 3 karakterden büyükse ve backspace buna dahil değilse, klavyeden veri girişi kesilir.
            if (textBox_Kilo.Text.Length >= 3 && e.KeyChar !=(char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox_Boy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox'a girilen değer 3 karakterden büyükse ve backspace buna dahil değilse, klavyeden veri girişi kesilir.
            if (textBox_Boy.Text.Length >= 3 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

    }
}
