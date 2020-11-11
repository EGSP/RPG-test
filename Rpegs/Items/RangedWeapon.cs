namespace Rpegs.Items
{
    public abstract class RangedWeapon : Weapon
    { 
        public int Durablity { get; set; }
        public double Accuracy { get; set; }
        public string AmmoType { get; set; }
        public int Range { get; set; }
    }
}