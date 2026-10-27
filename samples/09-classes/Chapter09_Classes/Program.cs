TodoItem item = new TodoItem(1, "資料を作る");

Console.WriteLine($"完了：{item.IsCompleted}");
item.Complete();
Console.WriteLine($"完了：{item.IsCompleted}");

public class TodoItem
{
    public int Id { get; }
    public string Title { get; set; }
    public bool IsCompleted { get; private set; }

    public TodoItem(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public void Complete()
    {
        IsCompleted = true;
    }
}
