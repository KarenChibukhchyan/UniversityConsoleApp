using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class TeacherManager : BaseManager
    {
        const short maxAge = 139;

        public override Person Create(string firstName, string lastName, int age) => new Person(firstName, lastName, age);

        public override Person[] Create(int count, int minAge)
        {
            Person[] persons = new Person[count];
            Random rnd = new Random();
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person($"name{i}", $"surName{i}", rnd.Next(minAge, maxAge));
            }

            return persons;
        }

        public override void Print(Person person)
        {
            Console.WriteLine("**********  Person  **********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
            if (((Teacher)person).Students == null) Console.WriteLine("This person does not have students!");
            else
            {
                Console.WriteLine("Students of this teache:");
                for (int i = 0; i < ((Teacher)person).Students.Length; i++)
                {
                    Console.WriteLine($"id:{((Teacher)person).Students[i].ID} name:{((Teacher)person).Students[i].FirstName} lastName:{((Teacher)person).Students[i].LastName} age:{((Teacher)person).Students[i].Age}");
                }
            }
            Console.WriteLine();
        }

        public override void Print(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++) Print(persons[i]);
        }

    }
}