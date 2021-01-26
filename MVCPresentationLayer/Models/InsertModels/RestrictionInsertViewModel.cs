using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class RestrictionInsertViewModel
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
