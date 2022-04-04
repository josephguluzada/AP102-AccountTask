using AccountUserTask.Models;
using System;

namespace AccountUserTask
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("salam@gmail.com","Salam123");
            User user2 = new User("salam@gmail.com","Salam123");

            Console.WriteLine(user1.Id +" " + user2.Id);

            Group group = new Group();

            Console.WriteLine(group.CheckGroupNo("GG111"));

            foreach (var item in group.GetAllStudents())
            {
                item.StudentInfo();
            }
        }
    }
}
