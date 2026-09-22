using FlashcardsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FlashcardsAPI.Data
{
    public class FlashcardContext : DbContext
    {
        public FlashcardContext(DbContextOptions<FlashcardContext> options):base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Deck> Decks { get; set; }

        public DbSet<UserProgressCard> UserProgressCards { get; set; }
    }
}
