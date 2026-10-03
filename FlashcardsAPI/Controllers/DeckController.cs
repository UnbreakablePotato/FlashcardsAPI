using FlashcardsAPI.Data;
using FlashcardsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlashcardsAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DeckController : Controller
    {
        private readonly FlashcardContext _context;

        public DeckController(FlashcardContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<Deck>> CreateDeck(Deck newDeck)
        {
            if (newDeck == null)
            {
                return BadRequest();
            }

            _context.Add(newDeck);

            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Deck>> GetDeck(int id)
        {
            var deck = await _context.Decks.FindAsync(id);

            if (deck == null)
            {
                return NotFound();
            }

            return deck;

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDeck(int id, Deck newDeck)
        {
            var deck = await _context.Decks.FindAsync(id);

            if (deck == null)
            {
                return NotFound();
            }

            //deck.DeckId = newDeck.DeckId;
            deck.DeckName = newDeck.DeckName;
            //deck.OwnerId = newDeck.OwnerId;

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeck(int id)
        {
            var deck = await _context.Decks.FindAsync(id);

            if (deck == null)
            {
                return NotFound();
            }

            _context.Decks.Remove(deck);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
