using System;
using Rpegs.Items;

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
