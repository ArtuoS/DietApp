using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.UpdateModels
{
    public class UserUpdateViewModel
    {
        [Display(Name = "Nome")]
        public string First_Name { get; set; }
        [Display(Name = "Sobrenome")]
        public string Last_Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Peso")]
        public double Weigth { get; set; }
        [Display(Name = "Altura")]
        public double Heigth { get; set; }
    }
}
