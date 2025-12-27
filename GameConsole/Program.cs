using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Models;
using GameConsole.Pages;
using System.Xml.Serialization;
using GameConsole.Data;


namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // מוסיפים נתונים לרשימת המשתמשים כדי לדמות מסד נתונים אמיתי ולאפשר התחברות לחשבון
            UserDB.UserList.Add(new User("Yuris", "TheBestPlayer", "veryStrongPassword"));
            UserDB.UserList.Add(new User("Yuris2", "TheBestPlayer2", "veryStrongPassword2"));
            UserDB.UserList.Add(new User("Yuris3", "TheBestPlayer3", "veryStrongPassword3"));
            UserDB.UserList.Add(new User("Yuris4", "TheBestPlayer4", "veryStrongPassword4"));
            UserDB.UserList.Add(new User("Yuris5", "TheBestPlayer5", "veryStrongPassword5"));
            UserDB.UserList.Add(new User("1", "2", "3"));

            // מוסיפים נתונים לרשימת התוצאות כדי לדמות מסד נתונים אמיתי ולאפשר צפייה בהיסטוריית המשחקים
            User.UserList.Add(new User("Yuris", "TheBestPlayer", "veryStrongPassword"));
            User.UserList.Add(new User("Yuris2", "TheBestPlayer2", "veryStrongPassword2"));
            User.UserList.Add(new User("Yuris3", "TheBestPlayer3", "veryStrongPassword3"));
            User.UserList.Add(new User("Yuris4", "TheBestPlayer4", "veryStrongPassword4"));
            User.UserList.Add(new User("Yuris5", "TheBestPlayer5", "veryStrongPassword5"));
            User.UserList.Add(new User("1", "2", "3"));



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
