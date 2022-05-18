using System;
using System.Collections.Generic;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class TeacherManager : IManager<Teacher>, IPrint<Teacher>
    {
        public Teacher Create(string firstName, string lastName, int age) => new Teacher(firstName, lastName, age);

        public List<Teacher> Create(int count, int minAge)
        {
            List<Teacher> teachers = new List<Teacher>(count);
            Random rnd = new Random();
            for (int i = 0; i < teachers.Count; i++)
            {
                teachers.Add(new Teacher($"name{i}", $"surName{i}", rnd.Next(minAge, IManager<Teacher>.maxAge)));
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