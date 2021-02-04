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
            double VENTA = 0;

            if (this.GetCurrentAge() >= 14 && this.GetCurrentAge() <= 18)
            {
                switch (this.Gender)
                {
                    case Biological_Gender.Masculino:
                        VENTA = (59.512 * this.Weight) - 30.4;
                        break;
                    case Biological_Gender.Feminino:
                        VENTA = (58.31 * this.Weight) - 31.1;
                        break;
                }
            }
            else if (this.GetCurrentAge() >= 19 && this.GetCurrentAge() <= 30)
            {
                switch (this.Gender)
                {
                    case Biological_Gender.Masculino:
                        VENTA = (14.818 * this.Weight) + 486.6;
                        break;
                    case Biological_Gender.Feminino:
                        VENTA = (15.057 * this.Weight) + 692.2;
                        break;
                }
            }
            else if (this.GetCurrentAge() >= 31 && this.GetCurrentAge() <= 60)
            {
                switch (this.Gender)
                {
                    case Biological_Gender.Masculino:
                        VENTA = (8.126 * this.Weight) + 845.6;
                        break;
                    case Biological_Gender.Feminino:
                        VENTA = (11.472 * this.Weight) + 873.1;
                        break;
                }
            }
            else
            {
                switch (this.Gender)
                {
                    case Biological_Gender.Masculino:
                        VENTA = (9.082 * this.Weight) + 658.5;
                        break;
                    case Biological_Gender.Feminino:
                        VENTA = (11.711 * this.Weight) + 587.7;
                        break;
                }
            }
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

        public void CalculateGETForLossAndGain()
        {
            switch (this.Gender)
            {
                case Biological_Gender.Masculino:
                    this.Daily_Calories = (13.397 * this.Weight) + (4.799 * this.Height) - (5.677 * this.GetCurrentAge()) + 88.362;
                    break;
                case Biological_Gender.Feminino:
                    this.Daily_Calories = (9.247 * this.Weight) + (3.098 * this.Height) - (4.330 * this.GetCurrentAge()) + 447.593;
                    break;
            }
        }

        public void CalculateGETForMaintenance()
        {
            switch (this.Gender)
            {
                case Biological_Gender.Masculino:
                    if ((this.GetCurrentAge() >= 9) && (this.GetCurrentAge() <= 18))
                    {
                        switch (this.Activity)
                        {
                            case Exercise_Activity.Sedentary:
                                this.Daily_Calories = 88.6 - (61.9 * this.GetCurrentAge()) + (1 * (26.7 * this.Weight + 903 * this.Height)) + 25;
                                break;
                            case Exercise_Activity.Light:
                                this.Daily_Calories = 88.6 - (61.9 * this.GetCurrentAge()) + (1.13 * (26.7 * this.Weight + 903 * this.Height)) + 25;
                                break;
                            case Exercise_Activity.Active:
                                this.Daily_Calories = 88.6 - (61.9 * this.GetCurrentAge()) + (1.26 * (26.7 * this.Weight + 903 * this.Height)) + 25;
                                break;
                            case Exercise_Activity.Very_Active:
                                this.Daily_Calories = 88.6 - (61.9 * this.GetCurrentAge()) + (1.42 * (26.7 * this.Weight + 903 * this.Height)) + 25;
                                break;
                        }
                    }
                    else
                    {
                        switch (this.Activity)
                        {
                            case Exercise_Activity.Sedentary:
                                this.Daily_Calories = 662 - (9.53 * this.GetCurrentAge()) + (1 * (15.91 * this.Weight + 539.6 * this.Height));
                                break;
                            case Exercise_Activity.Light:
                                this.Daily_Calories = 662 - (9.53 * this.GetCurrentAge()) + (1.11 * (15.91 * this.Weight + 539.6 * this.Height));
                                break;
                            case Exercise_Activity.Active:
                                this.Daily_Calories = 662 - (9.53 * this.GetCurrentAge()) + (1.25 * (15.91 * this.Weight + 539.6 * this.Height));
                                break;
                            case Exercise_Activity.Very_Active:
                                this.Daily_Calories = 662 - (9.53 * this.GetCurrentAge()) + (1.48 * (15.91 * this.Weight + 539.6 * this.Height));
                                break;
                        }
                    }
                    break;
                case Biological_Gender.Feminino:
                    if ((this.GetCurrentAge() >= 9) && (this.GetCurrentAge() <= 18))
                    {
                        switch (this.Activity)
                        {
                            case Exercise_Activity.Sedentary:
                                this.Daily_Calories = 135.3 - (30.8 * this.GetCurrentAge()) + (1 * (10.0 * this.Weight + 934 * this.Height)) + 25;
                                break;
                            case Exercise_Activity.Light:
                                this.Daily_Calories = 135.3 - (30.8 * this.GetCurrentAge()) + (1.16 * (10.0 * this.Weight + 934 * this.Height)) + 25;
                                break;
                            case Exercise_Activity.Active:
                                this.Daily_Calories = 135.3 - (30.8 * this.GetCurrentAge()) + (1.31 * (10.0 * this.Weight + 934 * this.Height)) + 25;
                                break;
                            case Exercise_Activity.Very_Active:
                                this.Daily_Calories = 135.3 - (30.8 * this.GetCurrentAge()) + (1.56 * (10.0 * this.Weight + 934 * this.Height)) + 25;
                                break;
                        }
                    }
                    else
                    {
                        switch (this.Activity)
                        {
                            case Exercise_Activity.Sedentary:
                                this.Daily_Calories = 354 - (6.91 * this.GetCurrentAge()) + (1 * (9.36 * this.Weight + 726 * this.Height));
                                break;
                            case Exercise_Activity.Light:
                                this.Daily_Calories = 354 - (6.91 * this.GetCurrentAge()) + (1.12 * (9.36 * this.Weight + 726 * this.Height));
                                break;
                            case Exercise_Activity.Active:
                                this.Daily_Calories = 354 - (6.91 * this.GetCurrentAge()) + (1.27 * (9.36 * this.Weight + 726 * this.Height));
                                break;
                            case Exercise_Activity.Very_Active:
                                this.Daily_Calories = 354 - (6.91 * this.GetCurrentAge()) + (1.45 * (9.36 * this.Weight + 726 * this.Height));
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
