using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ13
{
    internal class NoJsonException : Exception
    {
        private string message;
        public NoJsonException ( string message) : base (message)
        {
            message = this.message;
        }
    }
}
