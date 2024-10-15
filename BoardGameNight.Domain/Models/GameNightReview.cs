namespace BoardGameNight.Domain.Models
{
    internal class GameNightReview
    {
        private readonly int id;
        private int score;
        private string reviewDescription;

        public GameNightReview(int id, int score, string reviewDescription)
        {
            this.id = id;
            this.score = score;
            this.reviewDescription = reviewDescription;
        }
    }
}
