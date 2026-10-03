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


        [HttpPost]
        public async Task<ActionResult<Card>> CreateCard(Card newCard)
        {
            
            if (newCard == null)
            {
                return BadRequest();
            }
            _context.Add(newCard);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Card>> UpdateCard(int id)
        {


            return Ok();
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
