using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class FoodCategory : IStatusService
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<Food> Foods { get; set; }

        public bool SetStatus(bool status)
        {
            return this.Status = status;
        }
    }
}
//negativa, interrogativa e passado