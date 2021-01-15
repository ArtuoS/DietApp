using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class FoodInsertViewModel
    {
		public Food_Category Category { get; set; }

		public string Food_Name { get; set; }

		public double Calories { get; set; }
		public double Alcohol { get; set; }
		public double Carbohydrate { get; set; }
		public double Copper { get; set; }
		public double Fiber { get; set; }
		public double Lipid { get; set; }
		public double Magnesium { get; set; }
		public double Phosphor { get; set; }
		public double Potassium { get; set; }
		public double Protein { get; set; }
		public double Sodium { get; set; }
		public double Selenium { get; set; }
		public double Vitamin_A { get; set; }
		public double Vitamin_C { get; set; }
		public double Vitamin_D { get; set; }
		public double Vitamin_E { get; set; }
		public double Vitamin_B6 { get; set; }
		public double Vitamin_B12 { get; set; }
		public double Zinc { get; set; }
	}
}
