using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Model;

namespace DesignPatters.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetCountriesFromSingleton()
        {
            return Ok(Country.GetCountries());
        }
    }

}