using Chapter16_TodoApp;

List<TodoItem> items = new List<TodoItem>();
int nextId = 1;

RunMenu(items, nextId);

static void RunMenu(List<TodoItem> items, int nextId)
{
    while (true)
    {
        Console.WriteLine("1:追加  2:一覧  0:終了");
        string? choice = Console.ReadLine();

        if (choice is null || choice == "0")
        {
            return;
        }

        switch (choice)
        {
            case "1":
                TodoItem? item = ReadNewTask(nextId);

                if (item is null)
                {
                    return;
                }

                items.Add(item);
                nextId++;

                Console.WriteLine($"ID {item.Id}を追加しました。");
                break;

            case "2":
                PrintTasks(items);
                break;
            default:
                Console.WriteLine("メニューの番号を選んでください。");
                break;
        }
    }
}

static TodoItem? ReadNewTask(int id)
{
    string title;

    while (true)
    {
        Console.Write("タイトル：");
        string? input = Console.ReadLine();

        if (input is null)
        {
            return null;
        }

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("タイトルを入力してください。");
            continue;
        }

        title = input;
        break;
    }

    TodoPriority priority;

    while (true)
    {
        Console.Write("優先度（0:通常 1:低 2:高）：");
        string? input = Console.ReadLine();

        if (input is null)
        {
            return null;
        }

        if (!int.TryParse(input, out int priorityValue)
            || priorityValue < 0
            || priorityValue > 2)
        {
            Console.WriteLine("0、1、2のいずれかを入力してください。");
            continue;
        }

        priority = (TodoPriority)priorityValue;
        break;
    }

    DateTime? dueDate = null;

    while (true)
    {
        Console.Write("期限（例 2026-10-01、なしならEnter）：");
        string? input = Console.ReadLine();

        if (input is null)
        {
            return null;
        }

        if (input == "")
        {
            break;
        }

        if (!DateTime.TryParse(input, out DateTime date))
        {
            Console.WriteLine(
                "日付を入力するか、Enterで期限なしにしてください。");
            continue;
        }

        dueDate = date;
        break;
    }

    return new TodoItem(
        id,
        title,
        TodoStatus.Pending,
        priority,
        dueDate);
}

static void PrintTasks(List<TodoItem> items)
{
    if (items.Count == 0)
    {
        Console.WriteLine("該当するタスクはありません。");
        return;
    }

    foreach (TodoItem item in items)
    {
        string statusText = item.Status switch
        {
            TodoStatus.Pending => "未着手",
            TodoStatus.InProgress => "進行中",
            TodoStatus.Completed => "完了",
            _ => "不明"
        };

        string priorityText = item.Priority switch
        {
            TodoPriority.Normal => "通常",
            TodoPriority.Low => "低",
            TodoPriority.High => "高",
            _ => "不明"
        };

        string dueDateText =
            item.DueDate?.ToString("yyyy-MM-dd") ?? "期限なし";

        Console.WriteLine(
            $"{item.Id}: {item.Title} / {statusText} / {priorityText} / {dueDateText}");
    }
}
