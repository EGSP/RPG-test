using System;

namespace Rpegs.Items
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
        bool CanBeCrafted { get; set; }
        double Value { get; set; }
        double Weight { get; set; }
    }

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

    public interface IWearable : IItem
    {

    }
    public interface IHeadWearable : IWearable
    {

    }
    public interface IBodyWearable : IWearable
    {

    }
    public interface ILegsWearable : IWearable
    {

    }
    public interface IFootsWearable : IWearable
    {

    }
    public interface IHandsWearable : IWearable
    {

    }
    public interface IMindWearable : IWearable
    {

    }
    public interface IHandEquipable : IItem
    {

    }
}
