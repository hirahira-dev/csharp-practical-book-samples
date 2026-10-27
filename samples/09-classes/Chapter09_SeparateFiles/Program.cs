using Chapter09_Classes;

TodoItem item = new TodoItem(1, "資料を作る")
{
    DueDate = new DateTime(2026, 10, 1)
};

item.Complete();

Console.WriteLine($"ID：{item.Id}");
Console.WriteLine($"タイトル：{item.Title}");
Console.WriteLine($"完了：{item.IsCompleted}");
Console.WriteLine($"期限：{item.DueDate}");
