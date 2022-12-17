using Microsoft.EntityFrameworkCore;

namespace Lab5Sub.Models
{
    public class CardContext : DbContext
    {
        //Constructor

        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
