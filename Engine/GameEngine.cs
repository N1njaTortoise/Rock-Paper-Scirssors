using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RockPaperScissorsApplication.UserHelp;

namespace RockPaperScissorsApplication.Engine
{
    class GameEngine
    {
        Input _input = new Input();
        Menu _menu = new Menu();

        private const string rock = "Rock";
        private const string scissors = "Scissors";
        private const string paper = "Paper";
        private const string quit = "Quit";

        private string computerChoice;
        private string playerChoice;

        private int computerScore = 0;
        private int playerScore = 0;
        
        Random rng;

        public int ComputerScore
        {
            get { return computerScore; }
            set { computerScore = value; }
        }
        public int PlayerScore 
        { 
            get { return playerScore; }
            set { PlayerScore = value; }
        }

        public GameEngine()
        {
            rng = new Random();
        }

        public void Game()
        {
            playerChoice = _input.UserInput();

            computerChoice = NumberToString(rng.Next(1, 4));

            Console.WriteLine($"\nComputer choice is: {ConvertValueToText(computerChoice)}");
            Console.WriteLine($"Player choice is: {ConvertValueToText(playerChoice)}");

            ComparePlayerToComputer(computerChoice, playerChoice);

            Thread.Sleep(1000);
            Console.Clear();
        }

        private string ConvertValueToText(string valueText)
        {
            switch (valueText)
            {
                case "R":
                    return rock;
                case "P":
                    return paper;
                case "S":
                    return scissors;
                default:
                    return "No value reachable";
            }
        }

        private string NumberToString(int numberGenerated)
        {
            switch (numberGenerated)
            {
                case 1:
                        return "R";
                case 2:
                    return "S";
                case 3:
                    return "P";
                default:
                    return "no number available";
            }
        }

        private void ComparePlayerToComputer(string computer, string player)
        {
            if (computer.Equals("R", StringComparison.OrdinalIgnoreCase) && player.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                _menu.DrawText();
            }
            else if (computer.Equals("R", StringComparison.OrdinalIgnoreCase) && player.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                _menu.WinText();

                playerScore++;
            }
            else if (computer.Equals("R", StringComparison.OrdinalIgnoreCase) && player.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                _menu.LooseText();

                computerScore++;
            }
            else if (computer.Equals("S", StringComparison.OrdinalIgnoreCase) && player.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                _menu.WinText();

                playerScore++;
            }
            else if (computer.Equals("S", StringComparison.OrdinalIgnoreCase) && player.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                _menu.LooseText();

                computerScore++;
            }
            else if (computer.Equals("S", StringComparison.OrdinalIgnoreCase) && player.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                _menu.DrawText();
            }
            else if (computer.Equals("P", StringComparison.OrdinalIgnoreCase) && player.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                _menu.LooseText();

                computerScore++;
            }
            else if (computer.Equals("P", StringComparison.OrdinalIgnoreCase) && player.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                _menu.DrawText();
            }
            else if (computer.Equals("P", StringComparison.OrdinalIgnoreCase) && player.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                _menu.WinText();

                playerScore++;
            }
            else
            {
                Console.WriteLine("No valid input was found!");
            }
        }

        public bool ScoreController()
        {
            if (computerScore == 3)
            {
                LooseStatement();
                return false;
            }
            else if (playerScore == 3)
            {
                WinStatement();
                return false;
            }
            return true;
        }

        private void WinStatement()
        {
            Console.Clear();
            _menu.ApplicationTitlePage();
            _menu.ApplicationScoreBoard(ComputerScore, PlayerScore);

            _menu.WinConditionStatementText();
        }

        private void LooseStatement()
        {
            Console.Clear();
            _menu.ApplicationTitlePage();
            _menu.ApplicationScoreBoard(ComputerScore, PlayerScore);

            _menu.LooseConditionStatementText();
        }

        public void ResetGame()
        {
            computerScore = 0;
            playerScore = 0;
            Console.Clear();
        }
    }
}
