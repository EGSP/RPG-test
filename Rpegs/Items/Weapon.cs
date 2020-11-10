using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.Items
{
    public abstract class Weapon : Item, IHandEquipable
    {
        public int Damage { get; set; }
        public bool OneHanded { get; set; }
        public bool HasEffect { get; set; }
        public bool IsAOE { get; set; }

        public override string ToString()
        {
            if (Name.Length > 0)
            {
                return Name;
            }

            return GetType().Name;
        }
    }

    public abstract class MeleeWeapon : Weapon
    {
        public int Durablity { get; set; }
    }

    public abstract class RangedWeapon : Weapon
    { 
        public int Durablity { get; set; }
        public double Accuracy { get; set; }
        public string AmmoType { get; set; }
        public int Range { get; set; }
    }
}
