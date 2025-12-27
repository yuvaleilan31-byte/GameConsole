using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Models;
using GameConsole.Pages;
using System.Xml.Serialization;
using GameConsole.Data;
using GameConsole;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // מוסיפים נתונים לרשימת המשתמשים כדי לדמות מסד נתונים אמיתי ולאפשר התחברות לחשבון
            UserDB.UserList.Add(new User("Bell", "TheBestPlayer", "veryStrongPassword"));
            UserDB.UserList.Add(new User("Lion", "TheBestPlayer2", "veryStrongPassword2"));
            UserDB.UserList.Add(new User("Lilo", "TheBestPlayer3", "veryStrongPassword3"));
            UserDB.UserList.Add(new User("Stich", "TheBestPlayer4", "veryStrongPassword4"));
            UserDB.UserList.Add(new User("1", "2", "3"));
            UserDB.UserList.Add(new User("Nick", "TheBestPlayer5", "veryStrongPassword5"));





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
            var x = UserDB.UserList[0];
            ConsoleGame game  = new ConsoleGame();
            game.StartApp();





        }
    }
}
