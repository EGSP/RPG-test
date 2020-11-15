using System;
using System.Collections.Generic;
using System.Linq;
using Rpegs.Items;

namespace Rpegs.Entities
{
    public class Inventory
    {
        public List<ItemChunk> Chunks = new List<ItemChunk>();

        public void AddItem(Item wearable)
        {
            Type itemType = wearable.GetType();
            ItemChunk itemChunk = Chunks.FirstOrDefault(
                x => x.ItemType == itemType);
            
            if(itemChunk == null)
            {
                ItemChunk newChunk = new ItemChunk(itemType);
                newChunk.InsertItem(wearable);
                Chunks.Add(newChunk);
            }
            else
            {
                itemChunk.InsertItem(wearable);
            }
        }
    }
}