using System.ComponentModel.DataAnnotations;

namespace FlashcardsAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;
        
    }
}
