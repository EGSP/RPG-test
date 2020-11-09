using Rpegs.Items;
using Rpegs.PlayerLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Rpegs.NPCLogic
{
    public class NPCBehaviour : NPC
    {
        public bool ReceiveDamage(int damage)
        {
            Health -= damage;

            if (Health > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Item> Drop()
        {
            List<Item> DroppedItems = new List<Item>();
            Random rnd = new Random();

            int ItemQuantity = rnd.Next(0, 10);

            for(int i = 0; i < ItemQuantity; i++)
            {
                
            }

            return DroppedItems;
        }
    }
}
