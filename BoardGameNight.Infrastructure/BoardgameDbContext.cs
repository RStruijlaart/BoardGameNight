using BoardGameNight.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Infrastructure
{
    public class BoardgameDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Boardgame> Boardgames { get; set; } = null!;
        public DbSet<BoardgameNight> BoardgameNights { get; set; } = null!;
        public DbSet<GameNightBoardgame> GameNightBoardgames { get; set; } = null!;
        public DbSet<GameNightReview> GameNightReviews { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=RUBENBIRD;Initial Catalog=BoardgameDb;Integrated Security=True;Trust Server Certificate=True");

        }
    }
}
