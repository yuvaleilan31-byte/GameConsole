using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Pages;
using System.Xml.Serialization;
//using GameConsole.ConsoleGame;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImportContext ConsoleGame;
            //        List<IGamePlay> games = new List<IGamePlay>();
            //        games.Add(new Games.TetrisGame());
            //        games.Add(new Games.FluffyBirdGame());
            //        games.Add(new Games.PacManGame());

            //        foreach (var game in games)
            //        {
            //            game.Play();
            //Console.Write($" Game:{game.Name}");
            //Console.WriteLine($"Score:{game.Score}");
            //        }


            //Screen mainScreen = new Screen("home Page");
            //mainScreen.Show();
            //mainScreen = new WelcomeScreen();
            //mainScreen.Show();
            //Console.ReadKey();
            ConsoleGame game  = new ConsoleGame();
            game.StartApp();





        }
    }
}
