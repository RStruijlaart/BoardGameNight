using BoardGameNight.Domain.Enumerations;

namespace BoardGameNight.Domain.Models

{
    public class User
    {
        private readonly int id;
        private string name;
        private string email;
        private string address;
        private readonly Gender gender;

        public User(int id, string name, string email, string address, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.address = address;
            this.gender = gender;
        }
    }
}
