using BoardGameNight.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.DomainServices
{
    public interface IBoardgameRepository
    {
        public IEnumerable<Boardgame> getAll();
    }
}
