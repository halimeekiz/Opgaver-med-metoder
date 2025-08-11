namespace OpgaveSætMetoder
{

    public class Opgave7
    {
        public static void RunOpgave7()
        {
            bool kørMenu = true;

            while (kørMenu)
            {
                Console.Clear();
                Console.WriteLine("╔═════════════════════════════════════════════════╗");
                Console.WriteLine("║               Opgaver med metoder               ║");
                Console.WriteLine("╠═════════════════════════════════════════════════╣");
                Console.WriteLine("║  1. Returnering af en streng                    ║");
                Console.WriteLine("║  2. Udskrivning af brugerinput                  ║");
                Console.WriteLine("║  3. Sum, Subtraktion, Multiplikation & Division ║");
                Console.WriteLine("║  4. Navn og alder med gruppeinddeling           ║");
                Console.WriteLine("║  5. Opdeling af komma-separeret streng          ║");
                Console.WriteLine("║  6. Gæt et tal-spil                             ║");
                Console.WriteLine("║  7. Opgave 7a - Temperatur                      ║");
                Console.WriteLine("║  8. Opgave 7b - Decimal, Hexadecimal & Binær    ║");
                Console.WriteLine("║  9. Opgave 7c - Kontrolstruktur                 ║");
                Console.WriteLine("╠═════════════════════════════════════════════════╣");
                Console.WriteLine("║  10. Afslut program                             ║");
                Console.WriteLine("╚═════════════════════════════════════════════════╝");
                Console.Write("\nVælg en mulighed (1-10): ");
                string? valg = Console.ReadLine()?.Trim();

                Console.Clear();
                switch (valg)
                {
                    case "1":
                        Console.WriteLine(Opgave1.RunOpgave1());
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "2":
                        Opgave2.RunOpgave2();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "3":
                        Opgave3.Vis();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "4":
                        Opgave4.RunOpgave4();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "5":
                        Opgave5.RunOpgave5();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "6":
                        Opgave6.RunOpgave6();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "7":
                        Opgave7A.RunOpgave7A();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "8":
                        Opgave7b.RunOpgave7b();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "9":
                        Lommeregner.LommeregnerProgram.RunOpgave7C();
                        TilbageEllerAfslut(ref kørMenu);
                        break;
                    case "10":
                        Console.WriteLine("Programmet afsluttes...");
                        kørMenu = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg! Prøv igen.");
                        break;
                }
            }
        }

        // Metode der giver brugeren valget efter hver opgave
        private static void TilbageEllerAfslut(ref bool kørMenu)
        {
            string? svar = "";

            while (svar != "m" && svar != "0")
            {
                Console.Write("Tryk 'm' for menu eller '0' for at afslutte: ");
                svar = Console.ReadLine()?.Trim().ToLower();

                if (svar != "m" && svar != "0")
                {
                    Console.WriteLine("Ugyldigt valg! Prøv igen.\n");
                }
            }

            if (svar == "m")
            {
                Console.WriteLine("Vender tilbage til menuen...");
                // Ingen pause – menuen vises straks igen
            }
            else if (svar == "0")
            {
                Console.WriteLine("Programmet afsluttes...");
                Environment.Exit(0); // Lukker hele programmet
            }
        }

    }
}
