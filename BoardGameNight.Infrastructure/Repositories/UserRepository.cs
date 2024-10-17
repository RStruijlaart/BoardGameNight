using BoardGameNight.Domain.Models;
using BoardGameNight.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BoardgameDbContext dbContext;

        public UserRepository(BoardgameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User getById(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
