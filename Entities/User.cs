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
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BodyFat { get; set; }
        public Exercise_Activity Activity { get; set; }
        public Objective Objective { get; set; }
        public double IMC { get; set; }
        public int Weight_Objective { get; set; }
        public int Days_To_Reach_Goal { get; set; }
        public double Daily_Calories { get; set; }
        public double Daily_Carbohydrates { get; set; }
        public double Daily_Fats { get; set; }
        public double Daily_Protein { get; set; }
        public bool Status { get; private set; }
        public string Role { get; set; }
        public ICollection<Diet> Diets { get; set; }
        public ICollection<Restriction> Restrictions { get; set; }

        public bool SetStatus(bool status)
        {
            return this.Status = status;
        }

        public int ReplaceGenderWithNumber(Biological_Gender gender)
        {
            if (gender == Biological_Gender.Feminino)
            {
                return 0;
            }
            return 1;
        }

        public double CalculateVENTA()
        {
            double VENTA = (7700 * (this.Weight - this.Weight_Objective)) / 30;
            return VENTA;
        }

        public void CalculateIMC()
        {
            this.IMC = this.Weight / (this.Height * this.Height);
        }

        public string IMCSituation()
        {
            if (this.IMC > 0)
            {
                if (this.IMC < 18.5)
                {
                    return "Underweight";
                }
                else if (this.IMC >= 18.5 && this.IMC <= 24.99)
                {
                    return "Normal";
                }
                else if (this.IMC >= 25 && this.IMC <= 29.99)
                {
                    return "Overweight";
                }
                else if (this.IMC >= 30 && this.IMC <= 34.99)
                {
                    return "Obese";
                }
                return "Extremely Obese";
            }
            return "ERROR IN IMC SITUATION!";
        }

        public int GetCurrentAge()
        {
            return (DateTime.Today.Year - this.Date_Of_Birthday.Year) - 1;
        }

        public void CalculateTMB()
        {
            double TMB = 0;
            switch (this.Gender)
            {
                case Biological_Gender.Masculino:
                    TMB = 66.5 + (13.75 * this.Weight) + (5.003 * this.Height) - (6.755 * this.GetCurrentAge());
                    break;
                case Biological_Gender.Feminino:
                    TMB = 665.1 + (9.563 * this.Weight) + (1.850 * this.Height) - (4.676 * this.GetCurrentAge());
                    break;
            }

            switch (this.Activity)
            {
                case Exercise_Activity.Sedentary:
                    TMB *= 1.2;
                    break;
                case Exercise_Activity.Light:
                    TMB *= 1.375;
                    break;
                case Exercise_Activity.Moderate:
                    TMB *= 1.55;
                    break;
                case Exercise_Activity.Active:
                    TMB *= 1.725;
                    break;
                case Exercise_Activity.Very_Active:
                    TMB *= 1.9;
                    break;
            }

            if ((this.Weight_Objective != 0) && (this.Days_To_Reach_Goal != 0))
            {
                // FAZER UNS CALCULOS AQUI!
            }

            this.Daily_Calories = TMB;
        }
    }
}
