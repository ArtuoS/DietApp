using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Meal_Food
    {
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
        public int FoodID{ get; set; }
        public virtual Food Food { get; set; }

    }
}
