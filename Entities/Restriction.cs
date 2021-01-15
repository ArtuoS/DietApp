using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Restriction
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual Food Food { get; set; }

        public int IDFood { get; set; }
    }
}
