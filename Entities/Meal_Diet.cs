using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Meal_Diet
    {
        public virtual Meal Meal { get; set; }
        public int MealID { get; set; }
        public virtual Diet Diet { get; set; }
        public int DietID { get; set; }

    }
}
