namespace BoardGameNight.Domain.Models
{
    internal class BoardgameNight
    {
        private readonly int id;
        private readonly User Organizer;
        private string address;
        private bool isAdult;
        private int maxParticipants;
        private DateTime dateTime;
        private string foodAndDrinks;

        private ICollection<User> participants;
        private ICollection<Boardgame> boardgames;
        private ICollection<GameNightReview> reviews;

        public BoardgameNight(int id, User organizer, string address, bool isAdult, int maxParticipants, DateTime dateTime, string foodAndDrinks, ICollection<User> participants, ICollection<Boardgame> boardgames, ICollection<GameNightReview> reviews)
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
