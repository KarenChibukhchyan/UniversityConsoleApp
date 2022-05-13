using System;
using UniversityConsoleApp.BL;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            Student[] students = (Student[])studentManager.Create(21,18);
            studentManager.Print(students);

            TeacherManager teacherManager = new TeacherManager();
            Teacher[] teachers = (Teacher[])teacherManager.Create(5, 19);
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
