using BoardGameNight.Domain.Models;
using BoardGameNight.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Infrastructure.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly BoardgameDbContext dbContext;

        public ReviewRepository(BoardgameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public GameNightReview getById(int reviewId)
        {
            throw new NotImplementedException();
        }

        public GameNightReview getReviewsByUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
