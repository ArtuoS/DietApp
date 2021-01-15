using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Meal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }
        public ICollection<Food> Foods { get; set; }
        public ICollection<Diet> Diets { get; set; }
    }
}
