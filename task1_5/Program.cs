using System;
using System.Net.NetworkInformation;
using static UserInputFunctions.UserInputFunctions;

//ska det vara gånger två vid double count?
// array för score?
//read in function?

namespace bowling
{
    internal class Bowling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, lets play bowling!");
            int doubleScore = 0; // keeping track of combo from previous spare/strike
            int totalScore = 0; //total score of player
            char[] Total = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', };  //score throughout the game
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Round {i+1}: throw 1");
                int roundScore = 0;
                int pinsHit2 = 0; 
                int pinsHit = PinsHit(); // get nr pins hit on first throw
                roundScore += GetScore(pinsHit, 0, ref doubleScore);
                if (pinsHit < 10) // No strike on first throw, allow second throw
                {
                    Console.WriteLine($"Round {i+1}: throw 2");
                    pinsHit2 = PinsHit(pinsHit); // get nr pins hit on second throw
                    roundScore += GetScore(pinsHit2, pinsHit, ref doubleScore);
                }
                Console.WriteLine("This round u score: " + roundScore);


                if (i == 9) // Final round
                {
                    if(pinsHit == 10) {
                        Console.WriteLine("Strike on the last round, u get 2 extra shots");
                        int hit1 = PinsHit();
                        roundScore += GetScore(hit1, 0, ref doubleScore);
                        int hit2 = PinsHit(hit1);
                        roundScore += GetScore(hit2, hit1, ref doubleScore);

                    } else if (IsSpare(pinsHit, pinsHit2)) {
                        Console.WriteLine("Spare on the last round, u get 1 extra shot");
                        int hit2 = PinsHit();
                        roundScore += GetScore(hit2, 0, ref doubleScore);
                    }
                    totalScore += roundScore;
                }
                else { totalScore += roundScore; }
            }
            Console.WriteLine("Your score was in total: " + totalScore);
        }

        static bool IsSpare(int hit1, int hit2) //
        {
            return hit1 < 10 && hit2 + hit1 == 10;
        }
        static int PinsHit(int prevPins = 0) 
        {
            int pins = 0;
            do
            {
                ReadInt("How many pins were knocked?: ", out  pins);
                if (pins > 10 || pins < 0 || (pins + prevPins) > 10)
                {
                    Console.WriteLine("You cannot hit more than 10 or negative number of pins, try again");
                }
            } while (pins > 10 || pins < 0); //cannot hit more than 10 or negative number of pins
            

            return pins;
        }
        static int GetScore(int pins, int carry, ref int doubleCount)
        { // ( pins knocked down, carry over points, strike/spare in previous round )
            int score = 0;
            if (doubleCount > 0) // if points combine from previous strike or spare
            {
                score += pins * 2;
                doubleCount--;
            }
            else
            {
                score += pins;
            }

            if (pins == 10) 
            {
                Console.WriteLine("Strike!");
                doubleCount = 2;
            }
            if(IsSpare(carry, pins))
            {
                Console.WriteLine("Spare!");
                doubleCount = 1;
            }

            return score;
        }
    }

}

