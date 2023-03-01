/*Skriv en klass som innehåller en statisk variabel som håller reda på hur många objekt av klassen 
som existerar för tillfället. Det ska dessutom finnas en statisk funktion som returnerar detta antal. 
Varje objekt i klassen ska även ha en instansvariabel som automatiskt tilldelas ett unikt id-nummer 
när  objektet  skapas.  Detta  id-nummer  ska  inte  kunna  ändras  efter  att  det  har  initierats.  Markera 
därför instansvariabeln som readonly. */

using System;
using System.Runtime.CompilerServices;

//can you not make an instance of the class you have main in?

namespace Learning
{
    internal class Classtest
    {
        static int nrObj = 0; //static variable 
        readonly int ID; // id for objects

        public Classtest() // constructor
        {
            ID = nrObj++; // increase static variable and give id to object
        }

        public static int returnNr() { return nrObj; } // return id

        public int getID() { return this.ID; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Classtest obj1 = new Classtest(); // create first object
            Console.WriteLine($"number of objects {Classtest.returnNr()} With ID {obj1.getID()}.");
            Classtest obj2 = new Classtest(); ; // create second object
            Console.WriteLine($"number of objects {Classtest.returnNr()} With ID {obj2.getID()}");

        }
    }

}