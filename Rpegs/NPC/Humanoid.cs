using Rpegs.BodyParts;
using Rpegs.Entities;
using Rpegs.Items;
using Rpegs.PlayerLogic;

namespace Rpegs.NPC
{
    public abstract class Humanoid : Npc, IHaveInventory, IDamagable
    {
        protected Humanoid()
        {
            Inventory = new Inventory();
            Equipment = new Equipment(this);
        }
        public override int Damage 
        {
            get
            {
                int weaponDamage = 0;
                var right = Equipment.RightHand;
                var left = Equipment.LeftHand;
                if (right != null && right.CurrentlyEquipped is IWeapon)
                {
                    var weapon = Equipment.RightHand.CurrentlyEquipped as IWeapon;
                    weaponDamage += weapon.WeaponDamage;
                }

                if (left != null && left.CurrentlyEquipped is IWeapon)
                {
                    var weapon = Equipment.LeftHand.CurrentlyEquipped as IWeapon;
                    weaponDamage += weapon.WeaponDamage;
                }

                return weaponDamage;
            }
        }
        public Inventory Inventory { get; }
        public readonly Equipment Equipment;
        public int Health { get; set; }
        public bool Dead => Health <= 0;
        public double Protection { get; set; }

        public void ReceiveDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }
    }
}