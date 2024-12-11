namespace _01_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru1
            //Bir üniversite öğrencisi için not hesaplama sistemi yapınız.
            //Sistemin, öğrencinin derslerinin notlarını(0-100) ve her bir dersin kredi değerini alarak genel not ortalamasını(GNO) hesaplaması gerekmektedir.
            //Ders notları ve kredi değerleri için iki ayrı dizi kullanılacaktır.
            //Dizilerin içerisinde 5'er eleman olacak ve notlar array'inde 0 ile 100 arasında değer olacak.
            //Krediler dizisinde ise 3 ile 7 arasında kredi puanı olacak.
            //Sonuç olarak, öğrencinin GNO'sunu hesaplayıp ekrana yazdırınız.
            #endregion

            #region Cozum1
            //int[] notlar = { 70, 60, 50, 40, 70 };
            //int[] krediler = { 3, 5, 7, 4, 5 };

            //double toplamNotKredi = 0;
            //int toplamKredi = 0;
            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    toplamNotKredi = notlar[i] + krediler[i];
            //    toplamKredi += krediler[i];
            //}
            //double gno = toplamNotKredi / toplamKredi;
            //double yuvarlanmisGno = Math.Round(gno, 2);
            //Console.WriteLine("Ogrencinin genel not ortalaması " + yuvarlanmisGno);
            #endregion

            #region soru2
            //Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 
            #endregion
            #region Cozum2

            Random r = new Random();
            int[] dizi = new int[r.Next(10, 20)];

            int i = 0;

            while (i < dizi.Length)
            {
                int sayi = r.Next(0, 20);
                bool varMi = false;
                foreach (int item in dizi)
                {
                    if (item == sayi)
                    {
                        varMi = true;
                        break;
                    }
                }
                if (varMi == false)
                {
                    dizi[i] = sayi;
                    i++;
                }
            }
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************");

            int enBuyukEleman = dizi[0];
            int enKucukEleman = dizi[0];
           
            foreach (int item in dizi)
            {
                if (item > enBuyukEleman)
                {
                    enBuyukEleman = item;
                }
                if (item < enKucukEleman)
                {
                    enKucukEleman = item;
                }
            }
            Console.WriteLine("Dizinin En büyük elemanı: "+enBuyukEleman);
            Console.WriteLine("Dizinin En küçük elemanı: "+enKucukEleman);


            #endregion
        }
    }
}
