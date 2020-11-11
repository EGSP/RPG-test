using System.Collections.Generic;
using Rpegs.BodyParts;
using Rpegs.Entities;
using Rpegs.Items;
using Rpegs.PlayerLogic;

namespace Rpegs.NPC
{
    public abstract class Npc : Entity
    {
        public string Fraction { get; set; }
        public List<Item> Loot { get; set; }
        public List<Item> AvailableDrop { get; set; }
    }

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
                if (right != null && right.CurrentlyEquipped is Weapon)
                {
                    var weapon = Equipment.RightHand.CurrentlyEquipped as Weapon;
                    weaponDamage += weapon.Damage;
                }

                if (left != null && left.CurrentlyEquipped is Weapon)
                {
                    var weapon = Equipment.LeftHand.CurrentlyEquipped as Weapon;
                    weaponDamage += weapon.Damage;
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
