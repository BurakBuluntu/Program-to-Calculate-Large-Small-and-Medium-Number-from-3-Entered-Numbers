using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enb, enk, orta;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);

            if (sayi1 >= sayi2)
            {
                if (sayi1 >= sayi3)
                {
                    enb = sayi1;
                    if (sayi2 >= sayi3)
                    {
                        orta = sayi2;
                        enk = sayi3;
                    }
                    else
                    {
                        orta = sayi3;
                        enk = sayi2;
                    }
                }
                else
                {
                    orta = sayi1;
                    enb = sayi3;
                    enk = sayi2;
                }
            }
            else
            {
                if (sayi2 >= sayi3)
                {
                    enb = sayi2;
                    if (sayi1 >= sayi3)
                    {
                        orta = sayi1;
                        enk = sayi3;
                    }
                    else
                    {
                        enk = sayi1;
                        orta = sayi3;
                    }
                }
                else
                {
                    enb = sayi3;
                    enk = sayi1;
                    orta = sayi2;
                }
            }

            if (enb == orta && enb == enk && orta == enb && orta == enk && enk == enb && enk == orta)
            {
                MessageBox.Show("Bütün Sayılar Birbirine Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
            }
            else
            {
                if (enb == orta)
                {
                    MessageBox.Show("En Büyük ve Ortanca Sayı Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
                else if (enb == enk)
                {
                    MessageBox.Show("En Büyük ve En Küçük Sayı Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
                else if (orta == enk)
                {
                    MessageBox.Show("Ortanca ve Enküçük Sayı Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
                else if (orta == enb)
                {
                    MessageBox.Show("Ortanca ve En Büyük Sayı Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
                else if (enk == orta)
                {
                    MessageBox.Show("En Küçük ve Ortanca Sayı Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
                else if (enk == enb)
                {
                    MessageBox.Show("En Küçük ve En Büyük Sayı Eşit - En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
                else
                {
                    MessageBox.Show("En Buyuk " + enb + ", Orta " + orta + ", En Kucuk " + enk);
                }
            }
            
        }







        /*
        int s1, s2, s3, buyuk, kucuk;

        s1 = Convert.ToInt32(textBox1.Text);
        s2 = Convert.ToInt32(textBox2.Text);
        s3 = Convert.ToInt32(textBox3.Text);


        if (s1 > s2 && s1 > s3)
            buyuk = s1;
        else if (s2 > s3)
            buyuk = s2;
        else
            buyuk = s3;

        if (s1 < s2 && s1 < s3)
            kucuk = s1;
        else if (s2 < s3)
            kucuk = s2;
        else
            kucuk = s3;


        MessageBox.Show("en büyük ile en küçük toplamı=" + Convert.ToString(kucuk) + " - " + Convert.ToString(buyuk));
    */
       
    }
}