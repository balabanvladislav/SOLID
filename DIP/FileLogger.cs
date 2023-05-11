namespace DIP;

public class FileLogger : ILogger
{
    private string _logFilePath;
 
    public FileLogger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }
 
    public void Log(string message)
    {
        // Code to write message to file
    }
}