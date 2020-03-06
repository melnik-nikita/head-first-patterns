namespace Decorator.Condiments
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            Size size = _beverage.GetSize();
            double cost;
            switch(size)
            {
                case Size.TALL:
                cost = 0.10;
                break;
                case Size.GRANDE:
                cost = 0.15;
                break;
                case Size.VENTI:
                cost = 0.20;
                break;
                default:
                cost = 0;
                break;
            }

            return cost + _beverage.Cost();
        }
    }
}
