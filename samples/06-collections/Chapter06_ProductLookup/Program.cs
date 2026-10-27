Dictionary<string, string> productNames = new Dictionary<string, string>();
productNames.Add("0012", "ノート");
productNames.Add("0013", "ボールペン");
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
