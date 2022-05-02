using System;
using UniversityConsoleApp.Models;

namespace UniversityConsoleApp.BL
{
    public class TeacherManager
    {
        const short maxAge = 139;

        public static Teacher Create(string firstName, string lastName, int age) => new Teacher(firstName, lastName, age);

        public static Teacher[] Create(int count, int minAge)
        {
            Teacher[] teachers = new Teacher[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {
                teachers[i] = new Teacher($"name{i}", $"surName{i}", rnd.Next(minAge, maxAge));
            }

            return teachers;
        }

        public static void Print(Teacher teacher)
        {
            Console.WriteLine("**********  Teacher  **********");
            Console.WriteLine($"id:{teacher._id} name:{teacher._firstName} lastName:{teacher._lastName} age:{teacher._age}");
            if (teacher._students == null) Console.WriteLine("This teacher does not have students!");
            else
            {
                Console.WriteLine("Students of this teache:");
                for (int i = 0; i < teacher._students.Length; i++)
                {
                    Console.WriteLine($"id:{teacher._students[i]._id} name:{teacher._students[i]._firstName} lastName:{teacher._students[i]._lastName} age:{teacher._students[i]._age}");
                }
            }
            Console.WriteLine();
        }

        public static void Print(Teacher[] teachers)
        {
            for (int i = 0; i < teachers.Length; i++) Print(teachers[i]);
        }

    }
}