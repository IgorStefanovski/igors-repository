using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezba.Classes;



namespace Vezba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student> {
            new Student("Dennis", "Bergkamp",30, Role.student ,"C#", 5, "denis","123"),
            new Student("Thierry", "Henry", 29, Role.student, "C#", 2, "thierry", "124"),
            new Student("Stojko", "Berg", 20, Role.student, "C#", 3, "Stojko", "125"),

            };


            List<Admin> Admins = new List<Admin> {
            new Admin("Limeni", "Limeni",23, Role.admin ,"limeni","1234"),
            new Admin("Lepi", "Lepi", 22, Role.admin, "lepi", "1235"),
            new Admin("Limen", "Limen", 27, Role.admin, "limen", "1237"),



            };

            List<Trainer> Trainers = new List<Trainer> {
            new Trainer("Steph", "Curry",23, Role.trainer,"javascrypt" ,"steph","12"),
            new Trainer("Klay", "Thompson", 22, Role.admin,"css", "klay", "13"),
            new Trainer("Luka", "Doncic", 27, Role.admin,"Html", "luka", "14"),



            };



        }
    }
}