namespace _01_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IslemYap();
            int[] dizi = { 90, 20, 30, 40, 50, 60, 70, 10,1,3,5,8 };
            Dizi(dizi);
        }
        static void IslemYap()
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());


            int[] dizi = new int[sayi];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine("Lütfen 2. sayıyı giriniz");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void Dizi(int[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }


    }
}
