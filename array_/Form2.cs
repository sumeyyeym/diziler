using System;
using System.Windows.Forms;

namespace array_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] arabalar = { "Mercedes", "Ferrari", "Bugatti", "Lamborghini", "Audi", "Seat", "Honda", "Alfa Romeo" };

        private void BtnSon_Click(object sender, EventArgs e)
        {
            //dizinin eleman sayısını bilmiyoruz, ancak bizden istenen son elemanı kullanıcıya göstermek...
            //arabalar.Lenght => ilgili dizinin uzunluğunu alabilirsiniz

            MessageBox.Show(arabalar[arabalar.Length - 1]); // -1 var çünkü index no her zaman eleman sayısı -1

        }

        Random rnd = new Random();
        private void BtnRastgele_Click(object sender, EventArgs e)
        {
            //Rastgele olarak dizinin bir elemanı formun tepesine yazdırılsın

            this.Text = arabalar[rnd.Next(0, arabalar.Length)];
                       
        }

        int[] sayilar = { 10, 20, 30, 40, 50 };
        int index = 0; // bunu global kısma yazdık çünkü işlem içine atarsak her seferinde başa döner ve indexi 0 olanı listeye ekler
        int toplam = 0;

        private void BtnList_Click(object sender, EventArgs e)
        {
            //listbox1.Items.Add("");
            //butona her basıldığında ilk elemandan başlayarak sırası ile dizinin tüm elemanlarını listboxa ekle. ancak eklenilen her elemanı bir havuzda toplayarak anlık olarak elemanların toplamını tepeye yazdır.

            if (index < sayilar.Length)
            {
                listBox1.Items.Add(sayilar[index]);
                toplam += sayilar[index];
                this.Text = toplam.ToString();
                index++; // bu da işlem sonunda olmalı çünkü ön sıralara yazılırsa işlem karmaşasına sebep oluyor
            }
            else
            {
                MessageBox.Show("Dizinin son elemanını eklediniz.");
            }
        }
    }
}
