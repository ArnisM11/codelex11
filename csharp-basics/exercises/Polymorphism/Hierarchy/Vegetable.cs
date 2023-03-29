using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegetable : Food
    {
        public Vegetable() { }
        public Vegetable(int quantity) : base(quantity)
        {
            if (quantity < 0)
            {
                throw new InvalidFoodException();
            }
            Quantity = quantity;
        }
    }
}
