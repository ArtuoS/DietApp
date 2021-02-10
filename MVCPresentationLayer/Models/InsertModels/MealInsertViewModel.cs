using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class MealInsertViewModel
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Categoria")]
        public Meal_Category Category { get; set; }
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Display(Name = "Imagem")]
        public string Image { get; set; }
        public List<FoodAmountPerMeal> Foods { get; set; }
    }
}
