/*Skriv en klass som innehåller en statisk variabel som håller reda på hur många objekt av klassen 
som existerar för tillfället. Det ska dessutom finnas en statisk funktion som returnerar detta antal. 
Varje objekt i klassen ska även ha en instansvariabel som automatiskt tilldelas ett unikt id-nummer 
när  objektet  skapas.  Detta  id-nummer  ska  inte  kunna  ändras  efter  att  det  har  initierats.  Markera 
därför instansvariabeln som readonly. */

using System;

//can you not make an instance of the class you have main in?

namespace Learning
{
    internal class Classtest
    {
        static int nrObj = 0;
        readonly int ID;

        public Classtest()
        {
            nrObj++;
            ID = nrObj;
        }

        public static int returnNr() { return nrObj; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Classtest obj1 = new Classtest();
            Console.WriteLine($"number of objects {Classtest.returnNr()}");
            Classtest obj2 = new Classtest(); ;
            Console.WriteLine($"number of objects {Classtest.returnNr()}");

        }
    }

}