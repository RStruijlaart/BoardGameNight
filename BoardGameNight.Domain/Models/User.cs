using BoardGameNight.Domain.Enumerations;

namespace BoardGameNight.Domain.Models

{
    public class User
    {

        public int Id { get => id; init => id = value; }
        public string Name { get => name; init => name = value; }
        public string Email { get => email; init => email = value; }
        public string Street { get => street; init => street = value; }
        public string City { get => city; init => city = value; }
        public int HouseNumber { get => houseNumber; init => houseNumber = value; }
        public Gender Gender { get => gender; init => gender = value; }

        private readonly int id;
        private string name;
        private string email;
        private string street;
        private string city;
        private int houseNumber;
        private readonly Gender gender;

        public User(int id, string name, string email, string street, string city, int houseNumber, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.street = street;
            this.city = city;
            this.houseNumber = houseNumber;
            this.gender = gender;
        }

        public string getAddress()
        {
            return $"{city}, {street} {houseNumber}";
        }
    }
}
