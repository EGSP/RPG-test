using Rpegs.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.Entities
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public double Protection { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public double Experience { get; set; }
    }
}
