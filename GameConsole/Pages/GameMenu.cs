using GameConsole.Base;
using GameConsole.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameMenu: MenuScreen
    {
        
        public GameMenu() : base("Game Menu")
        {
            Add(new MenuItem("Fluffy Bird", new GameScreen("Fluffy Bird", new FluffyBirdGame())));
            Add(new MenuItem("Pac Man", new  GameScreen("Pac Man", new PacManGame())));
            Add(new MenuItem("Tetris", new GameScreen("Tetris", new TetrisGame())));
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
