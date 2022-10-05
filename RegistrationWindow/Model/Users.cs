using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWindow.Model
{
    public class User
    {

        public int Id { get; set; }
        public string Middlename { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BornDate { get; set; }
        public decimal Selary { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User(int id, string middlename, string firstname, string lastname, DateTime bornDate, decimal selary, string login, string password, string role)
        {
            Id = id;
            Middlename = middlename;
            Firstname = firstname;
            Lastname = lastname;
            BornDate = bornDate;
            Selary = selary;
            Login = login;
            Password = password;
            Role = role;
        }
        public User()
        {
            Id = default;
            Middlename = string.Empty;
            Firstname = string.Empty;
            Lastname = string.Empty;
            BornDate = DateTime.UnixEpoch;
            Selary = decimal.Zero;
            Login = string.Empty;
            Password = string.Empty;
            Role = string.Empty;

        }
        
       
    }
}