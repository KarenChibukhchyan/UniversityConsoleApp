using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class TeacherManager : IManager, IPrint
    {
        public Person Create(string firstName, string lastName, int age) => new Teacher(firstName, lastName, age);

        public Person[] Create(int count, int minAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"name{i}", $"surName{i}", rnd.Next(minAge, IManager.maxAge));
            }

            return teachers;
        }

        public void Print(Person person)
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

        public void Print(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++) Print(persons[i]);
        }

    }
}