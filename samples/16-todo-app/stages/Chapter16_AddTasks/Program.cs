using Chapter16_TodoApp;

List<TodoItem> items = new List<TodoItem>();
int nextId = 1;

RunMenu(items, nextId);

static void RunMenu(List<TodoItem> items, int nextId)
{
    while (true)
    {
        Console.WriteLine("1:追加  0:終了");
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
