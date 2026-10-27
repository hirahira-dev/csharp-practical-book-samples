namespace Chapter16_TodoApp;

public class TodoItem
{
    public int Id { get; }
    public string Title { get; }
    public TodoStatus Status { get; private set; }
    public TodoPriority Priority { get; }
    public DateTime? DueDate { get; }

    public TodoItem(
        int id,
        string title,
        TodoStatus status,
        TodoPriority priority,
        DateTime? dueDate)
    {
        if (id < 1)
        {
            throw new ArgumentOutOfRangeException("id");
        }

        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(
                "タイトルを指定してください。",
                "title");
        }

        if (!Enum.IsDefined(status))
        {
            throw new ArgumentOutOfRangeException("status");
        }

        if (!Enum.IsDefined(priority))
        {
            throw new ArgumentOutOfRangeException("priority");
        }

        Id = id;
        Title = title;
        Status = status;
        Priority = priority;
        DueDate = dueDate;
    }

    public void Complete()
    {
        Status = TodoStatus.Completed;
    }
}
