using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;


namespace GameConsole.Pages
{
    internal class GameScreen: Screen
    {
        public string Title { get; set; }
        public IGamePlay game;

        public GameScreen(string title, IGamePlay game) : base(title){
            this.game = game;
        } 
        public override void Show()
        {
            game.Play();
        }
    }
}
