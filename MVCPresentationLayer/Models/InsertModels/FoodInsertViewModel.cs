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
		
		[Display(Name = "Categoria")]
		public FoodCategory Category { get; set; }
		[Display(Name = "Nome do Alimento")]
		public string Food_Name { get; set; }
		[Display(Name = "Calorias")]
		public double Calories { get; set; }
		[Display(Name = "Álcool")]
		public double Alcohol { get; set; }
		[Display(Name = "Carboidratos")]
		public double Carbohydrate { get; set; }
		[Display(Name = "Cobre")]
		public double Copper { get; set; }
		[Display(Name = "Fibra")]
		public double Fiber { get; set; }
		[Display(Name = "Lipídios")]
		public double Lipid { get; set; }
		[Display(Name = "Margnésio")]
		public double Magnesium { get; set; }
		[Display(Name = "Fósforo")]
		public double Phosphor { get; set; }
		[Display(Name = "Potássio")]
		public double Potassium { get; set; }
		[Display(Name = "Proteína")]
		public double Protein { get; set; }
		[Display(Name = "Sódio")]
		public double Sodium { get; set; }
		[Display(Name = "Selenio")]
		public double Selenium { get; set; }
		[Display(Name = "Vitamina A")]
		public double Vitamin_A { get; set; }
		[Display(Name = "Vitamina C")]
		public double Vitamin_C { get; set; }
		[Display(Name = "Vitamina D")]
		public double Vitamin_D { get; set; }
		[Display(Name = "Vitamina E")]
		public double Vitamin_E { get; set; }
		[Display(Name = "Vitamina B6")]
		public double Vitamin_B6 { get; set; }
		[Display(Name = "Vitamina B12")]
		public double Vitamin_B12 { get; set; }
		[Display(Name = "Zinco")]
		public double Zinc { get; set; }
	}
}
