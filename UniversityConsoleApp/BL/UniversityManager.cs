using System.Collections.Generic;
using UniversityConsoleApp.Models;
namespace UniversityConsoleApp.BL
{
    public class UniversityManager
    {
        public static List<Person> SwapWithStudents(List<Person> teachers,List<Person> students)
        {
            int minStCount = students.Count / teachers.Count;
            int lastStCount = minStCount + students.Count % teachers.Count;
            for (int i = 0; i < teachers.Count-1; i++)
            {
                Teacher teacher = (Teacher)teachers[i];
                teacher.Students = new List<Student>(minStCount);
                for (int j = 0; j < minStCount; j++)
                {
                    teacher.Students.Add((Student)students[i*minStCount +j]);
                }
            }
            ((Teacher)teachers[^1]).Students = new List<Student>(lastStCount);
            for (int i = 0 ; i < lastStCount; i++)
            {
                Teacher teacher = (Teacher)teachers[teachers.Count - 1];
                teacher.Students.Add((Student)students[minStCount*(teachers.Count - 1) + i]);
            }
            return teachers;
        }


        public static Person SwapWithTeacher(Student student,Teacher teacher)
        {
            student.Teacher = teacher;
            return student;
        }
        public static List<Person> SwapWithTeachers(List<Person> students, List<Person> teachers)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = (Student)students[i];
                student.Teacher = (Teacher)teachers[i % teachers.Count];
            }

            return students;
        }
        public static Teacher SwapWithStudent(Teacher teacher,List<Student> students)
        {
            teacher.Students = students;
            return teacher;
        }

   }
}


