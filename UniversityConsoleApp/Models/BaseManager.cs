using System;

namespace UniversityConsoleApp.Models
{
    public class BaseManager
    {
        const short maxAge = 139;
        public virtual Person Create(string firstName, string lastName, int age) => new Person(firstName, lastName, age);
        public virtual Person[] Create(int count, int minAge)
        {
            Person[] persons = new Person[count];
            Random rnd = new Random();
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person($"name{i}", $"surName{i}", rnd.Next(minAge, maxAge));
            }
            return persons;
        }

        public virtual void Print(Person person)
        {
            Console.WriteLine("**********  person   **********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
            Console.WriteLine();
        }

        public virtual void Print(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++) Print(persons[i]);
        }
    }
}