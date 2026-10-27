namespace Chapter10_Enums;

public class TodoItem
{
    public int Id { get; }
    public string Title { get; set; }
    public TodoStatus Status { get; private set; } = TodoStatus.Pending;
    public DateTime DueDate { get; set; } = DateTime.Today;

    public TodoItem(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public void Complete()
    {
        Status = TodoStatus.Completed;
    }
}
