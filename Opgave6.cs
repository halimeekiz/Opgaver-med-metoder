using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    /*  Gæt et tal-spil:
        Lav et program, der simulerer et klassisk "gæt et tal"-spil. 
        Programmet skal generere et tilfældigt tal mellem 1 og 25. Brugeren skal have op til 5 forsøg på at gætte tallet. 
        Opret flere metoder til spillet:
          • En metode til at generere det tilfældige tal.
          • En metode til at tjekke, om brugerens gæt er korrekt.
          • En metode, der informerer brugeren, om gættet er for højt eller for lavt.
        Hvis brugeren gætter rigtigt, skal spillet afsluttes med en besked, der fortæller, at de har vundet. 
        Hvis de løber tør for forsøg, skal spillet afslutte med en taberbesked. */
        public class Opgave6
        {
            public static void RunOpgave6()
            {
                int tilfældigtTal = GenererTilfældigtTal();
                int antalForsøg = 5;
                bool gættetRigtigt = false;

                Console.WriteLine("Velkommen til 'Gæt et tal'-spillet!");
                Console.WriteLine("Gæt et tal mellem 1 og 25.");
                Console.WriteLine($"Du har {antalForsøg} forsøg til at gætte det rigtige tal.\n");

                for (int i = 0; i < antalForsøg; i++)
                {
                    Console.Write($"Forsøg {i + 1}: Indtast dit gæt: ");
                    if (int.TryParse(Console.ReadLine(), out int brugerGæt))
                    {
                        if (TjekGæt(brugerGæt, tilfældigtTal))
                        {
                            Console.WriteLine("Tillykke! Du gættede rigtigt!");
                            gættetRigtigt = true;
                            break;
                        }
                        else
                        {
                            InfoOmResultat(brugerGæt, tilfældigtTal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt input. Prøv igen.");
                    }
                }

                if (!gættetRigtigt)
                {
                    Console.WriteLine($"\nDu har tabt! Det rigtige tal var {tilfældigtTal}.");
                }
            }

            public static int GenererTilfældigtTal()
            {
                Random random = new Random();
                return random.Next(1, 26);
            }

            public static bool TjekGæt(int gæt, int rigtigtTal)
            {
                return gæt == rigtigtTal;
            }

            public static void InfoOmResultat(int gæt, int rigtigtTal)
            {
                if (gæt < rigtigtTal)
                {
                    Console.WriteLine("Dit gæt er for lavt.\n");
                }
                else
                {
                    Console.WriteLine("Dit gæt er for højt.\n");
                }
            }
        }
    }
