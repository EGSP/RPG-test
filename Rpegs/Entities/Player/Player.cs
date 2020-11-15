using Rpegs.Items;
using Rpegs.Entities.Npcs;

namespace Rpegs.Entities.Player
{
    public class Player : Entity, IHaveInventory, IDamagable
    {
        public Player()
        {
            Inventory = new Inventory();
            Equipment = new Equipment(this);
        }

        public Inventory Inventory { get; private set; }
        public Equipment Equipment { get; private set; }
        public double CarriedWeight { get; set; }
        public double ExpThresold { get; set; }
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

        public int Health { get; set; }
        public double Protection { get; set; }

        public bool Dead => Health <= 0;

        public void ReceiveExperience(Npc npc, Player player)
        {
            player.Experience += npc.Experience;
            if(player.Experience >= player.ExpThresold)
            {
                player.Experience -= player.ExpThresold;
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            ExpThresold = ExpThresold + (ExpThresold * 0.75);
        }

        public void Equip(IHandEquipable item, bool left)
        {
            Equipment.Equip(item, left);
        }

        public void Wear(Item wearable)
        {
            Equipment.Wear(wearable);
        }

        public void ReceiveDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }
    }
}
