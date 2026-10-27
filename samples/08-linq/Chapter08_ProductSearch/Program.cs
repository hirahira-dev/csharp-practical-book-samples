List<string> productNames = new List<string> { "ペン", "方眼ノート", "ノート" };

string? foundName = productNames.FirstOrDefault(name => name.Contains("ノート"));

if (foundName is null)
{
    Console.WriteLine("商品が見つかりませんでした。");
}
else
{
    Console.WriteLine($"見つかった商品：{foundName}");
}
