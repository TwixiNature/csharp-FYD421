/*Skriv en klass som innehåller en statisk variabel som håller reda på hur många objekt av klassen 
som existerar för tillfället. Det ska dessutom finnas en statisk funktion som returnerar detta antal. 
Varje objekt i klassen ska även ha en instansvariabel som automatiskt tilldelas ett unikt id-nummer 
när  objektet  skapas.  Detta  id-nummer  ska  inte  kunna  ändras  efter  att  det  har  initierats.  Markera 
därför instansvariabeln som readonly. */

using System;

namespace Rainbow
{
    internal class Classy
    {
        static int nrObj = 0;
        readonly int ID;

        public Classy()
        {
            nrObj++;
            ID = nrObj;
        }

        static int returnNr() { return nrObj; }

        static void Main(string[] args)
        {
            Classy obj1 = new Classy();
            Console.WriteLine($"number of objects {returnNr()}");
            Classy obj2 = new Classy(); ;
            Console.WriteLine($"number of objects {returnNr()}");

        }
    }
}