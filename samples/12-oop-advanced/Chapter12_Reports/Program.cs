Report report = new DailyReport
{
    Title = "今日の作業",
    CompletedCount = 3
};

report.Print();

public class Report
{
    public string Title { get; set; } = "";

    public virtual void Print()
    {
        Console.WriteLine(Title);
    }
}

public class DailyReport : Report
{
    public int CompletedCount { get; set; }

    public override void Print()
    {
        Console.WriteLine($"{Title}：{CompletedCount}件完了");
    }
}
