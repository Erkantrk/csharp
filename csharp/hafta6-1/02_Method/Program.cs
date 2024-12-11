namespace _02_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir işlem türü giriniz(+,-,*,/)");
            char islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                Topla(sayi, sayi2);
            }
            else if (islem == '-')
            {
                Cikart(sayi, sayi2);
            }
            else if (islem == '*')
            {
                Carp(sayi, sayi2);
            }
            else if (islem == '/')
            {
                Bol(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı işlem");
            }
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
            
            if (s1 == 0)
            {
                Console.WriteLine("Sıfıra bölünme hatası");
            }
            else
            {
                Console.WriteLine(s / s1);
            }
        }
    }
}
