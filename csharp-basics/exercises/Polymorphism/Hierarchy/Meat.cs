using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Meat : Food
    {
        public Meat() { }
        public Meat(int quantity) : base(quantity)
        {
            if (Quantity < 0)
            {
                throw new InvalidFoodException();
            }
        }
    }
}
