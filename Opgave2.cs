using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    public class Opgave2
    {
        /* Opgave 2: Udskrivning af brugerinput: 
           Lav et program, hvor brugeren kan indtaste en tekststreng som input. 
           Derefter skal du oprette en metode, der modtager denne streng som parameter 
           og udskriver den i konsollen. Metoden skal kaldes fra Main-metoden. */

        public static void RunOpgave2()
        {
            Console.Write("Indtast dit fulde navn: ");
            string? fuldeNavn = Console.ReadLine();
            UdskrivTekst(fuldeNavn);
        }

        public static void UdskrivTekst(string fuldeNavn)
        {
            Console.WriteLine("Du hedder: " + fuldeNavn);
        }
    }
}
