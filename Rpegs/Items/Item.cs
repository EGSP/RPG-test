using System;

namespace Rpegs.Items
{
    public abstract class Item : IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool CanBeCrafted { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public override string ToString()
        {
            if (Name.Length > 0)
            {
                return Name;
            }

            return GetType().Name;
        }
    }
}
