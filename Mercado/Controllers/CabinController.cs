using Mercado.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mercado.Controllers
{
    public class CabinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getCabin")]
        public CabinModel getCabin()
        {
            CabinModel cabin = new CabinModel("1187289172891", 1);
            Console.WriteLine(cabin);
            return cabin;
        }
    }
}
