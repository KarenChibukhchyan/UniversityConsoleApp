using System;
using System.Collections.Generic;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class StudentManager : IManager, IPrint
    {
        public Person Create(string firstName, string lastName, int age) => new Student(firstName, lastName, age);

        public List<Person> Create(int count, int minAge)
        {
            List<Person> students = new List<Person>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                students.Add(new Student($"name{i}", $"surName{i}", rnd.Next(minAge, IManager.maxAge)));
            }

            return students;
        }

        public void Print(Person person)
        {
            if (person is Student)
            {
                Console.WriteLine("**********  Student   **********");
                Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
                Student student = (Student) person;
                if (student.Teacher == null)
                    Console.WriteLine("This student does not have a teacher!");
                else
                    Console.WriteLine(
                        $"Teacher of this student: id:{student.Teacher.ID} name:{student.Teacher.FirstName} lastName:{student.Teacher.LastName} age:{student.Teacher.Age}");
            }

            Console.WriteLine();
        }

        public void Print(List<Person> students)
        {
            for (int i = 0; i < students.Count; i++) Print(students[i]);
        }
    }
}