using BoardGameNight.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.DomainServices
{
    public interface IReviewRepository
    {
        public GameNightReview getById(int reviewId);

        public GameNightReview getReviewsByUser(int userId);
    }
}
