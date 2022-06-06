using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPD_B211210306_1_A_ERAY_POLAT
{
    public partial class Form1 : Form
    {
        private Button btnLoad;//buton nesnesi oluşturuldu.
        private TextBox textBox;//textbox nesnesi oluşturuldu.
        private Label label;//label nesnesi oluşturuldu.

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "2.Odev";//buton nesnesinin özellikleri tanımlandı.
            btnLoad = new Button();
            btnLoad.Text = "Hesapla";
            btnLoad.Left = 338;
            btnLoad.Top = 150;
            btnLoad.Width = 100;
            btnLoad.Height = 30;
            this.Controls.Add(btnLoad);//buton nesnesi forma eklendi.
            textBox = new TextBox();//textbox nesnesinin özellikleri tanımlandı.
            textBox.Text = "";
            textBox.Left = 338;
            textBox.Top = 100;
            textBox.Width = 120;
            textBox.Height = 60;
            this.Controls.Add(textBox);//textbox nesnesi forma eklendi.
            label = new Label();//label nesnesinin özellikleri tanımlandı.
            label.Text = "Deger :";
            label.Left = 338;
            label.Top = 130;
            label.Width = 400;
            label.Height = 30;
            this.Controls.Add(label);//label nesnesi forma eklendi.
            btnLoad.Click += BtnLoad_Click;//buton nesnesine butona basma eventi eklendi.
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string saydegeri = "", sayicik, saydegeriKrs = "";//tanımlamalar yapıldı.
            int[] sayis = new int[2];
            int sayiTL = 0, sayiKRS = 0;
            string[] blnsayi;
            bool sayikontrol;
            char[] sembol = new char[] { ',', '.' };
            sayicik = textBox.Text;
            blnsayi = sayicik.Split(sembol);
            if (textBox.Text != "")//textbox'a girilen deger boş değil ise.
            {

                sayikontrol = false;
                for (int i = 0; i < sayicik.Length; i++)//textbox nesnesinden sayicik degiskenine atanan degerin icinde virgül varmı kontrol edilip varsa true değeri yoksa zaten var olan false değeri döndürüldü.
                {
                    if (sayicik[i] == ',' || sayicik[i] == '.')
                    {
                        sayikontrol = true;
                    }
                }
                if (Convert.ToString(blnsayi[0]).Length < 6)//virgül var ise true döndürülen değer int veri tipine dönüştürülüp sayicik dan çıkarıldı uzunluk 6 dan küçükse islemler devam eder.
                {
                    for (int i = 0; i < blnsayi.Length; i++)//virgül var ise split ile 2 deger döndürücek yoksa 1 deger döndürücek bu degerleri virgülden önce sayiTL virgülden sonra sayiKRS degiskenine atandı virgül yoksa sadece sayiTL degiskenine atandı.
                    {
                        sayis[i] = Convert.ToInt32(blnsayi[i]);
                        if (i == 0)
                        {
                            sayiTL = sayis[i];
                        }
                        if (i == 1)
                        {
                            sayiKRS = sayis[i];
                        }
                    }
                    for (int i = 0; i < sayis.Length; i++)//sayi dizisinin içindeki degisken degeri kadar döndürüldü. 
                    {
                        label.ResetText();
                        if (i == 0)
                        {
                            if (sayiTL == 0)
                                saydegeri = "Sıfır ";
                            if (sayiTL > 999)
                            {
                                if (sayiTL / 10000 == 9)//Besinci basamak kontrölü
                                    saydegeri += "Doksan ";
                                if (sayiTL / 10000 == 8)
                                    saydegeri += "Seksen ";
                                if (sayiTL / 10000 == 7)
                                    saydegeri += "Yetmiş ";
                                if (sayiTL / 10000 == 6)
                                    saydegeri += "Almış ";
                                if (sayiTL / 10000 == 5)
                                    saydegeri += "Elli ";
                                if (sayiTL / 10000 == 4)
                                    saydegeri += "Kırk ";
                                if (sayiTL / 10000 == 3)
                                    saydegeri += "Otuz ";
                                if (sayiTL / 10000 == 2)
                                    saydegeri += "Yirmi ";
                                if (sayiTL / 10000 == 1)
                                    saydegeri += "On ";

                                if ((sayiTL % 10000) / 1000 == 9)//Dördüncü basamak kontrolu.
                                    saydegeri += "Dokuz ";
                                if ((sayiTL % 10000) / 1000 == 8)
                                    saydegeri += "Sekiz ";
                                if ((sayiTL % 10000) / 1000 == 7)
                                    saydegeri += "Yedi ";
                                if ((sayiTL % 10000) / 1000 == 6)
                                    saydegeri += "Altı ";
                                if ((sayiTL % 10000) / 1000 == 5)
                                    saydegeri += "Beş  ";
                                if ((sayiTL % 10000) / 1000 == 4)
                                    saydegeri += "Dört ";
                                if ((sayiTL % 10000) / 1000 == 3)
                                    saydegeri += "Üç ";
                                if ((sayiTL % 10000) / 1000 == 2)
                                    saydegeri += "İki ";
                                saydegeri += "Bin ";

                            }
                            if ((sayiTL % 1000) / 100 == 9)//ücüncü basamak kontrölü.
                                saydegeri += "Dokuz Yüz ";
                            if ((sayiTL % 1000) / 100 == 8)
                                saydegeri += "Sekiz Yüz ";
                            if ((sayiTL % 1000) / 100 == 7)
                                saydegeri += "Yedi Yüz ";
                            if ((sayiTL % 1000) / 100 == 6)
                                saydegeri += "Altı Yüz  ";
                            if ((sayiTL % 1000) / 100 == 5)
                                saydegeri += "Beş Yüz ";
                            if ((sayiTL % 1000) / 100 == 4)
                                saydegeri += "Dört Yüz ";
                            if ((sayiTL % 1000) / 100 == 3)
                                saydegeri += "Üç Yüz ";
                            if ((sayiTL % 1000) / 100 == 2)
                                saydegeri += "İki Yüz ";
                            if ((sayiTL % 1000) / 100 == 1)
                                saydegeri += "Yüz ";

                            if ((sayiTL % 100) / 10 == 9)//ikinci basamak kontrölü.
                                saydegeri += "Doksan ";
                            if ((sayiTL % 100) / 10 == 8)
                                saydegeri += "Seksen ";
                            if ((sayiTL % 100) / 10 == 7)
                                saydegeri += "Yetmiş ";
                            if ((sayiTL % 100) / 10 == 6)
                                saydegeri += "Atmış ";
                            if ((sayiTL % 100) / 10 == 5)
                                saydegeri += "Elli ";
                            if ((sayiTL % 100) / 10 == 4)
                                saydegeri += "Kırk ";
                            if ((sayiTL % 100) / 10 == 3)
                                saydegeri += "Otuz ";
                            if ((sayiTL % 100) / 10 == 2)
                                saydegeri += "Yirmi ";
                            if ((sayiTL % 100) / 10 == 1)
                                saydegeri += "On ";

                            if ((sayiTL % 10) == 9)//birinci basamak kontrölü
                                saydegeri += "Dokuz ";
                            if ((sayiTL % 10) == 8)
                                saydegeri += "Sekiz ";
                            if ((sayiTL % 10) == 7)
                                saydegeri += "Yedi ";
                            if ((sayiTL % 10) == 6)
                                saydegeri += "Altı ";
                            if ((sayiTL % 10) == 5)
                                saydegeri += "Beş ";
                            if ((sayiTL % 10) == 4)
                                saydegeri += "Dört ";
                            if ((sayiTL % 10) == 3)
                                saydegeri += "Üç ";
                            if ((sayiTL % 10) == 2)
                                saydegeri += "İki ";
                            if ((sayiTL % 10) == 1)
                                saydegeri += "Bir ";
                            saydegeri += " Türklirası ";
                        }
                        if (i == 1)//virgülden sonraki deger icin
                        {
                            if (sayiKRS < 100)
                            {
                                if (sayiKRS / 10 == 9)
                                    saydegeriKrs += "Doksan ";//virgülden sonraki birinci basamak köntrolü
                                if (sayiKRS / 10 == 8)
                                    saydegeriKrs += "Seksen ";
                                if (sayiKRS / 10 == 7)
                                    saydegeriKrs += "Yetmiş ";
                                if (sayiKRS / 10 == 6)
                                    saydegeriKrs += "Atmış ";
                                if (sayiKRS / 10 == 5)
                                    saydegeriKrs += "Elli ";
                                if (sayiKRS / 10 == 4)
                                    saydegeriKrs += "Kırk ";
                                if (sayiKRS / 10 == 3)
                                    saydegeriKrs += "Otuz ";
                                if (sayiKRS / 10 == 2)
                                    saydegeriKrs += "Yirmi ";
                                if (sayiKRS / 10 == 1)
                                    saydegeriKrs += "On ";

                                if (sayiKRS % 10 == 9)//virgülden sonraki ikinci basamak kontrölü
                                    saydegeriKrs += "Dokuz ";
                                if (sayiKRS % 10 == 8)
                                    saydegeriKrs += "Sekiz ";
                                if (sayiKRS % 10 == 7)
                                    saydegeriKrs += "Yedi ";
                                if (sayiKRS % 10 == 6)
                                    saydegeriKrs += "Altı ";
                                if (sayiKRS % 10 == 5)
                                    saydegeriKrs += "Beş ";
                                if (sayiKRS % 10 == 4)
                                    saydegeriKrs += "Dört ";
                                if (sayiKRS % 10 == 3)
                                    saydegeriKrs += "Üç ";
                                if (sayiKRS % 10 == 2)
                                    saydegeriKrs += "İki ";
                                if (sayiKRS % 10 == 1)
                                    saydegeriKrs += "Bir ";
                                if (sayiKRS == 0)
                                    saydegeriKrs = "Sıfır";
                                saydegeriKrs += " Kurus";
                                label.Text = saydegeri + " " + saydegeriKrs;
                            }
                            else
                            {
                                MessageBox.Show("Kurus kısmı maksimum 99 olabilir", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girilen sayı maksimum 5 basamaklı olabilir", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);//girilen basamak adedi 6 dan fazla ise
                }
            }
            else
            {
                MessageBox.Show("Lütfen 0-5 Basamaklı bir sayı giriniz", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);//girilen deger bos,null ise.
            }

        }
    }
}
