using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class HistoryMenu:MenuScreen
    {
        public HistoryMenu():base("HistoryMenu")
        { 
            Add(new MenuItem("Sort scores by max score", new SortHistoryByScoreScreen()));
            Add(new MenuItem("Sort scores by game name", new SortHistoryGameByNameScreen()));
            Add(new MenuItem("Show last game's score", new ShowLastGaneScreen()));
        }
    }
}
