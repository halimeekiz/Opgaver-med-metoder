using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    /// <summary>
    /// Opgaven går ud på at lave et program, der modtager flere typer brugerinput, 
    /// anvender mindst én løkke og en kontrolstruktur til at behandle dataene, og derefter viser resultatet i konsollen. 
    /// Programmet skal kunne startes fra hovedmenuen i Opgave 7.
    /// </summary>
    public class Opgave7b
    {
        public static void RunOpgave7b()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║       Talomregning: Decimal / Hex / Bin    ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            Console.Write("Indtast et heltal: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int tal))
            {
                Console.WriteLine("Ugyldigt. Indtast et gyldigt heltal.");
                Console.WriteLine("Tryk Enter for at prøve igen...");
                Console.ReadLine();
                RunOpgave7b(); // prøver igen
                return;
            }

            // Kalder metoderne og får returværdier
            string hex = TilHex(tal);
            string bin = TilBinær(tal);

            // Udskriv resultater
            Console.WriteLine($"\nDecimal     : {tal}");
            Console.WriteLine($"Hexadecimal   : {hex}");
            Console.WriteLine($"Binær         : {bin}");
        }

        // Metode til hexadecimal
        public static string TilHex(int tal)
        {
            return tal.ToString("X"); 
        }

        // Metode til binær
        public static string TilBinær(int tal)
        {
            return Convert.ToString(tal, 2);
        }
    }
}
