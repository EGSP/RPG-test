namespace Rpegs.Items
{
    public interface IWeapon
    {
        int WeaponDamage { get; set; }
        bool OneHanded { get; set; }
        bool HasEffect { get; set; }
        bool IsAoe { get; set; }
    }
}