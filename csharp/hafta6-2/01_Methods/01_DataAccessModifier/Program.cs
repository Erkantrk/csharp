namespace _01_DataAccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataAccessModifiers: Tanımlanan yapıların erişilebilirliğini tanımlar.
            /*
                *public Solution altındaki bütün projelerin ve proje altındaki tanımların hepsine erişime açık bir şekilde gelir.
                *internal:Kendi tanımlı olduğu proje altındaki erişime açık demektir.
                *private:kendi tanımlı olduğu class altında erişime açık demektir. Bir erişim belirleyici verilmezse yapı default olarak private dır.
                *protected:Sadece miras alınan  classlardan erişime açılır.
                *sealed:Mühürlü bir yapıdır sadece sınıf özelinde kullanılır.

                Static:Farklı classta tanımlanan methodun class adı üzerinden direkt erişilerek çağrılmasını sağlar static bir class içinde static methodlar kullanılır.
            
                
            */
            //Console.WriteLine();//static bir method'dur.
            //Random random = new Random();
            //random.Next(10, 20);//nonstatic bir method'dur.

            Matematik matematik = new Matematik();

            matematik.NonStaticYaz();//nonstatic
            Matematik.Yaz();//static
        }

    }
    class Matematik
    {
        internal static void Yaz()
        {
            Console.WriteLine("Hello World");
        }
        internal void NonStaticYaz()
        {
            Console.WriteLine("Nonstatic bir method");
        }
    }
}
