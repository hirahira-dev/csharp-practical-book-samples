SearchCondition original = new SearchCondition("資料", false);
SearchCondition updated = original with { IncludeCompleted = true };

Console.WriteLine($"元の条件：{original.Keyword} / {original.IncludeCompleted}");
Console.WriteLine($"新しい条件：{updated.Keyword} / {updated.IncludeCompleted}");

public record SearchCondition(string Keyword, bool IncludeCompleted);
