using Facturare.Lib;

namespace Facturare.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furnizor f1 = new Furnizor("Furnizor1", "ro 32284508", new Adresa("Romania", "Sibiu", "Sibiu", "Nicolae Iorga", "51"));     
            
            ConsolePrint.Print(f1);
            Console.WriteLine("");
                    
        }
    }
}