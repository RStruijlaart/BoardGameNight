namespace BoardGameNight.Domain.Models
{
    public class Boardgame
    {
        private readonly int id;
        private string name;
        private string description;
        private bool isAdult;
        private string photoURL;

        public Boardgame(int id, string name, string description, bool isAdult, string photoURL)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.isAdult = isAdult;
            this.photoURL = photoURL;
        }
    }
}
