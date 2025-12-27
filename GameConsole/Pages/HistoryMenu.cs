using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class HistoryMenu
    {
        List(UserDB) playedGames = new List<UserDb>();
     public static void ByName()
        {
            Console.Clear();
            Console.WriteLine("Games Sorted by Name:");
            var gamesByName = GetGamesSortedByName();
            foreach (var game in gamesByName)
            {
                Console.WriteLine($"Game: {game.Name}");
            }

        }
        public static void ByScore()
        {
            Console.Clear();
            Console.WriteLine("Games Sorted by Score:");
            var gamesByScore = GetGamesSortedByScore();
            foreach (var game in gamesByScore)
            {
                Console.WriteLine($"Game: {game.Score}, Score: {game.Name}");
            }
            
        }
        public static void LastPlayedGame()
        {
            Console.Clear();
            Console.WriteLine("Last Played Game:");
            var lastGame = GetLastPlayedGame();
            if (lastGame != null)
            {
                Console.WriteLine($"Game: {lastGame.Name}, Played on: {lastGame.PlayedOn}");
            }
            else
            {
                Console.WriteLine("No games played yet.");
            }
           
        }
    }
}
