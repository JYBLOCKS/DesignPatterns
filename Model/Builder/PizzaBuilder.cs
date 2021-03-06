namespace DesignPatterns.Model
{
    public abstract class PizzaBuilder
    {
        public Pizza pizza = new Pizza();

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreateNewPizzaProduct()
        {
            pizza = new Pizza();
        }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
}