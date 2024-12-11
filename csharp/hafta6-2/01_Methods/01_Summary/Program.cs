namespace _01_Summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Summary bloklar methodları developer'lara methodun ne iş yaptığına dair bilgi vermek amacı ile kullanılır.
            //sumarry bloğu olmayan methodlarda herhangi bir açıklama gözükmez.

            Aciklamasiz();
            //sumary bloklarının içerisinde yazan açıklama olarak methodun üstüne geldiğinde ya da yazım aşamasında parantez açıldığında görülebilir.
            Aciklamali();
            Topla(20, 30);
            Console.WriteLine(FaktoriyelHesapla(4));
        }

        static void Aciklamasiz()
        {
            Console.WriteLine("Açıklamasız method");
        }
        /// <summary>
        /// Bu method ekrana "Açıklamalı method yazısı yazar"
        /// </summary>
        static void Aciklamali()
        {
            Console.WriteLine("Açıklamalı method");
        }
        /// <summary>
        /// Bu method dışarıdan gelen iki değeri toplar ve geriye dönderir
        /// </summary>
        /// <param name="sayi"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        static int Topla(int sayi, int sayi2)
        {
            return sayi + sayi2;
        }
        /// <summary>
        /// Algoritma açıklaması için <see href="https://tr.wikipedia.org/wiki/Fakt%C3%B6riyel"/> adresine bakabilirsiniz
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        static int FaktoriyelHesapla(int sayi)
        {
            if (sayi <= 1)
            {
                return sayi;
            }
            else
            {
                return sayi * FaktoriyelHesapla(sayi - 1);
            }
        }
    }
}
