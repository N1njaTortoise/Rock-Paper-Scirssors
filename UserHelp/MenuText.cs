using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApplication
{
    class Menu
    {
        const string applicationName = "Rock Paper Scissors";
        private const string winText = "You Win!";
        private const string looseText = "You Loose!";
        private const string drawText = "Its a draw!";

        string lineBreaker = new string('*', 50);

        public void GameMenuStartUp()
        {
            MenuHeadings();
            ApplicationTitlePage();
            MenuHelpPage();
        }

        private void MenuHeadings()
        {
            Console.Title = applicationName;
        }
        private void MenuHelpPage()
        {
            Console.WriteLine("Welcome to the classic game of Rock, Paper, Scissors.");
            Console.WriteLine("Some usefull hints to rmemeber:");
            Console.WriteLine("R - Rock");
            Console.WriteLine("P - Paper");
            Console.WriteLine("S - Scissors");

            Console.WriteLine("\nThe game is played by choosing either (R)ock, (P)aper, (S)cissor. " +
                "\nand then you wait to see if you win or loose." +
                "\n\nThe best of three(3) wins the game!");

            Console.WriteLine("\nThis is a simple game that we have all played growing up, so have some fun and good luck.");
            Console.WriteLine("\nPress any button to continue.....");
            Console.ReadKey();

            Console.Clear();
        }

        public void ApplicationTitlePage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(applicationName.ToUpper());
            Console.ResetColor();

            Console.WriteLine(lineBreaker);
        }

        public void ApplicationScoreBoard(int argCompScore, int argPlayerScore)
        {
            Console.WriteLine($"Player Score: {argPlayerScore}");
            Console.WriteLine($"Computer Score: {argCompScore}");
            Console.WriteLine(lineBreaker);
        }

        public void WinText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine + winText);
            Console.ResetColor();
        }

        public void LooseText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Environment.NewLine + looseText);
            Console.ResetColor();
        }

        public void DrawText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Environment.NewLine + drawText);
            Console.ResetColor();
        }

        public void WinConditionStatementText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine + "You Beat the game!" + "\nHow about another round?");
            Console.ResetColor();
        }

        public void LooseConditionStatementText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Environment.NewLine + "You Lost the game!" + "\nBetter Luck next time!");
            Console.ResetColor();
        }
    }
}
