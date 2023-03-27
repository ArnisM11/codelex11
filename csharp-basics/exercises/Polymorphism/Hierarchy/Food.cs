using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        public Food()
        {
            Quantity = 0;
        }
        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
