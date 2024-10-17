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

        public BoardgameNight? getById(int id)
        {
            return dbContext.BoardgameNights.Find(id);
        }

        public IEnumerable<BoardgameNight> getAll()
        {
            throw new NotImplementedException();
        }

        public void add(BoardgameNight boardgameNight)
        {
            dbContext.Add(boardgameNight);
            dbContext.SaveChanges();
        }

        public void update(BoardgameNight boardgameNight)
        {
            dbContext.Update(boardgameNight);
            dbContext.SaveChanges();
        }

        public void delete(int id)
        {
            var boardgameNightToRemove = dbContext.BoardgameNights.Find(id);
            if (boardgameNightToRemove != null)
            {
                dbContext.BoardgameNights.Remove(boardgameNightToRemove);
                dbContext.SaveChanges();
            }
        }
    }
}
