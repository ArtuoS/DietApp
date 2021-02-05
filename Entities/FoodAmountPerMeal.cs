using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    [Keyless]
    public class FoodAmountPerMeal
    {
        public Food Food { get; set; }
        public Meal Meal { get; set; }
        public double Quantity { get; set; }
    }
}
