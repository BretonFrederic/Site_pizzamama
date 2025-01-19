using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pizza_mama_v1.Data;
using pizza_mama_v1.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama_v1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        // DataContext(pour récupérer la liste de pizzas depuis la base de donnée)
        DataContext dataContext;
        public ApiController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            // var pizza = new Pizza() { nom = "pizza test", prix = 8, vegetarienne = false, ingredients = "tomate, oignons, oeuf" };
            var pizzas = dataContext.Pizzas.ToList();
            
            // Récupérer les pizzas -> Json
            return Json(pizzas);
        }
    }
}
