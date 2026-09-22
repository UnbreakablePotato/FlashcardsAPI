using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashcardsAPI.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public int DeckId { get; set; }
        [ForeignKey("DeckId")]
        public Deck Deck { get; set; } = null!;
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

    }
}
