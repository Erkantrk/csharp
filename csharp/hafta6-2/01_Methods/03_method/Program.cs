namespace _03_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StringBirlestir("Erkan", "Türk", 132456789));

            //int[] dizi = { 20, 30, 40, 999, 50, 750, 25, 910, 3000, 2000 };
            //Console.WriteLine(EnBuyukuDeger(dizi));
            //double[] dizi2 = { 20, 30, 40, 999, 50, 750, 25, 910, 3000, 2000 };

            //Console.WriteLine(Ortalama(dizi2));

            string[] dizi = { "Erkan", "Tahsin", "Onur", "Altan" };
            string[] dizi2 = { "Kıvanç", "Kerem", "Uras", "Emre" };
            string[] dizi3 = DiziBirlestir(dizi, dizi2);
            foreach (var item in dizi3)
            {
                Console.WriteLine(item);
            }
        }
        static string StringBirlestir(string isim, string soyIsim, int numara)
        {
            return string.Format("{0}-{1}-{2}", isim, soyIsim, numara);
            //string.format kısmı bizim yazım biçimimizi formatlama işlemi yapar ve orada belirlediğimiz şekilde gösterme işlemi yapar
        }
        static int EnBuyukuDeger(int[] dizi)
        {
            return dizi.Max();
        }
        static double Ortalama(double[] ali)
        {
            return ali.Average();
        }
        static string[] DiziBirlestir(string[] dizi, string[] dizi2)
        {
            return dizi.Concat(dizi2).ToArray();
        }

    }
}
