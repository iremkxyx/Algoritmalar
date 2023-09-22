namespace SifreKirmaSezar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Şifrelenmiş kelimeyi gir:");
            string sifreKelime = Console.ReadLine();
            string sifrelenmisKelime = sifreKelime.ToLower();
            string cozumlenmisKelime = "";
            int sayac = 0;

            bool durum = true;

            while (durum)
            {
                cozumlenmisKelime = null;

                for(int i = 0; i < sifrelenmisKelime.Length; i++)
                {
                    if (sifrelenmisKelime[i] - sayac >0 &&
                        sifrelenmisKelime[i] - sayac <127 )
                    {
                        cozumlenmisKelime += Convert.ToChar(sifrelenmisKelime[i] - sayac);
                    }
                }

                sayac++;
                Console.WriteLine(cozumlenmisKelime);

                if( sayac == 70)
                {
                    durum= false;
                }

            }

            Console.ReadLine();

        }
    }
}