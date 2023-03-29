using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class InvalidRegionException : Exception
    {
        public InvalidRegionException(): base("Invalid region provided.") { }
    }
}
