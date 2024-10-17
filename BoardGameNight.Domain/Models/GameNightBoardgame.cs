using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Domain.Models
{
    public class GameNightBoardgame
    {
        public int Id { get; init; }
        public int BoardgameNightId { get; init; }
        public int BoardgameId { get; init; }
        public BoardgameNight BoardgameNight { get; init; } = null!;
        public Boardgame Boardgame { get; init; } = null!;


    }
}
