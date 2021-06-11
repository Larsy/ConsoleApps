﻿using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!\nI love to code!\n");

            int userSelection;
            do
            {
                Console.WriteLine("\n---- Menu ----");
                Console.WriteLine("1: Code Joke");
                Console.WriteLine("2: Count down");
                Console.WriteLine("3: Ask Bartender for a drink");
                Console.WriteLine("9: Quit\n");

                userSelection = GetNumberFromUser("menu selection");

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("Why does java programmers have glasses?\nThey don't se sharp! (C#)");
                        break;
                    case 2:
                        Console.WriteLine("Not implemented yet.");
                        break;
                    case 3:
                        Bartender();
                        break;
                    case 9:
                        Console.WriteLine("Thank's for using this program.");
                        Console.WriteLine("Press any key to close the program.");
                        break;
                    default:
                        Console.WriteLine("Not a valid selection");
                        break;
                }

            } while (userSelection != 9);

        }

        static void Bartender()
        {
            int userAgeNumber = GetNumberFromUser("age");

            if (userAgeNumber > 17)
            {
                Console.WriteLine("Here you go, a nice cold beer!");
            }
            else
            {
                Console.WriteLine("Complementary Soda for you");
            }
        }

        static int GetNumberFromUser()
        {
            string userInput = Console.ReadLine();
            int number = 0;
            int.TryParse(userInput, out number);
            return number;
        }
        static int GetNumberFromUser(string forWhat)
        {
            Console.Write("Enter " + forWhat + " number: ");
            string userInput = Console.ReadLine();
            int number = 0;
            int.TryParse(userInput, out number);
            return number;
        }
    }
}
