// Constructor injection

using DIP;

UserService userService = new UserService();
userService.RegisterUser("user1", "password1");

var userCard = new Card
{
    CardNumber = "12345",
    CardHolderName = "Ion Creanga",
    ExpirationDate = DateTime.Now.AddYears(3)
};

userService.AddCard(userCard);
