﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Collections;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };

        //var studentNames = studentList.Where(s => s.Age > 18)
        //                      .Select(s => s)
        //                      .Where(st => st.StandardID > 0)
        //                      .Select(s => s.StudentName);




        //Example: Multiple Select and where Operator
        //var studentNames = studentList.Where(s => s.Age > 18)
        //                     .Select(s => s)
        //                     .Where(st => st.StandardID > 0)
        //                     .Select(s => s.StudentName);
        //foreach (var name in studentName)
        //{
        //    Console.WriteLine(name);
        //}



        //Example: LINQ Query returns Collection of Anonymous Objects

        //var teenStudentsName = from s in studentList
        //                       where s.Age > 12 && s.Age < 20
        //                       select new { StudentName = s.StudentName };

        //teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));



        //}
        //Example: LINQ GroupBy Query - C#
        var studentsGroupByStandard = from s in studentList
                                      group s by s.StandardID into sg
                                      orderby sg.Key
                                      select new { sg.Key, sg };


        foreach (var group in studentsGroupByStandard)
        {
            Console.WriteLine("StandardID {0}:", group.Key);

            group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
        }
    }

          public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

}


