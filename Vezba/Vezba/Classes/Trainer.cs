using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba.Classes
{
    class Trainer : Person
    {
        public string Subject { get; set; }

        public Trainer(string name, string surname, int age, Role role,string subject,string username, string password ) : base(name, surname, age, role, username, password)
        {
            Subject = subject;
        }


    }
}
