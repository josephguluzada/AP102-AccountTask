using AccountUserTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountUserTask.Models
{
    public class User : IAccount
    {
        private static int _id;
        private string _password;

        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get { return _password; }
            set { if (PasswordChecker(value)) _password = value; }
        }

        static User()
        {
            _id = 0;
        }

        private User()
        {
            Id = ++_id;
        }

        public User(string email,string password):this()
        {
            Email = email;
            Password = password;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} Fullname: {FullName} Email: {Email}");
        }

        public bool PasswordChecker(string password) // Sa1am123
        {
            if (!String.IsNullOrEmpty(password) && !String.IsNullOrWhiteSpace(password) && password.Length >= 8)
            {
                bool isUpper = false;
                bool isLower = false;
                bool isDigit = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i])) isUpper = true;
                    else if (char.IsLower(password[i])) isLower = true;
                    else if (char.IsDigit(password[i])) isDigit = true;

                    if (isUpper && isLower && isDigit) return true;

                }
            }
            return false;
        }


        // Static PassworChecker()
        public static bool PasswordCheckerStatic(string password)
        {
            User user = new User();
            return user.PasswordChecker(password);
        }
    }
}
