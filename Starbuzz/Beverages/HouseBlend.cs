namespace Starbuzz.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}