using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_project.Models
{
    // Inherits ID from FoodSafetyEntity
    public class User : FoodSafetyEntity
    {
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User() : base() { }

        public User(int id, string firstName, string username, string gender, int age, string email, string password, string role = "User") : base(id)
        {
            this.FirstName = firstName;
            this.Username = username;
            this.Gender = gender;
            this.Age = age;
            this.Email = email;
            this.Password = password;
            this.Role = role;
        }
    }
}
