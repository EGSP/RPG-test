using Rpegs.Items;
using System;

namespace Rpegs.Entities
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public virtual int Damage { get; }
        public int Level { get; set; }
        public double Experience { get; set; }
    }

    public interface IHaveInventory
    {
        Inventory Inventory { get; }
    }

    public interface IDamagable
    { 
        int Health { get; } 
        bool Dead { get; }
        double Protection { get; }
        void ReceiveDamage(int damage);
    }
}
