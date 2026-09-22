using System.ComponentModel.DataAnnotations;

namespace FlashcardsAPI.Models
{
    public class Deck
    {
        [Key]
        public int DeckId { get; set; }
        public string DeckName { get; set; } = null!;
        public int OwnerId { get; set; }
    }
}
