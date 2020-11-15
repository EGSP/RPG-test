using Rpegs.Entities.Player;

namespace Rpegs.Entities
{
    public interface IHaveInventory
    {
        Inventory Inventory { get; }
    }
}