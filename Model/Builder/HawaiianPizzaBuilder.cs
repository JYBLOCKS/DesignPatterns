namespace DesignPatterns.Model
{
    public class HawaiianPizzaBuilder : PizzaBuilder {
    public override void BuildDough() {
        pizza.Dough = "cross";
    }

    public override void BuildSauce() {
        pizza.Sauce = "mild";
    }

    public override void BuildTopping() {
        pizza.Topping = "ham+pineapple";
    }
}
}