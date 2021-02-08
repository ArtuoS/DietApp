using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities {
    public class Meal {
        public int ID { get; set; }
        public string Name { get; set; }
        public Categoria_Refeicao Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public double Total_Calories { get; set; }
        public double Total_Carbohydrates { get; set; }
        public double Total_Proteins { get; set; }
        public double Total_Lipids { get; set; }
        public ICollection<FoodAmountPerMeal> Foods { get; set; }
        public ICollection<Diet> Diets { get; set; }

        public void CalcularTotalCalorias() {
            if (Foods != null) {
                foreach (FoodAmountPerMeal item in Foods) {
                    this.Total_Calories += item.Food.Calories * item.Quantity;
                }
            }
        }

        public void CalcularTotalCarboidratos() {
            if (Foods != null) {
                foreach (FoodAmountPerMeal item in Foods) {
                    this.Total_Carbohydrates += item.Food.Carbohydrate * item.Quantity;
                }
            }
        }

        public void CalcularTotalProteinas() {
            if (Foods != null) {
                foreach (FoodAmountPerMeal item in Foods) {
                    this.Total_Proteins += item.Food.Protein * item.Quantity;
                }
            }
        }

        public void CalcularTotalGorduras() {
            if (Foods != null) {
                foreach (FoodAmountPerMeal item in Foods) {
                    this.Total_Lipids += item.Food.Lipid * item.Quantity;
                }
            }

        }
    }
}
