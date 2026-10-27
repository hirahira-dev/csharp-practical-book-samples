using Chapter10_Enums;

Console.WriteLine("状態を入力してください（Pending / InProgress / Completed または 0 / 1 / 2）。");
string? input = Console.ReadLine();

if (Enum.TryParse<TodoStatus>(input, out TodoStatus status)
    && Enum.IsDefined<TodoStatus>(status))
{
    string displayName = status switch
    {
        TodoStatus.Pending => "未着手",
        TodoStatus.InProgress => "進行中",
        TodoStatus.Completed => "完了",
        _ => "不明な状態"
    };

    Console.WriteLine($"状態：{displayName}");
}
else
{
    Console.WriteLine("定義済みの状態を入力してください。");
}
