using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTraining01
{
    public class Data
    {
        public List<int> IntList { get; set; } = new List<int> 
        { 
            1, 1, 2, 3, 11, 4, 5, 14, 13, 6, 7, 8, 9, 10, 12, 15 
        };

        public List<string> Friends = new List<string>()
        {
            "Danny",
            "Thomas",
            "Leif",
            "Alex"
        };

        public List<object> ObjectList = new List<object>()
        {
            "Richard", 
            "Linda", 
            "Alicia", 
            "Lucas", 
            1, 
            2, 
            3, 
            4, 
            5
        };

        public List<Person> PersonList = new List<Person>()
        {
            new Person { Name = "Anna", Friends = new List<string> { "Bill", "Cathy" } },
            new Person { Name = "Bill", Friends = new List<string> { "Anna", "David" } },
            new Person { Name = "Cathy", Friends = new List<string> { "Anna", "Bill" } }
        };

        public List<EmployeeClass> Employees = new List<EmployeeClass>()
        {
            new EmployeeClass() {
                Id=1,
                FirstName = "Richard",
                LastName = "Chalk",
                Email="richard@gmail.com",
                ProgrammingStringList = new List<string>()
                { "C#", "PHP", "JAVA" },
                TechsObjectList = new List<TechClass>
                {
                    new TechClass(){Technology = "Tech#1" },
                    new TechClass(){Technology = "Tech#2" },
                    new TechClass(){Technology = "Tech#4" }
                }
            },
            new EmployeeClass() {
                Id=2,
                FirstName = "Linda",
                LastName = "Erdös",
                Email="linda@gmail.com",
                ProgrammingStringList = new List<string>()
                { "C#", "Python", "HTML" },
                TechsObjectList = new List<TechClass>
                {
                    new TechClass(){Technology = "Tech#3" },
                    new TechClass(){Technology = "Tech#5" },
                    new TechClass(){Technology = "Tech#1" }
                }
            },
            new EmployeeClass() {
                Id=3,
                FirstName = "Alicia",
                LastName = "Rianna",
                Email="aicia@gmail.com",
                ProgrammingStringList = new List<string>()
                { "HTML", "Python", "Ruby" },
                TechsObjectList = new List<TechClass>
                {
                    new TechClass(){Technology = "Tech#1" },
                    new TechClass(){Technology = "Tech#6" },
                }
            },
            new EmployeeClass() {
                Id=4,
                FirstName = "Lucas",
                LastName = "Clifford",
                Email="lucas@gmail.com",
                ProgrammingStringList = new List<string>()
                { "HTML", "F#", "MVC" },
                TechsObjectList = new List<TechClass>
                {
                    new TechClass(){Technology = "Tech#4" },
                }
            },
             new EmployeeClass() {
                Id=5,
                FirstName = "Rich",
                Email="rich@gmail.com",
                ProgrammingStringList = new List<string>()
                { "BOOTSTRAP", "F#", "MVC" },
                // Rich has an empty list of Techs
                TechsObjectList = new List<TechClass>()
            },
        };

        // Classes - Classes - Classes - Classes - Classes - Classes - Classes -
        // Classes - Classes - Classes - Classes - Classes - Classes - Classes -
        // Classes - Classes - Classes - Classes - Classes - Classes - Classes -
        // Classes - Classes - Classes - Classes - Classes - Classes - Classes -
        public class EmployeeClass
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = String.Empty;
            public string LastName { get; set; } = String.Empty;
            public string Email { get; set; } = String.Empty;
            public List<string> ProgrammingStringList { get; set; } = new List<string>();
            public List<TechClass> TechsObjectList { get; set; } = new List<TechClass>();
        }

        public class StudentClass
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; } = string.Empty;
            public string StudentEmail { get; set; } = string.Empty;
        }

        public class TechClass
        {
            public string Technology { get; set; } = string.Empty;
        }
    }
}
