namespace Lommeregner
{
    public class LommeregnerProgram
    {
        /// <summary>
        /// Opgave 7C er en konsolbaseret lommeregner, hvor brugeren kan vælge mellem flere regnefunktioner såsom addition, 
        /// subtraktion, multiplikation, division, potens, kvadratrod og procentregning. Programmet anvender en while-løkke 
        /// til at gentage menuen, validerer brugerinput og bruger en separat klasse til selve beregningerne.
        /// </summary>
        public static void RunOpgave7C()
        {

            Projektnavn beregner = new Projektnavn(); // Vi opretter et objekt af klassen Projektnavn, så vi kan bruge dens metode

            {
                bool kørProgram = true;  // Boolsk variabel til at styre om programmet skal køre videre

                while (kørProgram) // Ydre while-løkke – kører så længe brugeren ikke vælger at afslutte (valg 8)
                {
                    Console.Clear();
                    Console.WriteLine("╔═════════════════════════╗");
                    Console.WriteLine("║       Lommeregner       ║");
                    Console.WriteLine("╠═════════════════════════╣");
                    Console.WriteLine("║ 1. Addition             ║");
                    Console.WriteLine("║ 2. Subtraktion          ║");
                    Console.WriteLine("║ 3. Multiplikation       ║");
                    Console.WriteLine("║ 4. Division             ║");
                    Console.WriteLine("║ 5. Potensregning        ║");
                    Console.WriteLine("║ 6. Kvadratrod           ║");
                    Console.WriteLine("║ 7. Procentregning       ║");
                    Console.WriteLine("╠═════════════════════════╣");
                    Console.WriteLine("║ 8. Afslut programmet    ║");
                    Console.WriteLine("╚═════════════════════════╝");


                    byte valg; //Bruger byte da det bruger kun 1 byte (0-255) hukkommelse iforhold til int 4 byte. 

                    while (true)   // Indre while-løkke – sikrer at brugeren kun kan vælge gyldige menupunkter
                    {
                        Console.WriteLine("Indtast dit valg (1 - 8): ");
                        if (byte.TryParse(Console.ReadLine(), out valg) && (valg >= 1 && valg <= 8))
                        {
                            break; //Det input brugeren skrev er korrekt, så vi stopper while-løkke og går videre i programmet.
                        }

                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    }

                    // Stop programmet ved valg af 8
                    if (valg == 8)
                    {
                        Console.WriteLine("Programmet afsluttes...");
                        kørProgram = false;
                        continue;
                    }

                    double tal1 = 0;
                    double tal2 = 0;

                    // Vi spørger kun efter det nødvendige antal tal
                    if (valg == 6) // Kvadratrod
                    {
                        Console.Write("Indtast tallet: ");
                        while (!double.TryParse(Console.ReadLine(), out tal1) || tal1 < 0)
                        {
                            // Vi tjekker om input er et positivt tal
                            Console.Write("Ugyldigt input. Indtast et positivt tal: ");
                        }
                    }
                    else
                    {
                        Console.Write("Indtast det første tal: ");
                        while (!double.TryParse(Console.ReadLine(), out tal1))
                        {
                            Console.Write("Ugyldigt input. Indtast det første tal: ");
                        }

                        Console.Write("Indtast det andet tal: ");
                        while (!double.TryParse(Console.ReadLine(), out tal2))
                        {
                            Console.Write("Ugyldigt input. Indtast det andet tal: ");
                        }
                    }

                    double resultat = 0;

                    try   // TRY-CATCH bruges her for at fange fejl, fx division med nul
                    {
                        switch (valg) // SWITCH bruges til at vælge den rigtige regneoperation baseret på brugerens valg
                        {
                            case 1:
                                resultat = beregner.Add(tal1, tal2);
                                Console.WriteLine($"{tal1} + {tal2} = {resultat}");
                                break;
                            case 2:
                                resultat = beregner.Subtract(tal1, tal2);
                                Console.WriteLine($"{tal1} - {tal2} = {resultat}");
                                break;
                            case 3:
                                resultat = beregner.Multiply(tal1, tal2);
                                Console.WriteLine($"{tal1} * {tal2} = {resultat}");
                                break;
                            case 4:
                                resultat = beregner.Divide(tal1, tal2);
                                Console.WriteLine($"{tal1} / {tal2} = {resultat}");
                                break;
                            case 5:
                                resultat = beregner.Exponentiation(tal1, tal2);
                                Console.WriteLine($"{tal1} ^ {tal2} = {resultat}");
                                break;
                            case 6:
                                if (tal1 < 0)
                                {
                                    Console.WriteLine("Fejl: Du kan ikke tage kvadratroden af et negativt tal.");
                                }
                                else
                                {
                                    resultat = beregner.SquareRoot(tal1);
                                    Console.WriteLine($"Resultat: {resultat}");
                                }
                                break;
                            case 7:
                                resultat = beregner.Percentage(tal1, tal2);
                                Console.WriteLine($"{tal2}% af {tal1} er {resultat}");
                                break;
                        }
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Fejl: Du kan ikke dividere med 0.");
                    }

                    Console.WriteLine("\nTryk på en tast for at fortsætte...");
                    Console.ReadKey();
                }
            }
        }
    }
}