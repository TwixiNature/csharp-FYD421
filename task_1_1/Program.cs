/*
 * Skriv ett program som simulerar 10 000 kast med en sexsidig tärning.  Programmet skall efteråt 
skriva ut hur många av tärningskasten som gav två respektive fem.  Använd ett fält med en lämplig 
storlek för att lösa uppgiften. */

using System;

namespace Game
{
    internal class DiceToss
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); //initiate instance of random class
            int[] arr = {0,0}; //int array for keeping track of outcomes
            int[] arr2= new int[6];
            for(int i =0; i < 10000; i++) { // 10 000 iterations
                int dice = rnd.Next(1, 7); //random int between 1-6
                if (dice == 2) // if 2
                {
                    arr[0]++;
                }
                else if(dice == 5) // if 5
                {
                    arr[1]++;
                }
            }

            for (int i = 0; i < 10000; i++) // alternatively
            { // 10 000 iterations
                arr2[rnd.Next(0, 6)]++; //random int between 1-6
            }
            // write to console
            Console.WriteLine($"first try: 2 was thrown {arr[0]} times, and 5 was thrown {arr[1]} times");
            Console.WriteLine($"Second try: 2 was thrown {arr2[1]} times, and 5 was thrown {arr2[4]} times");
            //random 10 000 kast

            //spara resultat arr[2] <- stort nog för potentiellt 10 000


        }
    }
}

