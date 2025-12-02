using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class UserList
    {

        public List<User> userList { get; set; };
        public UserList() {
            this.userList = new List<User>();
        }
        public User login(string name, string pass)
        {
            foreach (var user in userList)
            {
                if (user.UserName == name && user.Password == pass)
                    return user;
            }
            Console.WriteLine("Error! No such user");
            return (new User("ERROR", "ERROR", "ERROR"));
        }

        public void Register(string name, string userName, string pass)
        {
            User user = new User(name, userName, pass);
            Boolean ok = true;
            foreach (var u in userList) {
                if (u.UserName == name)
                {
                    ok = false;
                    break;
                }

            if(ok)
                this.userList.Add(user);
            else
                    Console.WriteLine("There is a user whith that user name. Change it.");
        }
    }

}
