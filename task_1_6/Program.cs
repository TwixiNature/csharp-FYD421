using System;
using System.Net.NetworkInformation;
using static UserInputFunctions.UserInputFunctions;


namespace bowling
{
    internal class Bowling
    {
        string? name = null; //empty until player name set
        int[] score = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int combo = 0;

        public void setName() // set name of player at start of game
        {
            this.name = ReadString("PLayer name?");
        }

        public void printscore(int round) //print score so far
        {
            Console.Write($"{this.name}: Score  [ ");
            for (int j = 0; j <= round; j++)
            {
                Console.Write($" {this.score[j]} ");
            }
            Console.WriteLine(" ]");
        }

        public void round(int i) // one round for one player
        {
            Console.WriteLine($"{this.name}'s turn");
            Console.WriteLine($"Round {i + 1}: throw 1");
            int trashBin = 0;
            int roundScore = 0;
            int pinsHit2 = 0;
            int pinsHit = PinsHit(); // get nr pins hit on first throw
            if (i == 0)
            {
                roundScore += GetScore(pinsHit, -1, ref this.combo, ref trashBin); // might need ref before this.combo
            }
            else
            {
                roundScore += GetScore(pinsHit, -1, ref this.combo, ref this.score[i - 1]);
            }
            if (pinsHit < 10) // No strike on first throw, allow second throw
            {
                Console.WriteLine($"Round {i + 1}: throw 2");
                pinsHit2 = PinsHit(pinsHit); // get nr pins hit on second throw
                if (i == 0)
                {
                    roundScore += GetScore(pinsHit2, pinsHit, ref this.combo, ref trashBin);
                }
                else
                {
                    roundScore += GetScore(pinsHit2, pinsHit, ref this.combo, ref this.score[i - 1]);
                }
            }
            Console.WriteLine("This round u score: " + roundScore);


            if (i == 9) // Final round
            {
                if (pinsHit == 10)
                {
                    Console.WriteLine("Strike on the last round, u get 2 extra shots");
                    int hit1 = PinsHit();
                    roundScore += GetScore(hit1, -1, ref this.combo, ref this.score[i]);

                    int hit2 = PinsHit(hit1, true);
                    roundScore += GetScore(hit2, hit1, ref this.combo, ref this.score[i]);

                }
                else if (IsSpare(pinsHit, pinsHit2))
                {
                    Console.WriteLine("Spare on the last round, u get 1 extra shot");
                    int hit2 = PinsHit();
                    roundScore += GetScore(hit2, -1, ref this.combo, ref this.score[i]);
                }
            }
            this.score[i] = roundScore;

            // printing scorecard
            this.printscore(i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, lets play bowling!");
            int nrPlayers;
            Bowling player1 = new Bowling();
            Bowling player2 = new Bowling();
            Bowling player3 = new Bowling();

            ReadIntwithLimit("How many players? 1-3 possible ", out nrPlayers, 1, 3); // the players

            player1.setName();
            if (nrPlayers > 1)
            {
                player2.setName();
                if (nrPlayers > 2)
                {
                    player3.setName();
                }
            }

            for (int i = 0; i < 10; i++) //the game
            {
                Console.WriteLine();
                Console.WriteLine($"  ---  Round {i + 1}  ---  ");
                player1.round(i);
                if (nrPlayers > 1)
                {
                    Console.WriteLine();
                    player2.round(i);
                    if (nrPlayers > 2)
                    {
                        Console.WriteLine();
                        player3.round(i);
                    }
                }
            }

            Console.WriteLine("Your score was in total:"); // the score
            player1.printscore(9);
            Console.WriteLine($"Total : {player1.score.Sum()}");
            if (nrPlayers > 1)
            {
                player2.printscore(9);
                Console.WriteLine($"Total : {player2.score.Sum()}");
                if (nrPlayers > 2)
                {
                    player3.printscore(9);
                    Console.WriteLine($"Total : {player3.score.Sum()}");
                }
            }





        }

        static bool IsSpare(int hit1, int hit2) //from 1.5
        {
            return hit1 < 10 && hit2 + hit1 == 10;
        }
        static int PinsHit(int prevPins = 0, bool allowit = false) //NEW ish
        {
            Random rnd = new Random(); //new random object
            Console.WriteLine("Press Space to throw ball");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar) //
            {
            }
            int pins = rnd.Next(0, 11 - prevPins); // new random, depending on how many pins are left from previous throw
            //do
            //{
            //    ReadInt("How many pins were knocked?: ", out pins);
            //    if ((pins > 10 || pins < 0 || (pins + prevPins) > 10) && !allowit)
            //    {
            //        Console.WriteLine("You cannot hit more than 10 or negative number of pins, try again");
            //    }
            //} while ((pins > 10 || pins < 0 || (pins + prevPins) > 10) && !allowit); //cannot hit more than 10 or negative number of pins
            Console.WriteLine($"You hit {pins} pins");
            return pins;
        }
        static int GetScore(int pins, int carry, ref int doubleCount, ref int prevScore) // from 1.5
        { // ( pins knocked down, carry over points, strike/spare in previous round )

            if (doubleCount > 0) // if points combine from previous strike or spare
            {
                prevScore += pins; // add pins from current throw to strike/spare score
                doubleCount--;
            }

            if (pins == 10 && carry == -1)
            {
                Console.WriteLine("Strike!");
                doubleCount = 2;
            }
            else if (IsSpare(carry, pins))
            {
                Console.WriteLine("Spare!");
                doubleCount = 1;
            }

            return pins;
        }
    }

}

