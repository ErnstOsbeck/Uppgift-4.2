using System;

namespace Uppgift_4._2;

class Program
{
    static void Main(string[] args)
    {
        bool avsluta = false;
        int störstHeltal = 0;
        while (avsluta != true)
        {
            Console.WriteLine("Vill du skriva ett heltal? Om inte, skriv 'n', annars skriv ditt heltal");
            string svar = Console.ReadLine();
            try
            {
                if (svar == "n")
                {
                    avsluta = true;
                }
                else if (störstHeltal < int.Parse(svar))
                {
                    störstHeltal = int.Parse(svar);
                }
            }
            catch
            {
                Console.WriteLine("Du kan endast skriva ett heltal eller 'n'");
            }
        }
        Console.WriteLine("Det störta talet du skrev in var "+störstHeltal);
        Console.Read();
    }
}