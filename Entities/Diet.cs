using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Diet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int FoodID { get; set; }
        public virtual Food Foods { get; set; }
        public bool Status { get; set; }
    }
}
