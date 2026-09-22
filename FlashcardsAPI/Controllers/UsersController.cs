using Microsoft.AspNetCore.Mvc;
using FlashcardsAPI.Models;
using FlashcardsAPI.Data;

namespace FlashcardsAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly FlashcardContext _context;

        public UsersController( FlashcardContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User newUser)
        {
            if (newUser == null)
            {
                return BadRequest();
            }

            _context.Users.Add(newUser);

            await _context.SaveChangesAsync();

            return Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
