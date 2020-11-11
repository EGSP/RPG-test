using Rpegs.Items;
using Rpegs.PlayerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Rpegs.NPCLogic
{
    public class Marauder : NPCBehaviour
    {
        public bool InCombat;
        public Marauder()
        {
            Name = "Adam";
            Fraction = "Bandits";
            Experience = 100;
            Damage = 10;
            Health = 100;
        }
    }
}
