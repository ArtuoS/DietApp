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

        public int GetCurrentAge(DateTime birthday)
        {
            return (DateTime.Today.Year - birthday.Year) - 1;
        }

        public void CalculateDailyNeeds()
        {
            //Exercise_Activity? activity <- parameter
            if (this.Gender == Biological_Gender.Masculino)
                this.Daily_Calories = (13.397 * this.Weight) + (4.799 * this.Height) - (5.677 * this.GetCurrentAge(this.Date_Of_Birthday)) + 88.362;
            else
                this.Daily_Calories = (9.247 * this.Weight) + (3.098 * this.Height) - (4.330 * this.GetCurrentAge(this.Date_Of_Birthday)) + 447.593;

            this.Daily_Carbohydrates = this.Daily_Calories * 0.4;
            this.Daily_Protein = this.Daily_Calories * 0.4;
            this.Daily_Fats = this.Daily_Calories * 0.2;

            switch (this.Objective)
            {
                case Objective.Weight_Loss:
                    switch (this.Activity)
                    {
                        case Exercise_Activity.Sedentary:
                            this.Daily_Carbohydrates *= 0.5;
                            this.Daily_Protein *= 0.5;
                            this.Daily_Fats *= 0.5;
                            break;
                        case Exercise_Activity.Light:
                            this.Daily_Carbohydrates *= 0.6;
                            this.Daily_Protein *= 0.6;
                            this.Daily_Fats *= 0.6;
                            break;
                        case Exercise_Activity.Moderate:
                            this.Daily_Carbohydrates *= 0.7;
                            this.Daily_Protein *= 0.7;
                            this.Daily_Fats *= 0.7;
                            break;
                        case Exercise_Activity.Active:
                            this.Daily_Carbohydrates *= 0.8;
                            this.Daily_Protein *= 0.8;
                            this.Daily_Fats *= 0.8;
                            break;
                        case Exercise_Activity.VeryActive:
                            this.Daily_Carbohydrates *= 0.9;
                            this.Daily_Protein *= 0.9;
                            this.Daily_Fats *= 0.9;
                            break;
                    }
                    break;
                case Objective.Maintenance:
                    return;
                case Objective.Mass_Gain:
                    switch (this.Activity)
                    {
                        case Exercise_Activity.Sedentary:
                            this.Daily_Carbohydrates *= 1.1;
                            this.Daily_Protein *= 1.1;
                            this.Daily_Fats *= 1.1;
                            break;
                        case Exercise_Activity.Light:
                            this.Daily_Carbohydrates *= 1.2;
                            this.Daily_Protein *= 1.2;
                            this.Daily_Fats *= 1.2;
                            break;
                        case Exercise_Activity.Moderate:
                            this.Daily_Carbohydrates *= 1.3;
                            this.Daily_Protein *= 1.3;
                            this.Daily_Fats *= 1.3;
                            break;
                        case Exercise_Activity.Active:
                            this.Daily_Carbohydrates *= 1.4;
                            this.Daily_Protein *= 1.4;
                            this.Daily_Fats *= 1.4;
                            break;
                        case Exercise_Activity.VeryActive:
                            this.Daily_Carbohydrates *= 1.5;
                            this.Daily_Protein *= 1.5;
                            this.Daily_Fats *= 1.5;
                            break;
                    }
                    break;
            }
        }
    }
}
