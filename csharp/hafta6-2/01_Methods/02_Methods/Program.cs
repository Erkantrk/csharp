namespace _02_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rastgele 1-100 arasında 15 değer tutan bir dizideki tek ve çiftleri ayrı ayrı dizilere atayan metot 
            //DiziDoldur();
            #region array örnek
            //int[] array = new int[5];
            //array[0] = 10;
            //array[1] = 11;
            //array[2] = 12;
            //array[3] = 13;
            //array[4] = 14;

            //Array.Resize(ref array, array[+ 1]);
            //Console.WriteLine();
            #endregion
        }
        static void DiziDoldur()
        {
            int[] tekSayilar = new int[0];
            int[] ciftSayilar = new int[0];
            int[] sayilar = new int[15];

            Random r = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                int sayi = r.Next(1, 100);
                sayilar[i] = sayi;
                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
                    ciftSayilar[ciftSayilar.Length - 1] = sayi;
                }
                else
                {
                    Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
                    tekSayilar[tekSayilar.Length - 1] = sayi;
                }
            }
            DiziYazdir(sayilar);
            DiziYazdir(ciftSayilar);
            DiziYazdir(tekSayilar);
        }
        static void DiziYazdir(int[] dizi)
        {
            Console.WriteLine("***************");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
