using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpegs.Items
{
    public abstract class Weapon : Item, IHandEquipable, IWeapon
    {
        public int WeaponDamage { get; set; }
        public bool OneHanded { get; set; }
        public bool HasEffect { get; set; }
        public bool IsAoe { get; set; }
    }

    public interface IWeapon
    {
        int WeaponDamage { get; set; }
        bool OneHanded { get; set; }
        bool HasEffect { get; set; }
        bool IsAoe { get; set; }
    }
}
