using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.DeleteModels
{
    public class UserDeleteViewModel
    {
        [Display(Name = "Nome")]
        public string First_Name { get; set; }
        [Display(Name = "Sobrenome")]
        public string Last_Name { get; set; }
        public string Email { get; set; }
    }
}
