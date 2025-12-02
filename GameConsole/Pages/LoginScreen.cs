using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class LoginScreen: Screen
    {
        private string name;
        private string userName;
        private string password;

        public LoginScreen():base("Login screen"){ }

        public override void Show()
        {
            base.Show();
            CenterText("Enter the details below");
            //Console.ReadKey();
            Console.WriteLine("Enter your user name: ");
            Console.WriteLine("Enter your password: ");
            GameMenu gamesScreen = new GameMenu();
            gamesScreen.Show();

        }

    }
}
