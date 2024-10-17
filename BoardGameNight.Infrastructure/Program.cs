// See https://aka.ms/new-console-template for more information

using BoardGameNight.Domain.Enumerations;
using BoardGameNight.Domain.Models;
using BoardGameNight.Infrastructure;
using BoardGameNight.Infrastructure.Repositories;

using BoardgameDbContext dbContext = new();

UserRepository userRepository = new(dbContext);
BoardgameRepository boardgameRepository = new(dbContext);
BoardgameNightRepository boardgameNightRepository = new(dbContext);

//create
User user = new()
{
    Name = "user1",
    Email = "test@test.nl",
    Street = "straat",
    City = "city",
    HouseNumber = 1,
    Gender = Gender.M

};

Boardgame boardgame = new()
{
    Name = "boardgame1",
    Description = "description",
    IsAdult = true,
    PhotoURL = "foto",
    GameType = BoardGameType.BoardGame,
    Genre = BoardGameGenre.War

};

//BoardgameNight boardgameNight = new()
//{
//    Name = "user1",
//    Email = "test@test.nl",
//    Street = "straat",
//    City = "city",
//    HouseNumber = 1,
//    Gender = Gender.M

//};

userRepository.add(user);



//get
//var users = userRepository.getAll();

//foreach (var user in users)
//{
//    Console.WriteLine(user.Id);
//    Console.WriteLine(user.Name);
//    Console.WriteLine(user.Email);
//    Console.WriteLine(user.getAddress());
//    Console.WriteLine(user.Gender);
//}


//update
//var user = dbContext.Users.Where(u => u.Name == "user1").FirstOrDefault();

//if (user is User)
//{
//    user.Street = "straat";
//}

//dbContext.SaveChanges();


//delete
//var user = dbContext.Users.Where(u => u.Name == "user1").FirstOrDefault();

//if (user is User)
//{
//    dbContext.Remove(user);
//}

//dbContext.SaveChanges();
