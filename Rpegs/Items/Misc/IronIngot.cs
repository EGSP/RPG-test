namespace Rpegs.Items
{
    public class IronIngot : Item
    {
        public IronIngot()
        {
            Name = "Iron Ingot";
            Description = "An iron ingot.";
            CanBeCrafted = true;    
            Value = 50;
            Weight = 0.5;
        }
    }
}
