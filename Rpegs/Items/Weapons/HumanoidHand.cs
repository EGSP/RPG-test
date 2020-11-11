﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.Items.Weapons
{
    public class HumanoidHand : MeleeWeapon
    {
        public HumanoidHand()
        {
            Name = "Humanoid hand";
            // Вечные.
            Durablity = -1;
        }

        public HumanoidHand(int baseDamage) : this()
        {
            Damage = baseDamage;
        }
    }
}
