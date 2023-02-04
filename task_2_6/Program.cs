using System;
using static UserInputFunctions.UserInputFunctions;

namespace Game
{
    internal class GuessNumberGame
    {
        public int allowedGuesses = 7;
        int guess;
        int currentNrGuesses;
        private int secretNumber;
        Random rnd = new Random();

        public GuessNumberGame() //constructor
        {
            newSecret();
            this.currentNrGuesses = 0;
        }

        void newSecret() //get new random number 0-100
        {
            this.secretNumber = rnd.Next(0, 101);
        }

        public void newGuess() // get new guess from player
        {
            ReadIntwithLimit("Guess a number between 0-100", out this.guess, 0, 100);
            this.currentNrGuesses++;
            if (this.guess < this.secretNumber) // print if too low
            {
                Console.WriteLine("Your guess was too low");
            }
            else if (this.guess > this.secretNumber) // or too high
            {
                Console.WriteLine("Your guess was too high");
            }
        }

        static void Main(string[] args)
        {
            GuessNumberGame game = new GuessNumberGame();
            char cont = 'Y';

            while (cont != 'N' && cont != 'n')
            {
                while (game.currentNrGuesses < game.allowedGuesses && game.guess != game.secretNumber) //game loop
                {
                    Console.WriteLine($"Guess nr {game.currentNrGuesses + 1}");
                    game.newGuess();

                }
                if (game.guess == game.secretNumber) //if correct
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else //if you loose
                {
                    Console.WriteLine("You failed");
                }
                Console.WriteLine("Do you want to play again?  N for No, any other character for Yes"); //play again?
                cont = Console.ReadKey().KeyChar;
                if (cont != 'N' || cont != 'n')
                {
                    game.newSecret(); //start new game
                }
            }
            Console.WriteLine("Quitting game");
        }
    }
}