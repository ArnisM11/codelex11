using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class InvalidProductCountException : Exception
    {
        public InvalidProductCountException() :base("Invalid product count entered."){ }
    }
}
