using RegistrationWindow.Core;
using RegistrationWindow.Model;
using System.Collections.Generic;
using System.Linq;

namespace RegistrationWindow
{
    internal static class UserValidator
    {
        //public static bool Validate(string login, string password, string path) => 
        //    UserParser.Parse(path).FirstOrDefault(u => u.Login == login && u.Password == password) is not null;

        public static bool Validate(string login, string password, string path)
        {
            User user = UserParser.Parse(path).FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user is not null)
                return true;

            return false;
        }
        public static IEnumerable<User> SortByRole(IEnumerable<User> users,string role)
        {
            foreach (User user in users.Where(u=> u.Role.Equals(role)))
            {
                yield return user;
            }

        }
    }
}