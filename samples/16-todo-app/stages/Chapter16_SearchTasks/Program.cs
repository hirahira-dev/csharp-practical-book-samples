using Chapter16_TodoApp;

List<TodoItem> items = new List<TodoItem>();
int nextId = 1;

RunMenu(items, nextId);

static void RunMenu(List<TodoItem> items, int nextId)
{
    while (true)
    {
        Console.WriteLine("1:追加  2:一覧  3:完了  4:検索  0:終了");
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
            case "3":
                TodoItem? target = ReadTaskToComplete(items);

                if (target is null)
                {
                    return;
                }

                if (target.Status == TodoStatus.Completed)
                {
                    Console.WriteLine("すでに完了しています。");
                    break;
                }

                target.Complete();
                Console.WriteLine($"ID {target.Id}を完了にしました。");
                break;
            case "4":
                Console.Write("タイトルの検索語（空欄はすべて）：");
                string? keyword = Console.ReadLine();

                if (keyword is null)
                {
                    return;
                }

                List<TodoItem> results = SearchTasks(items, keyword);
                PrintTasks(results);
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

static TodoItem? ReadTaskToComplete(List<TodoItem> items)
{
    while (true)
    {
        Console.Write("完了にするID：");
        string? input = Console.ReadLine();

        if (input is null)
        {
            return null;
        }

        if (!int.TryParse(input, out int id) || id < 1)
        {
            Console.WriteLine("正の整数を入力してください。");
            continue;
        }

        TodoItem? item = FindTask(items, id);

        if (item is null)
        {
            Console.WriteLine("指定したIDはありません。");
            continue;
        }

        return item;
    }
}

static TodoItem? FindTask(List<TodoItem> items, int id)
{
    return items.FirstOrDefault(item => item.Id == id);
}

static List<TodoItem> SearchTasks(
    List<TodoItem> items,
    string keyword)
{
    return items
        .Where(item => item.Title.Contains(keyword))
        .OrderBy(item => item.Title)
        .ToList();
}
