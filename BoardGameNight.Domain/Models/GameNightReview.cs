namespace BoardGameNight.Domain.Models
{
    public class GameNightReview
    {
        public int Id { get; init; }
        public int Score { get; init; }
        public string ReviewDescription { get; init; } = null!;

    }
}
