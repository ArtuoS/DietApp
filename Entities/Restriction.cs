using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Restriction
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Food> Foods { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
