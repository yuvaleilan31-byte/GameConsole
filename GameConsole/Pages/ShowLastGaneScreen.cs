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
        public ShowLastGaneScreen() : base("ShowLastGameScreen"){}

        public override void Show()
        {
            base.Show();
            var recebt_score = User.AllScores.OrderByDescending(score => score.Date).First();

            if (recebt_score != null) {
                Console.WriteLine("The last game was:" + recebt_score);
            }
            else
            {
                Console.WriteLine("You stil didn't played any game.");
            }
            
        }
    }
}
