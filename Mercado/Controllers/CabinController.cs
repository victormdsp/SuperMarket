namespace Mercado.Controllers
{
    using Mercado.Interfaces;
    using Mercado.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller of the Cabins.
    /// </summary>
    /// <param name="cabinRep">Cabin Repository to connect to database.</param>
    public class CabinController(ICabinRepository cabinRep) : Controller
    {
        private ICabinRepository cabinRepository = cabinRep;

        /// <summary>
        /// Default function.
        /// </summary>
        /// <returns>View for the main page.</returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Route GetAllCabins.
        /// </summary>
        /// <returns>View with all the cabins listed.</returns>
        [HttpGet("getAllCabins")]
        public ActionResult<string> GetAllCabins()
        {
            try
            {
                List<ICabin> cabinList = this.cabinRepository.GetAllCabins();
                return this.View(cabinList);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Route GetCabinById.
        /// </summary>
        /// <param name="id">Id of one Cabin.</param>
        /// <returns>One Cabin.</returns>
        [HttpGet("getCabin/{id}")]
        public ActionResult<string> GetCabinById(string id)
        {
            try
            {
                ICabin cabin = this.cabinRepository.GetCabinById(id);
                this.ViewBag.Cabin = cabin;
                return this.View();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Route CreateNewCabin.
        /// </summary>
        /// <param name="cabinRequest">Infos of the new Cabin.</param>
        /// <returns>Message telling if the cabin was created.</returns>
        [HttpPost("createCabin")]
        public ActionResult<CabinModel> CreateCabin(CabinModel cabinRequest)
        {
            Console.WriteLine(cabinRequest);
            return cabinRequest;
        }
    }
}
