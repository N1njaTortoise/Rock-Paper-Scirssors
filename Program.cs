using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsApplication.Engine;
using RockPaperScissorsApplication.UserHelp;

namespace RockPaperScissorsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu _menuHeadings = new Menu();
            GameEngine _gameEngine = new GameEngine();
            Input _input = new Input();

            do
            {
                _gameEngine.ResetGame();
                _menuHeadings.GameMenuStartUp();

                do
                {
                    _menuHeadings.ApplicationTitlePage();
                    _menuHeadings.ApplicationScoreBoard(_gameEngine.ComputerScore, _gameEngine.PlayerScore);

                    _gameEngine.Game();

                } while (_gameEngine.ScoreController());

            } while (_input.PlayAgain());

            
        }
    }
}
