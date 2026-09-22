using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashcardsAPI.Models
{
    public class UserProgressCard
    {
        [Key]
        public int ProgressId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
        public int DeckId { get; set; }
        [ForeignKey("DeckId")]
        public Deck Deck { get; set; } = null!;
        public int CardId { get; set; }
        public DateTime NextReviewDate { get; set; }
        public Difficulty IntervalFactor { get; set; }

    }
}
