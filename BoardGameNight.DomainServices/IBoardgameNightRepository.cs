using BoardGameNight.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.DomainServices
{
    public interface IBoardgameNightRepository
    {
        public BoardgameNight getById();

        public IEnumerable<BoardgameNight> getAll();
    }
}
