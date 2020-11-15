using Rpegs.Items;

namespace Rpegs.Entities.Npcs
{
    public class Marauder : Humanoid, IWeapon, IHandEquipable
    {
        public Marauder()
        {
            Name = "Adam";
            Fraction = "Bandits";
            Experience = 100;
            Health = 100;
            WeaponDamage = 200;
        }

        public int WeaponDamage { get; set; }
        public bool OneHanded { get; set; }
        public bool HasEffect { get; set; }
        public bool IsAoe { get; set; }
        public string Description { get; set; }
        public bool CanBeCrafted { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
    }
}