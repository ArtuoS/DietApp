using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class UserInsertViewModel
    {
        [Display(Name = "Nome")]
        public string First_Name { get; set; }
        [Display(Name = "Sobrenome")]
        public string Last_Name { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime Date_Of_Birthday { get; set; }
        [Display(Name = "Gênero")]
        public Biological_Gender Gender { get; set; }
        [Display(Name = "Atividade Física")]
        public Exercise_Activity Activity { get; set; }
        public Objective Objective { get; set; }
        public string Email { get; set; }
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Peso")]
        public double Weight { get; set; }
        [Display(Name = "Altura")]
        public double Height { get; set; }
        [Display(Name = "Gordura Corporal")]
        public double BodyFat { get; set; }
        [Display(Name = "Cargo")]
        public string Role { get; set; }
        [Display(Name = "Calorias")]
        public double Daily_Calories { get; set; }
        [Display(Name = "Carboidratos")]
        public double Daily_Carbohydrates { get; set; }
        [Display(Name = "Gorduras")]
        public double Daily_Fats { get; set; }
        [Display(Name = "Proteínas")]
        public double Daily_Protein { get; set; }
        [Display(Name = "Peso ideal")]
        public int Weight_Objective { get; set; }
        [Display(Name = "Dias para alcançar objetivo")]
        public int Days_To_Reach_Goal { get; set; }
        public List<int> FoodSelect { get; set; }
        //List<int> Foods = new List<int>();
    }
}
