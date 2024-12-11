namespace _01_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Topla();//kendisi ile birlikte 5 aşırı yüklemesi var buna overload method tanımlama yöntemi diyoruz.
            Topla(20,40);
            Topla(20,40.5);
            Topla("toplam",20,40);
            Topla(200.5,40.9);
        }
        static void Topla()
        {

            Console.WriteLine(10 + 20);
        }
        static void Topla(int s1, int s2)//imza olarak bahsettiğimiz kısım parametrelerdir her bir parametre farklı olmalıdır.
        {
            Console.WriteLine(s1 + s2);
        }
        static void Topla(int s1, double s2)
        {
            Console.WriteLine(s1 * s2);
        }
        static void Topla(string toplam, int s1, int s2)
        {
            Console.WriteLine($"{toplam}:{s1 + s2}");
        }
        static void Topla(double s1, double s2)
        {
            Console.WriteLine(s1-s2);
        }
    }
}
