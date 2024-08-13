using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static DZ12.Program;

namespace DZ12
{
    internal class WrongLoginException : Exception
    {
        private string message;

        public WrongLoginException(string message2) : base(message2)
        {
            message2 = message;
        }

    }
}
    
