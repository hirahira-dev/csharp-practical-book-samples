List<string> taskNames = new List<string> { "資料を作る" };
taskNames.Add("メールを返す");
Console.WriteLine($"タスク数：{taskNames.Count}");
foreach (string taskName in taskNames)
{
    Console.WriteLine(taskName);
}

Dictionary<string, string> productNames = new Dictionary<string, string>();
productNames.Add("0012", "ノート");
string productCode = "0099";
string? productName;
if (productNames.TryGetValue(productCode, out productName))
{
    Console.WriteLine($"商品名：{productName}");
}
else
{
    Console.WriteLine("その商品コードは登録されていません。");
}
