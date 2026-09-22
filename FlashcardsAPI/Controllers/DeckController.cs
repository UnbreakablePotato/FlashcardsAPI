using Microsoft.AspNetCore.Mvc;

namespace FlashcardsAPI.Controllers
{
    public class DeckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
