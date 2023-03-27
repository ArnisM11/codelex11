using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Vegetable : Food
    {
        public Vegetable()
        {
            Quantity= 0;
        }
        public Vegetable(int quantity) : base(quantity)
        {

        }
    }
}
