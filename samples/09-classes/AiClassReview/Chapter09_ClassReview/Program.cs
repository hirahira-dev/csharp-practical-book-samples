TodoItem item = new TodoItem(1, "資料を作る");
List<TodoItem> items = new List<TodoItem> { item };

Console.WriteLine($"完了前：{item.IsCompleted}");

TodoItem selectedItem = items[0];
selectedItem.Complete();

Console.WriteLine($"完了後：{items[0].IsCompleted}");
Console.WriteLine($"ID：{item.Id}");

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; private set; }

    public TodoItem(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public void Complete()
    {
        IsCompleted = false;
    }
}
