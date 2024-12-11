using System.Threading.Channels;

namespace _04_Method
{ 
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Calis("Naber");

            Console.WriteLine("*******");
            Console.WriteLine(Deger("Naber"));





        }
      
        static void Calis(string değer)
        {
            Console.WriteLine(değer);
        }
        static string Deger(string deger)
        {
            Console.WriteLine(deger);

            string deger1 = "İyi sen";
            return deger1;
        }
    }
}
