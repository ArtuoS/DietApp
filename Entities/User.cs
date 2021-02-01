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
        //public Exercise_Activity Activity { get; set; }
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
            return DateTime.Today.Year - birthday.Year;
        }

        public double CalculateDailyCalories(int age, double height, double weight, Biological_Gender gender)
        {
            //Exercise_Activity? activity <- parameter
            if (gender == Biological_Gender.Masculino)
                return (13.397 * weight) + (4.799 * height) - (5.677 * age) + 88.362;
            return (9.247 * weight) + (3.098 * height) - (4.330 * age) + 447.593;
        }
    }

}
