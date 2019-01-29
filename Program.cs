using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // App info

            WelcomeUser(); // Welcome user

            while (true)
            {
                //Get user's input
                string reply = Console.ReadLine().ToUpper();

                // If statement to check user's answer
                if (reply == "Y")
                {
                    // Level 1
                    //-------------------------
                    PlayBySkillLevel("Great! So I will go easy on you so you don't have a brain damage. I have a number in mind, can you guess what it is?", "Hint: It is between 1 to 5.");
                    // Play game
                    PlayGame(5);
                    // Congratulations - Change color
                    ChangeColor(ConsoleColor.Yellow, "Congratulations! You guessed correctly! " + "You've qualified for the next level.");

                    // Level 2
                    //-------------------------
                    System.Threading.Thread.Sleep(1500);
                    PlayBySkillLevel("This time I won't go easy on you. I have another number in mind, can you guess what it is?", "Hint: It is between 1 to 15.");
                    // Play game
                    PlayGame(15);
                    // Change color
                    ChangeColor(ConsoleColor.Red, "Nope, try again...");
                    System.Threading.Thread.Sleep(1500);
                    ChangeColor(ConsoleColor.Yellow, "Oh wait!... You are CORRECT!! Congratulations!!!");
                    ChangeColor(ConsoleColor.Green, "HAHA! Got You there!");

                    // Level 3
                    //-------------------------
                    System.Threading.Thread.Sleep(2000);
                    ChangeColor(ConsoleColor.Yellow, "Welcome to Level 3! You seem to be better than I thought you would be.");
                    System.Threading.Thread.Sleep(2000);
                    PlayBySkillLevel("Alright, the rule is still the same, I have another number in mind, can you try guessing what it is?", "Hint: It is between 1 to 20.");
                    // Play game
                    PlayGame(11);
                    System.Threading.Thread.Sleep(2500);
                    // Change color
                    ChangeColor(ConsoleColor.Green, "Hmm.....");
                    System.Threading.Thread.Sleep(2000);
                    ChangeColor(ConsoleColor.Red, "Nope, try again...");
                    ChangeColor(ConsoleColor.Green, "LOL, sorry I had to pause for a while to be sure... Keep going...");
                    // Play game
                    BreakGame(20);
                    // Change color
                    ChangeColor(ConsoleColor.Yellow, "WOW! Congratulations!! You have qualified for the FINAL LEVEL!!! If you scale through this one, then you must be a mind reader.");

                    // Level 4
                    //-------------------------
                    System.Threading.Thread.Sleep(2000);
                    PlayBySkillLevel("Ofcourse, don't expect this to be easy. Try guessing the number I currently have in mind.", "Hint: It is between 1 to 30.");
                    // Play game
                    PlayGame(30);
                    // Change color
                    System.Threading.Thread.Sleep(3000);
                    ChangeColor(ConsoleColor.Yellow, "WOW! You Made It Through!! Congratulations!!!!");
                    System.Threading.Thread.Sleep(1000);
                    ChangeColor(ConsoleColor.DarkCyan, "Thanks for playing! There is nothing left of this game, you can go ahead and close the black window or...");

                    break;

                }

                else if (reply == "N")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't get that. Please choose between Y or N.");
                    continue;
                }

            }

        }

        // *** Funtions ***

        // Function to get app information
       
        static void GetAppInfo()
        {
            // Init the parameter for the Introduction
            string appTitle = "Number Guesser";
            string appVersion = "Version 1.0.0";
            string appAuthor = "Nicole Nwakalor";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Print Introduction to console
            Console.WriteLine("{0}: {1} by {2}.", appTitle, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        //-----------------------------------------------------------------

        // Welcome message to user.

        static void WelcomeUser()
        {
            // Welcome Message to user
            Console.WriteLine("Welcome to Number Guesser! My name is Matt, what is your name?");

            // Read user's input
            string userInput = Console.ReadLine();

            // Welcome user with name and invite to play game
            Console.WriteLine("Hello {0}, wanna play a game with me? [Y or N]", userInput);
        }

        //-----------------------------------------------------------------

        // Function to change color

        static void ChangeColor(ConsoleColor color, String message)
        {
            // Change color
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            Console.ResetColor();
        }

        //-----------------------------------------------------------------

        // Addresses different skill level

        static void PlayBySkillLevel(String guessMesssage, String hintMessage)
        {
            Console.WriteLine(guessMesssage);

            // Change color
            ChangeColor(ConsoleColor.DarkGreen, hintMessage);

        }

        //---------------------------------------------------------------

        // Function to play game based on skill level

        static void PlayGame(Int32 number)
        {
            // init a guess value
            int guess = 0;

            // Creating a random number
            Random randomNumber = new Random();

            //Init correct number
            int numberInMind = randomNumber.Next(1, number);

            while (guess != numberInMind)
            {
                //Obtain user's input
                string answer = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(answer, out guess))
                {
                    // Change color
                    ChangeColor(ConsoleColor.Red, "Please enter an actual number");
                    continue;
                }

                // Assign answer to variable guess and convert from string to integer
                guess = Int32.Parse(answer);

                if (guess != numberInMind)
                {
                    // Change color
                    ChangeColor(ConsoleColor.Red, "Nope, try again...");
                }
                else
                {
                    break;
                }

            }
        }

        //-----------------------------------------------------------------

        // Break Game in Level 3

        static void BreakGame(Int32 number)
        {
            // init a guess value
            int guess = 0;

            // Creating a random number
            Random randomNumber = new Random();

            //Init correct number
            int numberInMind = randomNumber.Next(12, number);

            while (guess != numberInMind)
            {
                //Obtain user's input
                string answer = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(answer, out guess))
                {
                    // Change color
                    ChangeColor(ConsoleColor.Red, "Please enter an actual number");
                    continue;
                }

                // Assign answer to variable guess and convert from string to integer
                guess = Int32.Parse(answer);

                if (guess != numberInMind)
                {
                    // Change color
                    ChangeColor(ConsoleColor.Red, "Nope, try again...");
                }
                else
                {
                    break;
                }

            }
        }




    }

}

