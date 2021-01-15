using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class DietInsertViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public virtual Food Foods { get; set; }
    }
}
