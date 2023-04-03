using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class InvalidTypeException : Exception
    {
        public InvalidTypeException() : base("Invalid type provided."){ }
    }
}
