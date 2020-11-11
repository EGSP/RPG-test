using Rpegs.Items;
using Rpegs.BodyParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Rpegs.NPCLogic;
using System.Windows;
using Rpegs.Entities;
using Rpegs.NPC;

namespace Rpegs.PlayerLogic
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

        public void Wear(Item item)
        {
            Equipment.Wear(item);
        }

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

    public class Inventory
    {
        public List<ItemChunk> chunks = new List<ItemChunk>();
        public void AddItem(Item item)
        {
            Type itemType = item.GetType();
            ItemChunk itemChunk = chunks.FirstOrDefault(
                x => x.ItemType == itemType);
            
            if(itemChunk == null)
            {
                ItemChunk newChunk = new ItemChunk(itemType);
                newChunk.InsertItem(item);
                chunks.Add(newChunk);
            }
            else
            {
                itemChunk.InsertItem(item);
            }
        }
    }

    public class ItemChunk
    {
        public Type ItemType { get; private set; }
        public List<Item> items { get; private set; }

        public bool IsEmpty => items.Count == 0;

        public int Count => items.Count;

        public ItemChunk(Type itemType)
        {
            ItemType = itemType;
            items = new List<Item>();
        }

        public void InsertItem(Item item)
        {
            items.Add(item);
        }

        public Item TakeItem()
        {
            var item = items[0];
            items.RemoveAt(0);
            return item;
        }
    }
}
