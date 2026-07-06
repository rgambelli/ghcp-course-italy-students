namespace Cegeka.Inbox;

public class Inbox
{
    public void ReceiveMessage(string from, string message)
    {
        MessageSender.SendMessage(string.Empty, string.Empty);
    }
}