namespace DIP;

public class UserService
{
    private readonly ConsoleLogger _consoleLogger;

    public UserService()
    {
        _consoleLogger = new ConsoleLogger();
    }
 
    public void RegisterUser(string username, string password)
    {
        // Code to register user
        _consoleLogger.Log($"User {username} registered.");
    }

    public void AddCard(Card card)
    {
        var encryptionService = new AESEncryptionService();
        var tokenizedCardNumber = encryptionService.Encrypt(card.CardNumber);
        // Code to add user card
    }
}