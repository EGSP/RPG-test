namespace Rpegs.Items
{
    public class CowboyHat : Clothes
    {
        public CowboyHat()
        {
            //Item properties
            Name = "Cowboy hat";
            Description = "Yeehaw partner...";
            CanBeCrafted = false;
            Value = 25;
            Weight = 0.3;

            //Clothes properties
            Protection = 0;
            Durablity = 100;
            CarryExpansion = 0;            
        }
    }
}
