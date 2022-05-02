using System;
using UniversityConsoleApp.BL;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = StudentManager.Create(21,18);
            StudentManager.Print(students);

            Teacher[] teachers = TeacherManager.Create(5, 19);
            TeacherManager.Print(teachers);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================== Assigning students to teachers ===================================");
            Console.WriteLine();
            Console.WriteLine();

            UniversityManager.SwapWithStudents(teachers, students);
            TeacherManager.Print(teachers);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================== Assigning students to teachers ===================================");
            Console.WriteLine();
            Console.WriteLine();

            UniversityManager.SwapWithTeachers(students, teachers);
            StudentManager.Print(students);


        }
    }
}
