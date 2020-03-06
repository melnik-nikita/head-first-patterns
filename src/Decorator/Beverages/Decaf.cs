namespace Decorator.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
