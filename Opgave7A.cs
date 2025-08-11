using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveSætMetoder
{
    public class Opgave7A
    {
        public static void RunOpgave7A()
        {
            Console.WriteLine("╔═════════════════════════════════════════════════╗");
            Console.WriteLine("║           Temperaturkonvertering                ║");
            Console.WriteLine("║                    C/F                          ║");
            Console.WriteLine("╚═════════════════════════════════════════════════╝");

            //Bruger indtaster temperatur
            Console.Write("Indtast en temperatur: eks. 26.7 eller 100,3 ");
            string? input = Console.ReadLine();

            /* Forsøger at konvertere brugerens input til et flydende tal (double).
               Udskifter komma med punktum for at sikre korrekt decimaltegn ved brug af InvariantCulture,
               som kun accepterer punktum (.) som decimal.
               NumberStyles.Float tillader fortegn, decimaler, eksponent og mellemrum omkring tallet.
               Hvis konverteringen fejler (dvs. input ikke er et gyldigt tal), går vi ind i if-blokken. */
            if (!double.TryParse(input?.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double temperatur))

            {
                Console.WriteLine("Ugyldigt input. Prøv igen.");
                Console.WriteLine("Tryk Enter for, at prøve igen! ");
                Console.ReadLine();
                Console.Clear();
                RunOpgave7A(); // starter programmet forfra
                return;
            }
            //Bruger indtaster enhed
            Console.Write("Indtast temperaturens enhed (C for Celsius, F for Fahrenheit): ");
            string? enhed = Console.ReadLine()?.Trim().ToUpper();

            if (enhed == "C")
            {
                KonverterFraCelsius(temperatur);
            }
            else if (enhed == "F")
            {
                KonverterFraFahrenheit(temperatur);
            }
            else
            {
                Console.WriteLine("Ugyldig enhed. Brug 'C' for Celsius eller 'F' for Fahrenheit.");
                Console.WriteLine("Tryk Enter for at prøve igen!");
                Console.ReadLine();
                Console.Clear();
                RunOpgave7A(); // starter programmet forfra
                return;

            }

        }

        // ÆNDRING: navn matcher kaldet + void (vi printer bare)
        public static void KonverterFraCelsius(double temperatur)
        {
            double fahrenheit = (temperatur * 9.0 / 5.0) + 32.0;
            double kelvin = temperatur + 273.15;
            double reaumur = temperatur * 4.0 / 5.0;

            Console.WriteLine($"Temperaturen i Fahrenheit: {fahrenheit:F2}°F");
            Console.WriteLine($"Temperaturen i Kelvin: {kelvin:F2}K");
            Console.WriteLine($"Temperaturen i Réaumur: {reaumur:F2}°Re");
        }

        // ÆNDRING: void og kun print
        public static void KonverterFraFahrenheit(double temperatur)
        {
            double celsius = (temperatur - 32.0) * 5.0 / 9.0;
            double kelvin = celsius + 273.15;
            double reaumur = celsius * 4.0 / 5.0;

            Console.WriteLine($"Temperaturen i Celsius: {celsius:F2}°C");
            Console.WriteLine($"Temperaturen i Kelvin: {kelvin:F2}K");
            Console.WriteLine($"Temperaturen i Réaumur: {reaumur:F2}°Re");
        }
    }
}