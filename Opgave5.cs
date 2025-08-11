using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    /* Opdeling af komma-separeret streng
       Lav et program, hvor brugeren indtaster en enkelt streng med værdier adskilt af kommaer. 
       Opret en metode, der modtager denne streng, splitter den op i et array af værdier, og returnerer arrayet. 
       I Main-metoden skal du udskrive størrelsen på arrayet og bruge en for-løkketil at udskrive hver værdi i arrayet */
    public class Opgave5
    {
        public static void RunOpgave5()
        {

            // Instruktion til brugeren
            Console.WriteLine("Indtast dine oplysninger adskilt af komma i denne rækkefølge:");
            Console.WriteLine("Fornavn, Efternavn, Alder");
            Console.WriteLine("Eksempel: Anna,Hansen,25");
            string input = Console.ReadLine();

            string[] result = SplitString(input);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Værdi {i + 1}: {result[i]}");
            }
        }
        static string[] SplitString(string tekst)
        {
            return tekst.Split(',');
        }

    }
}
