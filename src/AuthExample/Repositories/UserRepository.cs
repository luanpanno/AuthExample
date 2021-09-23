using AuthExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthExample.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();

            users.Add(new User { Id = 1, Username = "Batman", Password = "batman", Role = "manager" });
            users.Add(new User { Id = 2, Username = "Robin", Password = "robin", Role = "employee" });

            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
