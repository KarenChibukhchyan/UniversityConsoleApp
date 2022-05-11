using System;

namespace UniversityConsoleApp.Models
{
    public class Person : BaseModel
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, int age) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
    }
}