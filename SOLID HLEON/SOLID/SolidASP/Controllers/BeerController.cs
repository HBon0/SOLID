using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidASP.Models.ViewModels;
using SolidASP.Service;

namespace SolidASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly BeerService _beerService;

        public BeerController(BeerService beerService)
        {
            _beerService = beerService;
        }

        // GET: BeerController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add (BeerVModel beer)
        {
            if (!ModelState.IsValid)
            {
                return View(beer);
            }

            _beerService.Create(beer);

            return Ok();
        }
    }
}
