using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class FoodCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
//negativa, interrogativa e passado