using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        private int randomNumber;

        private int numberOfGuesses;

        private List<int> listOfGuesses = new List<int>();

        Random secretNumber = new Random();

        public int guessingGame()
        {
            randomNumber = secretNumber.Next(1, 10);
            listOfGuesses.Add(0);

            while (numberOfGuesses <= 3)
            {
                Console.Write("Enter your guess: ");
                var playerGuess = int.Parse(Console.ReadLine());

                if (int.TryParse(playerGuess.ToString(), out int value) == false || !string.IsNullOrEmpty(playerGuess.ToString()))
                {
                    if (listOfGuesses.Last() == playerGuess)
                    {
                        Console.WriteLine("You entered the same wrong number");
                        numberOfGuesses += 0;
                    }
                    if (listOfGuesses.Last() != playerGuess)
                    {
                        numberOfGuesses += 1;
                        if (playerGuess > randomNumber && numberOfGuesses < 3)
                        {
                            listOfGuesses.Add(playerGuess);
                            Console.WriteLine($"Lower, you have {4 - numberOfGuesses} attempts left");
                        }

                        if (playerGuess < randomNumber && numberOfGuesses < 3)
                        {
                            listOfGuesses.Add(playerGuess);
                            Console.WriteLine($"Higher, you have {4 - numberOfGuesses} attempts left");
                        }

                        if (playerGuess > randomNumber && numberOfGuesses == 3)
                        {
                            listOfGuesses.Add(playerGuess);
                            Console.WriteLine("Lower, your last attempt");
                        }

                        if (playerGuess < randomNumber && numberOfGuesses == 3)
                        {
                            listOfGuesses.Add(playerGuess);
                            Console.WriteLine("Higher, your last attempt");
                        }

                        if (playerGuess != randomNumber && numberOfGuesses == 4)
                        {
                            Console.WriteLine("Game over, you have no attempts left");
                        }
                        else if (playerGuess == randomNumber)
                        {
                            Console.WriteLine("you are correct, big ups");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
            return numberOfGuesses;
        }

        static void Main(string[] args)
        {
            Program NewGame = new Program();
            NewGame.guessingGame();
        }
    }
}
