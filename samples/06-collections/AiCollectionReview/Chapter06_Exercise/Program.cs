string[] taskNames = { "資料を作る" };
taskNames[0] = "メールを返す";
Console.WriteLine($"タスク数：{taskNames.Length}");
foreach (string taskName in taskNames)
{
    Console.WriteLine(taskName);
}

Dictionary<string, string> productNames = new Dictionary<string, string>();
productNames.Add("0012", "ノート");
string productCode = "0099";
Console.WriteLine($"商品名：{productNames[productCode]}");
