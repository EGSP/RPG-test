using Rpegs.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.NPCLogic
{
    public abstract class NPC
    {
        public string Name { get; set; }
        public string Fraction { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public double Experience { get; set; }
        public List<Item> Loot { get; set; }
        public List<Item> AvailableDrop { get; set; }
    }
}
