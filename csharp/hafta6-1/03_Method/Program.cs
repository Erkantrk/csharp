namespace _03_Method
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Bir sayı giriniz");
            //double s = Convert.ToDouble(Console.ReadLine());
            //KdvUygula(s);
            //Console.WriteLine(GeriyeDegerDonduren());
            //Console.WriteLine("*************");
            //double sayi = GeriyeDegerDonduren();
            //Console.WriteLine(sayi);
            double sayi= ParametreliGeriyeDegerDonduren(20, 40);
            Console.WriteLine(sayi);

        }
        static void KdvUygula(double s)
        {
            double kdv = s * 1.20;
            Console.WriteLine(kdv);
        }

        static double GeriyeDegerDonduren()//Parametresiz geriye değer döndüren method.
        {
            double sayi = 25.5;
            return sayi;
        }
        static double ParametreliGeriyeDegerDonduren(double s, double s2)//Parametreli geiye değer döndüren method.
        {
            return s + s2;

        }


    }
}
