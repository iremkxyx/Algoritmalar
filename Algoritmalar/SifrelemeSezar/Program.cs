namespace Sifreleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifrelenecek kelimeyi gir:");
            string kelime = Console.ReadLine();

            Console.WriteLine("Frekans gir:");
            int frekans = int.Parse(Console.ReadLine());

            string sifrelenmisKelime = null;

            for (int i = 0; i < kelime.Length; i++)
            {
                sifrelenmisKelime += Convert.ToChar(kelime[i] + frekans);

            }



            Console.WriteLine(sifrelenmisKelime);
            Console.ReadLine();
        }
    }
}
