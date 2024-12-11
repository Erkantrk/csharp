using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace _01_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methot Tanımı
            /*METHODS - FONKSİYONLAR


             Metotlar: Yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod yapılarıdır.Metoda bir isim verilir ve o isim altında bir iş yapar kod bloğu yazılır ve yazılımcı o işi yapmak için kod bloğunu yazmak yerine metodu ismini yazarak çağırır.Çağrılan metot kendi içindeki kod bloğunu çalıştırır.Bu sayede yazılımcı tanımlı işin kodunu defalarca yazmaktan kurtulur.

             Metotlar ve Fonksiyonlar() ile tanımlanır.
             Metotlar iç içe TANIMLANAMAZLAR.
             Metotlar çağrılmadığı sürece bir işlem yapmazlar.
             Metotlar UNIQUE(benzersiz) olmalıdır.Aynı isme sahip metotların, metot imzaları farklı olmalıdır.(parametre sayısı, parametre veri tipi)

             Fonksiyonlar ise yazılımcının kendisinin oluşturduğu metotlardır.

             Metotlar 2'ye ayrılır.

             * Değer Döndüren(parametreli / parametresiz)
             * Değer Döndürmeyen(parametreli / parametresiz)


             Parametre: metot parantezleri içerisine yazılan ve metodu kullanırken gönderilecek verilerdir.



              */
            #endregion

            #region methods
            //Yaz();

            //Console.WriteLine("****************");

            //IsimYaz("Erkan");//yöntem 1
            // string ad = Console.ReadLine(); ;
            //IsimYaz(ad);//yöntem2
            //int sayi = 10;
            //double sayi2 = 20.5;
            //Topla(20,20.50);//parametrelerde Hangi yapı ne türde ise ona göre değer vermeliyiz yerleri methodaki ile aynı olmalıdır.
            //Topla(sayi, sayi2);//Yöntem 2
            #endregion

            #region 
            // 4 adet iş yapan method yazın ve bu methodlar biri toplama biri bölme biri çıkarma biri çarpma işlemi yapsın
            Topla(20,30);
            Carp(15,25);
            Cikart(70,40);
            Bol(200,2.5);
            #endregion
        }
        static void Yaz()//parametresiz iş yapan method geriye değer döndermeyen method.
        {
            Console.WriteLine("Erkan Türk");
        }
        static void IsimYaz(string ad)
        {
            Console.WriteLine(ad);
        }
        static void Topla(int s1, double s2)
        {
            Console.WriteLine(s1 + s2);
        }
        static void Carp(int s, int s1)
        {
            Console.WriteLine(s * s1);
        }
        static void Cikart(int i, int a)
        {
            Console.WriteLine(i - a);
        }
        static void Bol(double s, double s1)
        {
            try
            {
                Console.WriteLine(s / s1);
            }
            catch (Exception e)
            {

                Console.WriteLine("Sıfıra bölünme hatası "+e.Message);
            }
            if (s1 == 0)
            {
                Console.WriteLine("Sıfıra bölünme hatası");
            }
            else
            {
                Console.WriteLine(s/s1);
            }
        }
    }
}
