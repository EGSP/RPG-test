﻿using System.Collections.Generic;
using Rpegs.Entities;
using Rpegs.Items;

namespace Rpegs.NPC
{
    public abstract class Npc : Entity
    {
        public string Fraction { get; set; }
        public List<Item> Loot { get; set; }
        public List<Item> AvailableDrop { get; set; }
    }
}
