using Microsoft.AspNetCore.Mvc;
using FlashcardsAPI.Models;

namespace FlashcardsAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UserProgressCardController : Controller
    {
        [HttpPost]
        public async Task<ActionResult<UserProgressCard>> NewUserProgressCard(UserProgressCard newProgress)
        {
            if (newProgress == null)
            {
                return BadRequest();
            }

            return Ok();

        }

        [HttpPut]
        public async Task<ActionResult<UserProgressCard>> UpdateUserProgressCard(UserProgressCard updatedProgress)
        {
            if (updatedProgress == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<UserProgressCard>> GetUserProgressCard(int id)
        {
            //Should ofcourse return bad request if not found in the DB, but I haven't gotten there yet
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
