using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using RockPaperScissorsApplication.Engine;

namespace RockPaperScissorsApplication.UserHelp
{
    class Input
    {
        private string userInput;

        public string UserInput()
        {
            while (true)
            {
                Console.Write("Enter (R)ock, (P)aper, (S)cissors: ");
                userInput = Console.ReadLine();

                if (userInput.Equals("R", StringComparison.OrdinalIgnoreCase) || userInput.Equals("P", StringComparison.OrdinalIgnoreCase) || userInput.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    return userInput.ToUpper();
                }
                else
                {
                    ErrorInput();
                    ClearConsoleLines(2);
                }
            }
        }

        public bool PlayAgain()
        {
            Console.WriteLine();

            while (true)
            {
                Console.Write("Would you like to play again? (Y/N): ");
                userInput = Console.ReadLine();

                if (userInput.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                else if (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    ErrorInput("Please enter either (Y)es or (N)o.");
                    ClearConsoleLines(2);
                }
            }
        }

        private void ClearConsoleLines(int numberOfLinesToClear)
        {
            int currentCursorPosition = Console.CursorTop - numberOfLinesToClear;

            for (int i = 1; i <= numberOfLinesToClear; i++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, currentCursorPosition);
        }

        private void ErrorInput()
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a valid input (R), (P), (S)");
            Console.ResetColor();

            Thread.Sleep(2000);
        }

        private void ErrorInput(string errorMessage)
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();

            Thread.Sleep(2000);
        }
    }
}
