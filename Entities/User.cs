using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_Of_Birthday { get; set; }
        public Biological_Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Weigth { get; set; }
        public double Heigth { get; set; }
        public double BodyFat { get; set; }
        public ICollection<Diet> Diets { get; set; }
        public ICollection<Restriction> Restrictions { get; set; }
        //public bool IsAdm { get; set; }
        public bool Status { get; private set; }

        public bool SetStatus(bool status)
        {
            return this.Status = status;
        }
    }

}
