using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Model;

namespace DesignPatters.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetHi()
        {
            WaiterPizzaBuilder waiter = new WaiterPizzaBuilder();
            PizzaBuilder hawaiianPizzabuilder = new HawaiianPizzaBuilder();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();

            waiter.SetPizzaBuilder(hawaiianPizzabuilder);
            waiter.ConstructorPizza();

            Pizza? pizza = waiter.GetPizza();
            return Ok(pizza);
        }
    }

}