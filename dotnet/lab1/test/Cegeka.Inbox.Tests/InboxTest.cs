using System.Collections.Generic;

namespace Cegeka.Inbox.Tests;

public class InboxTest
{
    private readonly MessageSenderForTest messageSender = new();

    public InboxTest()
    {
        MessageSender.SetInstance(messageSender);
    }

    [Fact]
    public void WhenMessageArrivesThenSendMessageToReception()
    {
        var inbox = new Inbox();

        inbox.ReceiveMessage("Ser Pounce", "Hello Cegeka!");

        Assert.Equal(new Dictionary<string, string>
        {
            ["reception"] = "Hello Cegeka!"
        }, messageSender.Messages);
    }

    private sealed class MessageSenderForTest : MessageSender
    {
        public Dictionary<string, string> Messages { get; } = new();

        protected override void AcceptMessage(string to, string message)
        {
            Messages[to] = message;
        }
    }
}