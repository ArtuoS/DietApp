using Common;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class UserInsertViewModel
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_Of_Birthday { get; set; }
        public Biological_Gender Gender { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public double Weigth { get; set; }
        public double Heigth { get; set; }
        public double BodyFat { get; set; }
    }
}
