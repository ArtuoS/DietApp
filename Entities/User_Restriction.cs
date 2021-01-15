using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User_Restriction
    {
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int RestrictionID { get; set; }
        public virtual Restriction Restriction { get; set; }
    }
}
