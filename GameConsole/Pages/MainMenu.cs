using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MainMenu:MenuScreen
    {
        public MainMenu():base("Main Menu")
        {
            Add(new MenuItem("Register screen", new RegisterScreen()));
            Add(new MenuItem("Login screen", new LoginScreen()));
        }
    }
}
