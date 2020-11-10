namespace Rpegs.Items
{
    public class Colt : RangedWeapon
    {
        public Colt()
        {
            Name = "M1911";
            Description = "The M1911, also known as the Colt 1911. M1911 is the best-known of his designs to use the short recoil principle in its basic design";
            CanBeCrafted = false;
            Value = 200;
            Weight = 2.3;

            Damage = 25;
            OneHanded = true;
            HasEffect = false;
            IsAOE = false;

            Durablity = 100;
            Accuracy = 0.8;
            AmmoType = ".45ACP";
            Range = 75;
        }
    }
}
