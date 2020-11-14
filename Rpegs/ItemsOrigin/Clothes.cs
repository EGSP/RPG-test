using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.Items
{
    public abstract class Clothes : Item, IWearable
    {
        public double Protection { get; set; }
        public double Durablity { get; set; }
        public double CarryExpansion { get; set; }  
    }
}
