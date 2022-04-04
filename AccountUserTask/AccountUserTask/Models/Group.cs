using AccountUserTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountUserTask.Models
{
    public class Group
    {
        private string _groupNo;
        private int _studentLimit;

        public string GroupNo
        {
            get { return _groupNo; }
            set { if (CheckGroupNo(value)) _groupNo = value; }
        }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set { if (value>=5 && value <=18) _studentLimit = value; }
        }
        public List<Student> Students { get; set; }

        public bool CheckGroupNo(string groupNo)
        {
            if(!String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
            {
                if(char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddStudent(Student student)
        {
            if (student == null) throw new ArgumentNullException();
            if (_studentLimit == 0) throw new Exception("Limit is 0");
            if(Students.Count == StudentLimit)
            {
                throw new StudentLimitException("Student Stack overflow");
            }
            Students.Add(student);
        }

        public Student GetStudent(int? studentId)
        {
            if (studentId == null) throw new ArgumentNullException();
            Student wantedStudent = Students.Find(x => x.Id == studentId);
            if (wantedStudent == null) throw new ArgumentOutOfRangeException();
            return wantedStudent;
        }

        public List<Student> GetAllStudents()
        {
            if (Students.Count == 0) throw new Exception("There is not any students in the list");
            return Students;

        }

    }
}
