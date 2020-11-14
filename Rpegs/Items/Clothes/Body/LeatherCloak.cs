namespace Rpegs.Items
{
    public class LeatherCloak : Clothes
    {
        public LeatherCloak()
        {
            //Item properties
            Name = "Leather Cloak";
            Description = "Like in old Vegas traditions, only what you need - cowboy hat and revolver";
            CanBeCrafted = true;
            Value = 75;
            Weight = 2;

            //Clothes properties
            Protection = 0.05;
            Durablity = 100;
            CarryExpansion = 2.25;            
        }
    }
}
