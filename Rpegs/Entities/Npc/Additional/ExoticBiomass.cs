using Rpegs.Items;

namespace Rpegs.Entities.Npcs
{
    public class ExoticBiomass : Npc, IHandsWearable, IHandEquipable, IWeapon
    {
        public ExoticBiomass()
        {
            Description = "Is it alive?";

            Weight = 5;

            WeaponDamage = 34;
        }

        public override int Damage => WeaponDamage;

        public string Description { get; set; }
        public bool CanBeCrafted { get; set; }
        // Значение.. Что за значение, а главное для чего..?
        public double Value { get; set; }
        public double Weight { get; set; }
        public int WeaponDamage { get; set; }
        public bool OneHanded { get; set; }
        // Эффект.. Какой эффект? Бабочки?
        public bool HasEffect { get; set; }
        // Аое? Возможно, но слишком редкое явление, зачем это всем?...............?А?
        public bool IsAoe { get; set; }
    }
}