namespace Cegeka.Inbox;

public class MessageSender
{
    private static MessageSender instance = new();

    public static void SetInstance(MessageSender newInstance)
    {
        instance = newInstance;
    }

    public static void SendMessage(string to, string message)
    {
        instance.AcceptMessage(to, message);
    }

    protected virtual void AcceptMessage(string to, string message)
    {
    }
}