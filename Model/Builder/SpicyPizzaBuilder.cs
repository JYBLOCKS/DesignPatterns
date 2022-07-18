namespace DesignPatterns.Model
{
    public class SpicyPizzaBuilder : PizzaBuilder {
    public override void BuildDough() {
        pizza.Dough = "pan baked";
    }

    public override void BuildSauce() {
        pizza.Sauce = "hot";
    }

    public override void BuildTopping() {
        pizza.Topping = "pepperoni+salami";
    }
}
}