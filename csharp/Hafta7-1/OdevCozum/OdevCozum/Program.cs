namespace OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region odev
            //kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayan metot 
            //ve 3.ürün almak isterse 3.ürüne %50 indirim uygulayarak metot ile kodlayınız

            //4 adet aynı isme sahip İşlem yap adlı method olacak iş yapan method bu methodların imzaları farklı olacak ve gelen parametrelere göre her biri farklı bir işlem yapacak biri çarpma biri toplama biri bölme biri metinsel değerleri birleştirme olacak.
            #endregion
            //Indirim();

            IslemYap();
            IslemYap(50, 90);

            IslemYap(900);
            IslemYap("Erkan", "Türk");

        }
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı:");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());

            if (fiyat > fiyat2)
            {
                fiyat *= 0.7;

            }
            else
            {
                fiyat2 *= 0.7;
            }
            Console.WriteLine("3. Ürünü almak istermisin (E/H) evet derseniz %50 indirim olacak 3. ürüne");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap == "E")
            {
                Indirim3(fiyat, fiyat2);
            }
            else
            {
                Console.WriteLine($"Ödeme: {fiyat + fiyat2}");
            }
        }
        static void Indirim3(double f1, double f2)
        {
            Console.WriteLine("3.Ürünün fiyatı");
            double f3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ödeme:{f1 + f2 + (f3 / 2)}");
        }

        static void IslemYap()
        {
            Console.WriteLine(20 + 30);
        }
        static void IslemYap(double s, double s2)
        {
            Console.WriteLine(s * s2);

        }
        static void IslemYap(double s)
        {
            double s1 = 2;
            Console.WriteLine(s / s1);
        }
        static void IslemYap(string metin, string metin2)
        {
            Console.WriteLine(metin+" "+metin2);
        }
    }
}
