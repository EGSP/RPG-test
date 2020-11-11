using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpegs.BodyParts;
using Rpegs.Entities;
using Rpegs.Items.Weapons;
using Rpegs.NPC;
using Rpegs.PlayerLogic;

namespace Rpegs.NPC
{
    public class Robber : Humanoid
    {
        public Robber() : base()
        {
            Name = "Jobert";
            Fraction = "Bandits";
            Experience = 150;
            Health = 70;

            // Левая хоровая
            Equipment.Equip(new HumanoidHand(2), true);
            // Правая пороховая
            Equipment.Equip(new HumanoidHand(23), false);
        }

    }
}
