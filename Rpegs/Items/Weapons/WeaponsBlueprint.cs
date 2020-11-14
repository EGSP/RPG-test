using Rpegs.Items;

namespace Rpegs.Blueprints
{
    public class WeaponBlueprint : RangedWeapon
    {
        public WeaponBlueprint()
        {
            Name = null;
            Description = null;
            CanBeCrafted = false;
            Value = 0;
            Weight = 0;

            WeaponDamage = 0;
            OneHanded = false;
            HasEffect = false;

            Durablity = 0;
            Accuracy = 0;
            AmmoType = null;
            Range = 0;
        }
    }
}
