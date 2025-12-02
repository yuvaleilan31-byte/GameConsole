using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class RegisterScreen:Screen
    {
        private string name;
        private string userName;
        private string password;

        public RegisterScreen() : base("Registery screen") { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Enter your name: ");
            Console.WriteLine("Enter your user name: ");
            Console.WriteLine("Enter your password: ");
            Console.WriteLine("Confirm your password: ");

        }
    }
}
