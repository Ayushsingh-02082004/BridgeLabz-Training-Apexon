using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        // To print meaningful output
        public override string ToString()
        {
            return $"{StudentID} - {StudentName} - {Age}";
        }
    }

    internal class Whereclause
    {
        public void Teenager()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13 },
                new Student() { StudentID = 2, StudentName = "Moin", Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 },
                new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron", Age = 15 }
            };

            // 1️⃣ Where clause (Teenagers: age > 12 && < 18)
            var filteredResult = from s in studentList
                                 where s.Age > 12 && s.Age < 18
                                 select s;

            // 2️⃣ Where with index (select even-indexed elements)
            var evenIndexStudents = studentList.Where((s, i) => i % 2 == 0);

            // 3️⃣ OrderBy StudentName
            var orderByResult = from s in studentList
                                orderby s.StudentName
                                select s;

            Console.WriteLine("Teenage Students:");
            foreach (var s in filteredResult)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nStudents at Even Index:");
            foreach (var s in evenIndexStudents)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nStudents Ordered by Name:");
            foreach (var s in orderByResult)
            {
                Console.WriteLine(s);
            }
        }
    }

    //class Program
    //{
        //static void Main(string[] args)
        //{
        //    Whereclause obj = new Whereclause();
        //    obj.Teenager();

        //    Console.ReadLine();
        //}
    //}
}
