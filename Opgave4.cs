using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    /*  Navn og alder med gruppeinddeling:
        Lav et program, hvor brugeren kan indtaste et navn og en alder. 
        Opret en metode, der modtager disse input, og tjekker alderen for at bestemme, hvilken gruppe
        brugeren tilhører, baseret på følgende aldersintervaller:
         •  0-1 år: Du er nyfødt
         •  2-3 år: Du er i dagpleje eller vuggestue
         •  4-5 år: Du er i børnehave
         •  6-18 år: Du går i skole 
         •  19 år og opefter: Nu begynder livet at blive alvor 
        Metoden skal returnere en streng, som kombinerer navnet og en passende besked baseret på aldersgruppen, og denne besked skal derefter udskrives i konsollen */
    public class Opgave4
    {
        public static void RunOpgave4()
        {

            Console.Write("Indtast dit navn: ");
            string? navn = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(navn))
            {
                Console.WriteLine("Navn kan ikke være tomt.");
                return;
            }

            Console.Write("Indtast din alder: ");
            int tal1 = int.Parse(Console.ReadLine());
            if (tal1 < 0)
            {
                Console.WriteLine("Alder kan ikke være negativ.");
                return;
            }
            string besked = BestemAldersgruppe(navn, tal1);
            Console.WriteLine(besked);

        }
        public static string BestemAldersgruppe(string navn, int alder)
        {
            if (alder <= 1)
            {
                return $"{navn}, du er nyfødt.";
            }
            else if (alder <= 3)
            {
                return $"{navn}, du er i dagpleje eller vuggestue.";
            }
            else if (alder <= 5)
            {
                return $"{navn}, du er i børnehave.";
            }
            else if (alder <= 18)
            {
                return $"{navn}, du går i skole.";
            }
            else
            {
                return $"{navn}, nu begynder livet at blive alvor.";
            }
        }

    }
}
