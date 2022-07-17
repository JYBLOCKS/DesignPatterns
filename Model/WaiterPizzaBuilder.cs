namespace DesignPatterns.Model
{
    public class WaiterPizzaBuilder {
    private PizzaBuilder? pizzaBuilder;

    public void SetPizzaBuilder(PizzaBuilder pb) {
        pizzaBuilder = pb;
    }

    public Pizza? GetPizza() {
        return pizzaBuilder?.GetPizza();
    }

    public void ConstructorPizza() {
        pizzaBuilder?.CreateNewPizzaProduct();
        pizzaBuilder?.BuildDough();
        pizzaBuilder?.BuildSauce();
        pizzaBuilder?.BuildTopping();
    }
}
}