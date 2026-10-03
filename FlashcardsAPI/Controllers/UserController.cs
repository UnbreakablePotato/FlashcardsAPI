using Microsoft.AspNetCore.Mvc;
using FlashcardsAPI.Models;
using FlashcardsAPI.Data;

namespace FlashcardsAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly FlashcardContext _context;

        public UserController( FlashcardContext context)
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

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUser(int userId, User updatedUser)
        {
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            //user.UserId = updatedUser.UserId;
            user.UserName = updatedUser.UserName;
            user.Password = updatedUser.Password;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<User>> GetUser(int userId)
        {
            var user = await _context.Users.FindAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);

            await _context.SaveChangesAsync();

            return Ok();

        }
    }
}
