using BoardGameNight.Domain.Models;
using BoardGameNight.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Infrastructure.Repositories
{
    public class BoardgameRepository : IBoardgameRepository
    {

        private readonly BoardgameDbContext dbContext;

        public BoardgameRepository(BoardgameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Boardgame> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
