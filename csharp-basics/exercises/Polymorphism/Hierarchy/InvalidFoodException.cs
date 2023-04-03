using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class InvalidFoodException : Exception
    {
        public InvalidFoodException() : base("Invalid food provided")
        {
        }
    }
}
