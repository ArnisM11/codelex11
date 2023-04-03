using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class InvalidWeightException : Exception
    {
        public InvalidWeightException() :base("Provided weight is not valid."){ }
    }
}
