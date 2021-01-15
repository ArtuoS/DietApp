using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User_Diet
    {
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int DietID { get; set; }
        public virtual Diet Diet { get; set; }
    }
}
