using Common;
using Entities.Enums;
using Entities.Factory;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Diet
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public bool Status { get; set; }
        public int UserID { get; set; }

        public bool SetStatus(bool status)
        {
            return this.Status = status;
        }
    }
}
