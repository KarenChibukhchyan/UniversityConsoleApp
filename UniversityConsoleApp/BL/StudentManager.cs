using System;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public class StudentManager
    {
        const short maxAge = 139;
        public static Student Create(string firstName, string lastName, int age) => new Student(firstName, lastName, age);
        public static Student[] Create(int count, int minAge)
        {
            Student[] students = new Student[count];
            Random rnd = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student($"name{i}", $"surName{i}", rnd.Next(minAge, maxAge));
            }
            return students;
        }

        public static void Print(Student student)
        {
            Console.WriteLine("**********  Student   **********");
            Console.WriteLine($"id:{student.ID} name:{student.FirstName} lastName:{student.LastName} age:{student.Age}");
            if (student.Teacher == null)
                Console.WriteLine("This student does not have a teacher!");
            else
                Console.WriteLine($"Teacher of this student: id:{student.Teacher.ID} name:{student.Teacher.FirstName} lastName:{student.Teacher.LastName} age:{student.Teacher.Age}");
            Console.WriteLine();
        }

        public static void Print(Student[] students)
        {
            for (int i = 0; i < students.Length; i++) Print(students[i]);
        }
    }
}
