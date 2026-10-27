List<INotificationSender> senders = new List<INotificationSender>
{
    new ConsoleNotificationSender(),
    new FramedNotificationSender()
};

foreach (INotificationSender sender in senders)
{
    sender.Send("資料を作成しました。");
}


public interface INotificationSender
{
    void Send(string message);
}

public class ConsoleNotificationSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"通知：{message}");
    }
}


public class FramedNotificationSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"--- {message} ---");
    }
}
