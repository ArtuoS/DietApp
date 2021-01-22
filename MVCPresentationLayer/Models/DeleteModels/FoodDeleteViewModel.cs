using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.DeleteModels
{
    public class FoodDeleteViewModel
    {
        [Display(Name = "Categoria")]
        public Food_Category Category { get; set; }
        [Display(Name = "Nome do Alimento")]
        public string Food_Name { get; set; }
    }
}
