// Get the Logger object instance in two different variables.
Logger logger1 = Logger.getInstance();
Logger logger2 = Logger.getInstance();

// Test if the message count is shared between logger1 and logger2
// If so, then the singleton design pattern was implemented correctly.
logger1.log("This is the first message from logger1.");
logger2.log("This is the first message from logger2.");
logger1.log("This is the second message from logger1.");
logger2.log("This is the second message from logger2.");

public class Logger
{
    // The logger instance.
    private static Logger? _instance;

    // The constructor for the logger object is private so that it cannot be accessed from the outside.
    private Logger() { messageCount = 0; }

    // Returns the instance of Logger.
    // If an instance does not already exist, calls the private constructor and saves the object in the instance.
    // If an instance exists, returns the instance.
    public static Logger getInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    private int messageCount;

    // Public method that takes a string as an argument and prints it.
    // We print the total message count next to each message to see if the value is actually shared.
    public void log(string message)
    {
        messageCount++;
        Console.WriteLine(String.Format("[{0}] {1}", messageCount, message));
    }
}