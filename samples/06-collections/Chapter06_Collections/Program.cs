List<string> taskNames = new List<string>();
taskNames.Add("資料を作る");
taskNames.Add("メールを返す");

Console.WriteLine($"タスク数：{taskNames.Count}");
foreach (string taskName in taskNames)
{
    Console.WriteLine(taskName);
}
