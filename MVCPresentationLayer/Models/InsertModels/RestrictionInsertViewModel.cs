using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Models.InsertModels
{
    public class RestrictionInsertViewModel
    {
        public string Name { get; set; }

        public virtual Food Food { get; set; }
    }
}
