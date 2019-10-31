using System;
using System.Windows.Forms;

namespace array_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] sehirler = { "istanbul", "edirne", "ankara", "eskişehir", "bursa", "konya", "trabzon", "eskişehir", "sivas" };
        private void BtnAclear_Click(object sender, EventArgs e)
        {
            //void. yani değer teslim etmiyo, komutu yerine getiriyo
            Array.Clear(sehirler, 0, 5); //sehirler dizisinin içerisinden 0'dan 5'e kadar olan kısmı siler
            Array.Clear(sehirler, 0, sehirler.Length); // dizi içindeki tüm verileri siler

            //parametreler hocanın dosyasında
        }

        private void BtnAcopy_Click(object sender, EventArgs e)
        {
            //array.copy: dizi içerisinden belirli bir alanı kopyalayıp almak için kullanılır. 2 farklı kullanım şekli var. 4 diye gözüküyor ama 1 ile 4, 2 ile 3 arasındaki tek fark birisinde int diğerinde long kullanılması. yani data type farkı

            string[] kopyaArray = new string[5];
            Array.Copy(sehirler, kopyaArray, 3); //2yi kullandık. sehirler içerisinden 3 eleman kopyaArray'e aktarıldı. dizideki ilk 3 elemanı aldı ve aktardı

            Array.Copy(sehirler, 2, kopyaArray, 2, 3); //3ü kullandık.

            //parametreler hocanın dosyasında
        }

        private void BtnAind_Click(object sender, EventArgs e)
        {
            //Array.IndexOf: dizi içerisinde aradığınız elemanın index değerini teslim eder. Eğer elaman var ise index değerini, yoksa -1 değerini teslim eder.-1, çünkü 0 zaten kullanımda olan bir index değeri. 6 kullanım var. 3 tanesini hoca anlattı çünkü son 3lü ilk 3lü ile benzer.
            int index = Array.IndexOf(sehirler, textBox1.Text); //1. KULLANIM ŞEKLİ. Array array, object value olmasının sebebi, array array kısmında gelecek data type'ın belii olmaması sebebiyle object value olarak belirlenmiştir. yani değişkenden kaynaklı bir bilinmemezlik eklenmiş
            
            /* 
             MessageBox.Show("Aradığınız index değeri: " + index);
             MessageBox.Show(string.Format("Aradığınız index değeri: {0}", index)); -- Süslü parantez içindeki kısım değişken. ve bu değişken indexten değerini almakta. .format bunu sağlıyo. alacak değeri 0dan başlatıyor çünkü parantez içinde 0 var
             MessageBox.Show($"Aradığınız index değeri: {index}"); -- burada ise yukarıdaki satırı daha da kısaltarak yazma şekli. indexi direkt parantez içinde alabiliyoruz

             Bunların üçü de aynı şeyin farklı yazım şekilleri.
             */

            //message box içerisinde eleman var ise "Dizi içerisinde aradığınız eleman bulunmaktadır", yok ise "Aradığınız eleman dizi içerisinde bulunmamaktadır" uyarısı versin

            //MessageBox.Show(index < 0 ? "Dizi içerisinde aradığınız eleman bulunmaktadır" : "Aradığınız eleman dizi içerisinde bulunmamaktadır");
            MessageBox.Show($"Dizi içerisinde aradığınız eleman bulun{(index < 0 ? "ma" : "")}maktadır {index}");

            //üsttekinin daha kısa yazılmış hali. süslü parantez içine normal parantez eklenmesi zorunlu. çünkü süslü parantez içerisinde tek bir değişklen olabilir. düz parantez burada işlem bütünlüğünü sağlar ve tek bir değişkenmiş gibi gösterir.

            index = Array.IndexOf(sehirler, textBox1.Text, 2); // 2. KULLANIM ŞEKLİ
            index = Array.IndexOf(sehirler, textBox1.Text, 2, 5); // 3. KULLANIM ŞEKLİ

            //PARAMETRELER HOCANIN DOSYASINDA

        }

        private void BtnAlast_Click(object sender, EventArgs e)
        {
            //Array.LastIndexOf() -- indexof ile kullanım şekilleri aynı. tek fark, indexof soldan dağa yani baştan başlayarak veri ararken last index of sondan başlar ve girilen değeri buradan buralarak indexi verir. yokarıda dizi içerisinde 2 tane eskişehir var. indexofta baştaki, yani index nosu 3 olan eskişehiri verirken last komutunda sondaki yani 7 nolu eskişehiri verir. HOCANIN DOSYASINADA BAK, FARKLI ŞEKİLDE AÇIKLADI O

            int index = Array.LastIndexOf(sehirler, textBox1.Text);
            MessageBox.Show($"Dizi içerisinde aradığınız eleman bulun{(index < 0 ? "ma" : "")}maktadır {index}");
        }

        private void BtnAresize_Click(object sender, EventArgs e)
        {
            //Array.Resize -- diziyi yeniden boyutlandırmak için kullanılır. <> içine type verebilirsin. ref anahtar kelimesi referans

            Array.Resize<string>(ref sehirler, 90); // 9 elemanlı sehirler dizisi 90 elemanlı hale gelir. stackta değil heapda değişiklik yapılmış olur çünkü ref anahtarı var. stacktaki gibi kısa dönemli değil uzun süreli değişim.

        }

        private void BtnAsort_Click(object sender, EventArgs e)
        {
            // dizi içerisinde yer alan elemanları adan zeye 0dan 9a sıralama işlemi yapar

            Array.Sort(sehirler);

        }

        private void BtnAreverse_Click(object sender, EventArgs e)
        {
            // dizi içerisideki elemanları tersine çevirir. kesinlikle sıralama YAPMAZ. zden aya değil yani. bunun için önce sort sonra reverse aypılabilir.

            Array.Reverse(sehirler);
        }
    }
}
