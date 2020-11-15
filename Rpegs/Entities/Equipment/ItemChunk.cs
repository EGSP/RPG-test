using System;
using System.Collections.Generic;
using Rpegs.Items;

namespace Rpegs.Entities
{
    public class ItemChunk
    {
        public Type ItemType { get; private set; }

        public List<Item> Items { get; private set; }

        public bool IsEmpty => Items.Count == 0;

        public int Count => Items.Count;

        public ItemChunk(Type itemType)
        {
            ItemType = itemType;
            Items = new List<Item>();
        }

        public void InsertItem(Item wearable)
        {
            Items.Add(wearable);
        }

        public Item TakeItem()
        {
            var item = Items[0];
            Items.RemoveAt(0);
            return item;
        }
    }
}