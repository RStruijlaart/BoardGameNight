using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameNight.Domain.Models
{
    public class BoardgameNight
    {
        private readonly int id;
        private readonly User Organizer;
        private string address;
        private bool isAdult;
        private int maxParticipants;
        private DateTime dateTime;
        private string foodAndDrinks;

        private IEnumerable<User> participants;
        private IEnumerable<Boardgame> boardgames;
        private IEnumerable<GameNightReview> reviews;

        public BoardgameNight(int id, User organizer, string address, bool isAdult, int maxParticipants, DateTime dateTime, string foodAndDrinks, IEnumerable<User> participants, IEnumerable<Boardgame> boardgames, IEnumerable<GameNightReview> reviews)
        {
            this.id = id;
            Organizer = organizer;
            this.address = address;
            this.isAdult = isAdult;
            this.maxParticipants = maxParticipants;
            this.dateTime = dateTime;
            this.foodAndDrinks = foodAndDrinks;
            this.participants = participants;
            this.boardgames = boardgames;
            this.reviews = reviews;
        }
    }
}
