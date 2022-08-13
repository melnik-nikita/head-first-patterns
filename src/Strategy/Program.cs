using Strategy.Models;
using Strategy.Models.FlyBehavior;

namespace Strategy
{
    public class BaseClass
    {
        public string GetMethodOwnerName()
        {
            return "Base Class";
        }
    }
    public class ChildClass : BaseClass
    {
        public new string GetMethodOwnerName()
        {
            return "ChildClass";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
