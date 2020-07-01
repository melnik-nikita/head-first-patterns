namespace Fabric.Models.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new MozzarellaCheese();

        public Clams CreateClam() => new FrozenClams();

        public Dough CreateDough() => new ThickCrustDough();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Sauce CreateSauce() => new PlumTomatoSauce();

        public Veggies[] CreateVeggies() => new Veggies[] { new Spinach(), new EggPlant(), new BlackOlives() };
    }
}
