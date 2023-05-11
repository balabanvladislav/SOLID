namespace DIP;

public class AESEncryptionService
{
    public string Encrypt(string cardNumber)
    {
        var consoleLogger = new ConsoleLogger();
        consoleLogger.Log("CardNumber WasTokenized");
        // tokenization code...
        return cardNumber;
    }
}