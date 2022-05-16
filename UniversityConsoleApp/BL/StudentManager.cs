﻿using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class StudentManager : IManager, IPrint
    {
        public Person Create(string firstName, string lastName, int age) => new Student(firstName, lastName, age);

        public Person[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"name{i}", $"surName{i}", rnd.Next(minAge, IManager.maxAge));
            }

            return students;
        }

        public void Print(Person person)
        {
            Console.WriteLine("**********  Student   **********");
            Console.WriteLine($"id:{person.ID} name:{person.FirstName} lastName:{person.LastName} age:{person.Age}");
            if (person is Student)
            {
                if (((Student) person).Teacher == null)
                    Console.WriteLine("This student does not have a teacher!");
                else
                    Console.WriteLine(
                        $"Teacher of this student: id:{((Student) person).Teacher.ID} name:{((Student) person).Teacher.FirstName} lastName:{((Student) person).Teacher.LastName} age:{((Student) person).Teacher.Age}");
            }

            Console.WriteLine();
        }

        public void Print(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++) Print(persons[i]);
        }
    }
}