using Rpegs.Entities;
using Rpegs.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.NPCLogic
{
    public abstract class NPC : Entity
    {
        public string Fraction { get; set; }
        public List<Item> Loot { get; set; }
        public List<Item> AvailableDrop { get; set; }
    }
}
