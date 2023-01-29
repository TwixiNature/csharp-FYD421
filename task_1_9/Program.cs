/*Skriv ett program som tar längden av ett år (antalet dagar som ett decimaltal) för en fiktiv planet 
som  indata.  Det  skall  producera  en  skottårsregel  som  minimerar  skillnaden  mellan  år  med  hela 
dagar och planetens omloppstid. Programmet skall även ange hur mycket de båda kommer att vara 
ur  fas  på  10  000  år.  Exempel:  jordens  år  har  ungefär  365.25  dagar  (Juliansk  kalender). 
Skottårsregeln är att vi har en cykel på fyra år, varav tre med 365 dagar och ett skottår med 366 
dagar.*/



// -------------- EJ KLAR --------------


using Microsoft.VisualBasic;
using System;
using static UserInputFunctions.UserInputFunctions;

namespace space
{
    internal class Planet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have created a new planet");
            double days = tryReadDouble("How many days for a trip around the sun?"); // get number of days in clendar

            double diff = days % 1; // decimals

            diff = Math.Round(diff, 1);

            double leap = 1 / diff; 


            // Leap year rule
            Console.WriteLine($"leap year every {Math.Round(leap)} years");
            Console.WriteLine();

            //calculating drift
            Console.WriteLine("Drift over 10 000 years");
            Console.WriteLine("For Earth...");
            Console.WriteLine($"Planetary movement = {365.25 * 10000} days");
            Console.WriteLine($"according to calendar with leap year= {365 * 10000 + 10000/4}");
            Console.WriteLine();
            Console.WriteLine("For your planet...");
            Console.WriteLine($"Planetary movement = {days * 10000} days");
            //Console.WriteLine($"according to calendar with leap year= {(int)days * 10000 + 10000 / minplace}");

        }




    }
}

