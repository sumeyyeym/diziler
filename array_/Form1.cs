using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // array - dizi
        // birden fazla aynı tiptekideğerleri bir arada tutmak

        private void BtnDizi_Click(object sender, EventArgs e)
        {
            // 1. tanımlama yöntemi: veriTipi [] diziAdi = new veriTipi [Eleman sayısı (yani dizi kaç elemanlı bir dizi olacak)]

            int[] sayilar = new int[5];
            sayilar[4] = 10; //değer atar
            sayilar[1] = 20;
            sayilar[0] = 30;
            sayilar[2] = 40;
            sayilar[3] = 50;
            //sayilar [5] = 60 yazarsak dizinin dışında hatası verir

            /*index numarası 0 = 30
                             1 = 20
                             2 = 40
                             3 = 50
                             4 = 10*/
            //eleman sayısı: 1,2,3,4,5 -- index sayısı: 0,1,2,3,4 -- SQLde index 1 ile başlar. burada ise 0 ile

            //2. tanımlama yöntemi: veriTipi [] diziAdi = new veriTipi[eleman sayısı]{dizinin elemanları (yeni elaman geldikçe , ile ayır)}
            string[] sehirler = new string[5] { "ankara", "edirne", "istanbul", "bursa", "tekirdağ" };
            string sehir = sehirler[4]; // index nosu 4 olan değeri gösterir. yani tekirdağ. çünkü sıralamaya göre 0dan 4e no ataması yapar

            // string, reference type'dır ve RAMin heap kısmındadır. diğer veri tipleri value type. ve RAMde stack kısmındadır.

            //3. tanımlama yöntemi: veriTipi [] diziAdi = {dezinin elemanlar (,)}
            char[] karakterler = { 'a', 'A', 'b', 'B' };
            // burada eleman sayısı atamadan istediğin kadar çoğaltıyorsun. diğerlerinde verdiğin sayıdan daha fazla veri atayamazsın
            karakterler[0] = 'c';
            karakterler[1] = 'C'; // 0 ve 1 indexli değerleri değiştirir

            char gelen = karakterler[0]; //yeni bir veriye önceki veriden değer aktarma


        }
    }
}
