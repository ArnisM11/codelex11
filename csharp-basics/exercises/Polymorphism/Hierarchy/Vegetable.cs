using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegetable : Food
    {
        public Vegetable()
        {
            Quantity= 0;
        }
        public Vegetable(int quantity) : base(quantity)
        {
            if (Quantity < 0)
            {
                throw new InvalidFoodException();
            }
        }
    }
}
