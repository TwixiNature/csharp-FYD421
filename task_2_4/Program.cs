/*Skriv ett program som simulerar kast med tre tärningar, genom att skapa instanser av en tärnings-
klass.  Programmet skall skriva ut hur ofta kombinationerna 1-2-3 respektive 6-6-6 inträffar för ett 
antal tärningskast som anges av användaren.  */
using System;
using System.Runtime.ExceptionServices;
using static UserInputFunctions.UserInputFunctions;

namespace Game
{
    internal class dice
    {
        int face; // result of dice throw
        static Random rnd = new Random();
        public dice() // constructor
        {
        }

        void throw_dice()
        {
            face = rnd.Next(1, 7); // new throw of dice value 1-6
        }

        static public bool is_sixes(dice dice1, dice dice2, dice dice3) // all three sixes?
        {
            return dice1.face == 6 && dice2.face == 6 && dice3.face == 6;
        }

        static public bool is_one_two_three(dice dice1, dice dice2, dice dice3) // if 1 2 3 in any order?
        {
            if (dice1.face == 1 && dice2.face == 2 && dice3.face == 3) { return true; }
            else if (dice1.face == 1 && dice2.face == 3 && dice3.face == 2) { return true; }

            else if (dice1.face == 2 && dice2.face == 3 && dice3.face == 1) { return true; }
            else if (dice1.face == 2 && dice2.face == 1 && dice3.face == 3) { return true; }

            else if (dice1.face == 3 && dice2.face == 1 && dice3.face == 2) { return true; }
            else if (dice1.face == 3 && dice2.face == 2 && dice3.face == 1) { return true; }
            return false;
        }

        static public Tuple<int, int> gameloop(int throws)
        {
            int nrSixes = 0;
            int nrOneTwoThree = 0;
            dice dice1 = new dice(); //create three dice objects
            dice dice2 = new dice();
            dice dice3 = new dice();


            for (int i = 0; i < throws; i++) // for as many rounds as user input
            {
                dice1.throw_dice(); // throw all three dice
                dice2.throw_dice();
                dice3.throw_dice();

                //Console.WriteLine(dice1.face + " - " + dice2.face + " - " + dice3.face); // prints result
                if (is_sixes(dice1, dice2, dice3)) //check if 6-6-6
                {
                    nrSixes++;
                }
                else if (is_one_two_three(dice1, dice2, dice3)) // check if 1-2-3
                {
                    nrOneTwoThree++;
                }
            }


            return Tuple.Create(nrSixes, nrOneTwoThree); // return nr of 6-6-6s and 1-2-3s
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            int throws;

            ReadInt("How many throws?", out throws); // get throws from player

            Tuple<int, int> result = dice.gameloop(throws); // play game

            Console.WriteLine($"You had {result.Item1} st 6-6-6 and {result.Item2} st 1-2-3"); // print result

        }
    }
}
