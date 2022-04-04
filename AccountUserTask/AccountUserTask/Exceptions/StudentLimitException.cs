using System;
using System.Collections.Generic;
using System.Text;

namespace AccountUserTask.Exceptions
{
    class StudentLimitException :Exception
    {
        public StudentLimitException(string message):base(message)
        {

        }
    }
}
