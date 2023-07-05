using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                {

                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    
                    int bas = 1, bit = 80;
                    int[] girilensayılar = new int[10];
                    int y = 0;
                    MessageBox.Show("Unutma 1 İle 80 Arasında 10 tane Sayı Giriceksin");
                    while (y < 10)

                    {
                        int tahminsayısı = int.Parse(Interaction.InputBox("1-80 arasında 10 tane sayı giriniz(Öğrenmek için soru işaretine tıklayınız)", "Sayınızı Giriniz", "0", 250, 250));
                        listBox2.Items.Add(tahminsayısı);
                        
                        if (tahminsayısı < bas || tahminsayısı > bit)
                        {
                            MessageBox.Show("1-80 arasında dedim!!");
                            continue;
                        }

                        {
                            int yoksa = Array.IndexOf(girilensayılar, tahminsayısı);
                            if (yoksa == -1) // AYNI SAYIYI GİRMEZSE DÖNGÜ DEVAM EDİYOR 
                            {

                                girilensayılar[y] = tahminsayısı;
                                y++;
                            }
                            else   // AYNI SAYIYI GİRERSE TEKRAR BAŞA DÖNÜP SORUYOR 
                            {
                                MessageBox.Show("AYNI SAYIYI GİREMESSİN !!");
                                MessageBox.Show("BU HATAYI 2-3 KERE ALDIYSAN BAŞKA BİRİNE VER KLAVYE MAUSU!!");
                            }
                        }
                        
                    } listBox2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;

                    Random rastgelesayı = new Random();
                    int[] randomsayılarım = new int[20];
                    int x = 0;
                    while (x < 20)
                    {
                        int şanslısayı = rastgelesayı.Next(bas, bit + 1);
                        int yoksa = Array.IndexOf(randomsayılarım, şanslısayı);
                        if (yoksa == -1)
                        {
                            randomsayılarım[x] = şanslısayı;
                            listBox3.Items.Add(randomsayılarım[x]);
                            listBox3.Visible = true;
                            x++;
                        }


                    }
                    foreach (int girilen in girilensayılar)
                    {
                        foreach (int randomlar in randomsayılarım)
                        {
                            if (randomlar == girilen)
                            {
                                listBox1.Visible = true;
                                listBox1.Items.Add("Doğru Bildin " + randomlar + "=" + girilen);

                            }
                           
                        }
                    }
                    int puanlama = listBox1.Items.Count * 10;
                    if (puanlama==0)
                    {
                        MessageBox.Show("SIĞINAĞIN VARSA ORADA BEKLE");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    if (puanlama == 10)
                    {
                        MessageBox.Show("BUGÜN SADECE YATAKTA KAL");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 20)
                    {
                        MessageBox.Show("BUGÜN PRİZE KABLO BİLE TAKMA ");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 30)
                    {
                        MessageBox.Show("EVDEN BİLE CIKMA DERİM");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 40)
                    {
                        MessageBox.Show("KENDİNİ FAZLA TEHLİKEYE ATMA HAYATINA DEVAM ET");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 50)
                    {
                        MessageBox.Show("NORMAL YAŞAMINA DEVAM ET");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 60)
                    {
                        MessageBox.Show("ÇOK AZ ŞANSLISIN BUGÜN ŞANSLA İLGİLİ BİŞEY YAPMA");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 70)
                    {
                        MessageBox.Show("70 PUAN İYİ BELKİ 1-2 DEFA KAZI KAZAN YAPABİLİRSİN");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 80)
                    {
                        MessageBox.Show("ŞANSIN GAYET İYİ BALIĞA FİLAN GİT GÜZEL BALIKLAR TUTARSIN");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 90)
                    {
                        MessageBox.Show("EVLİ DEĞİLSEN VEYA SEVGİLİN YOKSA BUGÜN ŞANSINI DENE DERİM");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                    else if (puanlama == 100)
                    {
                        MessageBox.Show("KOŞ DİREK LOTO FİLAN OYNA");
                        MessageBox.Show("Puanınız " + puanlama);
                        label2.Text = puanlama.ToString();
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                }

            }
            catch (FormatException)  // Eğer harf girerse bu uyarıyı veriyor
            {
                MessageBox.Show("Lütfen Sayı Giriniz(harf veya noktalama işaretleri girme)");

            }

            catch   // genel hata yeri
            {
                MessageBox.Show("Hata var ama nedeni belli değil");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("1-80 arasında bilgisayar 20 tane random sayı alır. Sizin 1-80 arasında gireceğiniz 10 tane aynı olmayan sayıyla karşılaştırıp aynı olan sayılara puan verir. Oynun sonunda puanınızı gösterir.", "BİLGİLENDİRME", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
        }

        
            