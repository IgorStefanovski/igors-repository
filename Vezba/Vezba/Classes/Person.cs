using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role{ get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Person(string name, string lastname, int age, Role role,string username, string password)
        {

            FirstName = name;
            LastName = lastname;
            Age = age;
            Role = role;
            Username = username;
            Password = password;


        }
    }
}
