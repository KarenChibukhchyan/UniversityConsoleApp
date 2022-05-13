using System;

namespace UniversityConsoleApp.Models
{
    public class Person : BaseModel
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        int _age;

        public int Age
        {
            get => _age;
            set => _age = 10 < value && value < 99 ? value : throw new ArgumentException("Invalid age range");
        }
    }
}