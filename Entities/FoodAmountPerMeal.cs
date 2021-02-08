using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    public class FoodAmountPerMeal {
        public int ID { get; set; }
        public Food Food { get; set; }
        public double Quantity { get; set; }
        public Units_Of_Measurement Unit { get; set; }
    }
}
