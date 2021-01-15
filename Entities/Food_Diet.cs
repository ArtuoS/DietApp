using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Food_Diet
    {
        public int FoodID { get; set; }

        public virtual Food Food { get; set; }

        public int DietID { get; set; }

        public virtual Diet Diet { get; set; }
    }
}
