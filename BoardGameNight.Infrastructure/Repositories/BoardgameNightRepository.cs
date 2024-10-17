using BoardGameNight.Domain.Models;
using BoardGameNight.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Infrastructure.Repositories
{
    public class BoardgameNightRepository : IBoardgameNightRepository
    {

        private readonly BoardgameDbContext dbContext;

        public BoardgameNightRepository(BoardgameDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public BoardgameNight getById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BoardgameNight> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
