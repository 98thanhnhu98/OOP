using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    internal class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException(string erro)
        {
            Console.WriteLine(base.Message);
        }
    }
}
