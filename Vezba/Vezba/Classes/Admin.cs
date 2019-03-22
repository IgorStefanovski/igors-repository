using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba.Classes
{
    class Admin : Person
    {

        public Admin (string name, string lastname, int age, Role role,string username, string password): base(name, lastname, age, role, username, password)
        {

            FirstName = name;
            LastName = lastname;
            Age = age;
            Role = role;


        }

        



    }
}
