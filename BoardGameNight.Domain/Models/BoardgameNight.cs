using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Domain.Models
{
    public class BoardgameNight
    {
        public int Id { get; init; }

        public User Organizer { get; set; } = null!;
        public int HouseNumber { get; set; }
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public bool IsAdult { get; set; }
        public int MaxParticipants { get; set; }
        public DateTime DateTime { get; set; }
        public string FoodAndDrinks { get; set; } = null!;
        public IEnumerable<User> Participants { get; set; } = null!;
        public IEnumerable<GameNightBoardgame> GameNightBoardgames { get; set; } = null!;
        public IEnumerable<GameNightReview> Reviews { get; set; } = null!;

        public string getAddress()
        {
            return $"{City}, {Street} {HouseNumber}";
        }
    }
}
