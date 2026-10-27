using Chapter10_Enums;

TodoItem item = new TodoItem(1, "資料を作る");

Console.WriteLine($"作成時：{item.Status}");

item.Complete();

Console.WriteLine($"完了後：{item.Status}");
Console.WriteLine($"完了したか：{item.Status == TodoStatus.Completed}");
