using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //BONUS#1: Add a Date property in User, & initialize it to the time the user joined (i.e. when the User object was created).
        //public DateTime Date { get; set; }

        public User()
        {

        }

        public User(string username, string email, string password, string date):this()
        {
            Username = username;
            Email = email;
            Password = password;
            //Date = DateTime.Now;
        }
    }
}
