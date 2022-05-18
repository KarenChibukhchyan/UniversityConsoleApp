using System;
using System.Collections.Generic;
using UniversityConsoleApp.BL;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            List<Person> students = studentManager.Create(21,18);
            studentManager.Print(students);

            TeacherManager teacherManager = new TeacherManager();
            List<Person> teachers = teacherManager.Create(5, 19);
            teacherManager.Print(teachers);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================== Assigning students to teachers ===================================");
            Console.WriteLine();
            Console.WriteLine();

            UniversityManager.SwapWithStudents(teachers, students);
            teacherManager.Print(teachers);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================== Assigning students to teachers ===================================");
            Console.WriteLine();
            Console.WriteLine();

            UniversityManager.SwapWithTeachers(students, teachers);
            studentManager.Print(students);


        }
    }
}
