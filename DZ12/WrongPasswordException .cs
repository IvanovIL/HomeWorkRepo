using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ12
{
    internal class WrongPasswordException : Exception
    {
        private string message;

        public WrongPasswordException(string message2) : base(message2)
        {
            message2 = message;
        }
    }
}
