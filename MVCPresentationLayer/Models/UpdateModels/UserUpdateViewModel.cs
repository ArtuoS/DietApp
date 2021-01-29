using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.UpdateModels
{
    public class UserUpdateViewModel
    {
        public int ID { get; set; }
        [Display(Name = "First_Name")]
        public string First_Name { get; set; }
        [Display(Name = "Sobrenome")]
        public string Last_Name { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime Date_Of_Birthday { get; set; }
        [Display(Name = "Gênero")]
        public Biological_Gender Gender { get; set; }
        public string Email { get; set; }
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Peso")]
        public double Weight { get; set; }
        [Display(Name = "Altura")]
        public double Height { get; set; }
        [Display(Name = "Gordura Corporal")]
        public double BodyFat { get; set; }
    }
}
