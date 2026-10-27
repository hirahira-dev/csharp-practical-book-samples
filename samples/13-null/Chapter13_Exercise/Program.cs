List<TodoItem> items = new List<TodoItem>
{
    new TodoItem(1, "資料を作る")
    {
        DueDate = new DateTime(2026, 10, 1)
    },
    new TodoItem(2, "机を片付ける")
};

int targetId = 1;
TodoItem? item = FindTask(items, targetId);
Console.WriteLine(item!.Title);
string dueDateText = item.DueDate?.ToString("yyyy-MM-dd") ?? "期限なし";
Console.WriteLine($"期限：{dueDateText}");

static TodoItem? FindTask(List<TodoItem> items, int id)
{
    return items.FirstOrDefault(item => item.Id == id);
}

public class TodoItem
{
    public int Id { get; }
    public string Title { get; set; }
    public DateTime? DueDate { get; set; }

    public TodoItem(int id, string title)
    {
        Id = id;
        Title = title;
    }
}
