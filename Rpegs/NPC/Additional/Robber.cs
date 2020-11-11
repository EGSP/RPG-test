using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpegs.BodyParts;
using Rpegs.Entities;
using Rpegs.Items.Weapons;
using Rpegs.PlayerLogic;

namespace Rpegs.NPCLogic
{
    public class Robber : NPCBehaviour, IHaveInventory
    {
        public Inventory Inventory { get; private set; }
        public readonly Equipment Equipment;
        public Robber()
        {
            Name = "Jobert";
            Fraction = "Bandits";
            Experience = 150;
            Damage = 0;
            Health = 70;

            Inventory = new Inventory();
            Equipment = new Equipment(this);

            // Левая хоровая
            Equipment.Equip(new HumanoidHand(2), true);
            // Правая пороховая
            Equipment.Equip(new HumanoidHand(23), false);
        }

    }
}
