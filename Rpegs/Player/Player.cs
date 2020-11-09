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

namespace Rpegs.PlayerLogic
{
    public class Player : NPCBehaviour
    {
        public Inventory inventory { get; private set; }
        public Equipment equipment { get; private set; }
        public double CarriedWeight { get; set; }
        public double ExpThresold { get; set; }
        public void ReceiveExperience(NPC npc, Player player)
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
        public void Equip(Item item, bool left)
        {
            equipment.Equip(item, left);
        }

        public void Wear(Item item)
        {
            equipment.Wear(item);
        }
        public Player()
        {
            inventory = new Inventory();
            equipment = new Equipment(this);
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
