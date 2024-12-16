namespace Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //params Anahtar kelimesi(keyword) bir methoda değişken sayıda argümanın aynı tipte geçirilmesine olanak tanır.
            //Params oarametresi methodun son parametresi olarak tanımlanmalıdır ve yalnızca params anahtar kelimesi kullanılabilir.
            //params ile belirtilen parametre bir dizi olarak işlenir bu da metod içinde bir dizi erişilebileceği ve üzerinde işlem yapılabileceği anlamına gelir.
            //int[] sayilar = { 10, 20, 30, 40 };
            //DiziYazdir(sayilar);
            //Diziyazdir2(20,40,"Merhaba",true,20.5,DateTime.Now,'A',20);

            DiziYazdir3("Sayı Elemanları",80,90,90,50,40,66,44);
        }
        static void DiziYazdir(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void Diziyazdir2(int sayi, int sayi2, params object[] obje)
        {
            foreach (var item in obje)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sayi + " " + sayi2);
        }
        static void DiziYazdir3(string metin ,params int[] parametre)
        {
            Console.WriteLine(metin);
            foreach (var item in parametre)
            {
               Console.WriteLine(item);
            }
           
        }
    }
}
