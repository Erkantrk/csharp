namespace OptionalAndNamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Optional Parameters:İsteğe bağlı parametreler, methodun çağrılması sırasında belirtilmesi zorunlu olmaya parametrelerdir.
            //Bu parametreler method tanımında varsayılan değerler alır. Eğer bu method cağrılırken parametre için bir değer sağlanmazsa varsayılan değer kullanılır.
            //UrunYazdir("Msı", 20000);
            //Console.WriteLine("Opsiyonel ile arasındaki fark");
            //Console.WriteLine("*********************");
            //UrunYazdir("Logitech", 5000, "Klavye");

            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tcniz");
            string tc = Console.ReadLine();
            Console.WriteLine("Mesleğiniz");
            string meslek = Console.ReadLine();
            Console.WriteLine("Yaşadığınız Ülke");
            string ulke = Console.ReadLine();
            Console.WriteLine("Cinsiyetiniz");
            string cinsiyet = Console.ReadLine();
            //string.IsNullOrEmpty bir metinin boş mu yoksa null mu olduğunu kontrol eder ve bize true veya false değer dönderir.
            if (cinsiyet=="" || string.IsNullOrEmpty(ulke) || string.IsNullOrEmpty(meslek))
            {
                Insan(ad, yas, tc);
            }
            else
            {
                Insan(ad, yas, tc, meslek, ulke, cinsiyet);
            }


        }
        static void UrunYazdir(string adi, double fiyat, string kategory = "Bilgisayar")
        {
            Console.WriteLine("Ürün Adı: {0}\nÜrün Fiyatı: {1}\nKategorisi: {2}", adi, fiyat, kategory);
        }
        static void Insan(string ad, int yas, string tc, string meslek = "Serbes Meslek", string ulke = "Türkiye", string cinsiyet = "Belirtmek istemiyor.")
        {
            Console.WriteLine($"Ad: {ad}, Yaş: {yas}, Tc: {tc}, Mesleği: {meslek}, Ulkesi: {ulke},Cinsiyeti: {cinsiyet}  ");
        }
    }
}
