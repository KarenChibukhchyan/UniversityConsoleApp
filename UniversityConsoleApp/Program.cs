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
            TeacherManager teacherManager = new TeacherManager();
            UniversityManager universityManager = new UniversityManager();

            Student[] students = studentManager.Create(21,18);
            studentManager.Print(students);

            Teacher[] teachers = teacherManager.Create(5, 19);
            teacherManager.Print(teachers);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================== Assigning students to teachers ===================================");
            Console.WriteLine();
            Console.WriteLine();

            universityManager.SwapWithStudents(teachers, students);
            teacherManager.Print(teachers);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=================================== Assigning students to teachers ===================================");
            Console.WriteLine();
            Console.WriteLine();

            universityManager.SwapWithTeachers(students, teachers);
            studentManager.Print(students);


        }
    }
}
