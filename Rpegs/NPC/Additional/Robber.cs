using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpegs.BodyParts;
using Rpegs.Items.Weapons;
using Rpegs.PlayerLogic;

namespace Rpegs.NPCLogic
{
    public class Robber : NPCBehaviour
    {
        public readonly Inventory Inventory;
        public readonly Equipment Equipment;
        public Robber()
        {
            Name = "Jobert";
            Fraction = "Bandits";
            Experience = 150;
            Damage = -1;
            Health = 70;

            // Экипировку нужно отвязать от игрока.
            // Inventory = new Inventory();
            // Equipment = new Equipment(this);

            // // Левая хоровая
            // Equipment.Equip(new HumanoidHand(7), true);
            // // Правая пороховая
            // Equipment.Equip(new HumanoidHand(11), false);
        }

    }
}
