namespace Rpegs.Entities
{
    public interface IDamagable
    { 
        int Health { get; } 
        bool Dead { get; }
        double Protection { get; }
        void ReceiveDamage(int damage);
    }
}