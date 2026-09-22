using FlashcardsAPI.Data;
using FlashcardsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardsAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CardController : Controller
    {
        private readonly FlashcardContext _context;

        public CardController(FlashcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Card>> GetCard(int id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return Ok(card);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
