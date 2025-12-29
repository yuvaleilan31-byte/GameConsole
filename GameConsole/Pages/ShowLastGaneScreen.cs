using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class ShowLastGaneScreen: Screen
    {
        public ShowLastGaneScreen() : base("show last game's score"){}

        public override void Show()
        {
            base.Show();
            var recent_score = ConsoleGame.user.AllScores.OrderByDescending(score => score.Date).First();

            if (recent_score != null) {
                Console.WriteLine("Game: " + recent_score.Name + ", score: " + recent_score.Score + ", date: " + recent_score.Date);
            }
            else
            {
                Console.WriteLine("You didn't played any game yet.");
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nPress any key to continue.");
            Console.ResetColor();
            Console.ReadKey();
            
            Screen next = new AfterLoginMenu();
            next.Show();
        }

    }
}
