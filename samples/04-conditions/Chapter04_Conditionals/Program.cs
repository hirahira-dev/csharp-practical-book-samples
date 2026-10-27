Console.WriteLine("数量を入力してください。");
string? quantityText = Console.ReadLine();
int quantity;

bool converted = int.TryParse(quantityText, out quantity);

if (converted)
{
    Console.WriteLine($"数量：{quantity}個");
}
else
{
    Console.WriteLine("整数として読み取れませんでした。");
}
