using System;
using System.Collections.Generic;
using System.Text;

namespace AccountUserTask.Models
{
    public class Student
    {
        private static int _id;

        public int Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }


        static Student()
        {
            _id = 0;
        }

        private Student()
        {
            Id = ++_id;
        }

        public Student(string fullname, double point)
        {
            FullName = fullname;
            Point = point;
        }


        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id} Fullname: {FullName} Point: {Point}");
        }
    }
}
