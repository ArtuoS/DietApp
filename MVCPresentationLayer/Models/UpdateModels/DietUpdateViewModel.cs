﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.UpdateModels
{
    public class DietUpdateViewModel
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
    }
}
