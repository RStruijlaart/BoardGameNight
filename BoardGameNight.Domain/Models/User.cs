using BoardGameNight.Domain.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardGameNight.Domain.Models

{
    public class User
    {

        public int Id { get; init; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public int HouseNumber { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public Gender Gender { get; set; }

        public string getAddress()
        {
            return $"{City}, {Street} {HouseNumber}";
        }
    }
}
