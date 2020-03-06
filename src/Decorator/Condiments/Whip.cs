namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }
    }
}
