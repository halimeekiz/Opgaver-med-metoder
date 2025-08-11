using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    public class Opgave3
    {
        /* Opgave 3: Summen af tre tal:
           Lav et program, hvor brugeren kan indtaste tre tal. Opret en metode, 
           der tager imod de tre tal som parametre, lægger dem sammen, og returnerer summen. 
           Summen skal derefter udskrives i konsollen via Console.WriteLine(). */

        public static void RunOpgave3()
        {
            Console.Write("Indtast første tal: ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.Write("Indtast tredje tal: ");
            int tal3 = int.Parse(Console.ReadLine());

            int sum = BeregnSum(tal1, tal2, tal3);
            Console.WriteLine("Summen af tallene er: " + sum);
        }

        public static int BeregnSum(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

        /* Opgave 3a:
           Dette program skal være en udvidelse af Opgave 3. I stedet for at lægge de tre tal sammen, 
           skal metoden trække de tre tal fra hinanden og returnere resultatet, som derefter skal udskrives i konsollen. */

        public static void RunOpgave3a()
        {
            Console.Write("Indtast første tal: ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.Write("Indtast tredje tal: ");
            int tal3 = int.Parse(Console.ReadLine());

            int resultat = TrækFra(tal1, tal2, tal3);
            Console.WriteLine("Resultatet af fratrækningen er: " + resultat);
        }

        public static int TrækFra(int tal1, int tal2, int tal3)
        {
            return tal1 - tal2 - tal3;
        }

        /*  Multiplikation af tre talUdvid Opgave 3 ved at oprette en metode, der modtager tre tal som input,
            ganger dem sammen, og returnerer resultatet. Resultatet skal derefter udskrives i konsollen */
        public static void RunOpgave3b()
        {
            Console.Write("Indtast første tal: ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast andet tal: ");
            int tal2 = int.Parse(Console.ReadLine());

            Console.Write("Indtast tredje tal: ");
            int tal3 = int.Parse(Console.ReadLine());

            int resultat = Multiplicer(tal1, tal2, tal3);
            Console.WriteLine("Resultatet af multiplikationen er: " + resultat);
        }

        public static int Multiplicer(int tal1, int tal2, int tal3)
        {
            return tal1 * tal2 * tal3;
        }

        /* Summen af to tal divideret med et tredje Lav et program, der modtager tre tal som input fra brugeren.
           Opret en metode, der lægger de to første tal sammen og derefter dividerer summen med det tredje tal. 
           Resultatet skal returneres og udskrives i konsollen.*/
        public static void RunOpgave4()
        {
            Console.WriteLine("Lægge de to første tal sammen");
            Console.Write("Indtast første tal: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast andet tal: ");
            int tal2 = int.Parse(Console.ReadLine());

            int sum = tal1 + tal2;

            Console.WriteLine("Dividere summen med det tredje tal.");
            Console.Write("Indtast tredje tal: ");
            int tal3 = int.Parse(Console.ReadLine());

            if (tal3 == 0)
            {
                Console.WriteLine("Division med nul er ikke tilladt.");
                return;
            }
            double resultat = Divider(sum, tal3);
        }

        public static double Divider(int sum, int tal3)
        {
            return (double)sum / tal3;
        }


        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║            Opgave 3                ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 3                       ║");
            Console.WriteLine("║  2. Opgave 3a                      ║");
            Console.WriteLine("║  3. Opgave 3b                      ║");
            Console.WriteLine("║  4. Opgave 3c                      ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("Vælg (1-4): ");
            string? valg = Console.ReadLine();

            Console.Clear();

            switch (valg)
            {
                case "1":
                    RunOpgave3();
                    break;
                case "2":
                    RunOpgave3a();
                    break;
                case "3":
                    RunOpgave3b();
                    break;
                case "4":
                    RunOpgave4();
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }
    }
}
