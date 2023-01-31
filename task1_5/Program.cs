using System;
using System.Net.NetworkInformation;
using static UserInputFunctions.UserInputFunctions;

namespace bowling
{
    internal class Bowling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, lets play bowling!");
            int doubleScore = 0;
            int totalScore = 0;
            for (int i = 0; i < 10; i++)
            {
                int roundScore = 0;
                int pinsHit2 = 0;
                int pinsHit = PinsHit();
                roundScore += GetScore(pinsHit, 0, ref doubleScore);
                if (pinsHit < 10) // No strike on first throw, allow second throw
                {
                    pinsHit2 = PinsHit();
                    roundScore += GetScore(pinsHit2, pinsHit, ref doubleScore);
                }
                Console.WriteLine("This round u score: " + roundScore);


                if (i == 9) // Final round
                {
                    if(pinsHit == 10) {
                        Console.WriteLine("Strike, u get 2 extra shots");
                        int hit1 = PinsHit();
                        roundScore += GetScore(hit1, 0, ref doubleScore);
                        int hit2 = PinsHit();
                        roundScore += GetScore(hit2, hit1, ref doubleScore);

                    } else if (IsSpare(pinsHit, pinsHit2)) {
                        Console.WriteLine("Spare, u get 1 extra shot");
                        int hit2 = PinsHit();
                        roundScore += GetScore(hit2, 0, ref doubleScore);
                    }
                    totalScore += roundScore;
                }
                else { totalScore += roundScore; }
            }
            Console.WriteLine("Your score was in total: " + totalScore);
        }

        static bool IsSpare(int hit1, int hit2)
        {
            return hit1 < 10 && hit2 + hit1 == 10;
        }
        static int PinsHit()
        {
            ReadInt("How many pins were knocked?: ", out int pins);
            

            return pins;
        }
        static int GetScore(int pins, int carry, ref int doubleCount)
        {
            int score = 0;
            if (doubleCount > 0)
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

