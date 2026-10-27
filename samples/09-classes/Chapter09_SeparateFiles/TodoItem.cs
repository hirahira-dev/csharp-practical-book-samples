namespace Chapter09_Classes;

public class TodoItem
{
    public int Id { get; }
    public string Title { get; set; }
    public bool IsCompleted { get; private set; }
    public DateTime DueDate { get; set; } = DateTime.Today;

    public TodoItem(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public void Complete()
    {
        IsCompleted = true;
    }
}
