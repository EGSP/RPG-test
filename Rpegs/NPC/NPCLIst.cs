using Rpegs.Items;
using Rpegs.PlayerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Rpegs.NPC;

namespace Rpegs.NPCLogic
{
    public class Marauder : Humanoid
    {
        public bool InCombat;
        public Marauder()
        {
            Name = "Adam";
            Fraction = "Bandits";
            Experience = 100;
            Health = 100;
        }
    }
}
