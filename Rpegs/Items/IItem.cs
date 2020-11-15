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
}