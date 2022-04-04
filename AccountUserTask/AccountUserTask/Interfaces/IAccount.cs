using System;
using System.Collections.Generic;
using System.Text;

namespace AccountUserTask.Interfaces
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
