using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba.Classes
{
    public class Student : Person
    {
        public string Subject { get; set; }
        public int Grades { get; set; }
        public Student(string name, string surname, int age, string subject, int grades,string username,string password) : base(name, surname, age, role, username, password)
        {
            Subject = subject;
            Grades = grades;
        }


    
    }
}
