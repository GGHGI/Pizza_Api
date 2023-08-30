using Microsoft.AspNetCore.Mvc;
using pizza_mama1.Data;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.NewFolder
{
    [Route("[controller]")]
    [ApiController]


    public class ApiController : Controller
    {

        DataContext dataContext;


        public ApiController(DataContext dataContext)
        {

            this.dataContext = dataContext;

        }



        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {

            //var pizza = new Pizza() { nom = "pizza test", prix = 8, vegetarienne = false, ingredients = "tomate, sauce tomate" };

            var pizzas = dataContext.Pizzas.ToList();
            return Json(pizzas);


        }
    }
}
