while (true)
{
    Console.WriteLine("数量を入力してください。");
    string? quantityText = Console.ReadLine();
    int quantity;

    if (quantityText is null)
    {
        Console.WriteLine("入力が終了しました。");
        break;
    }

    if (!int.TryParse(quantityText, out quantity))
    {
        Console.WriteLine("整数を入力してください。");
        continue;
    }

    if (quantity < 1 || quantity > 10)
    {
        Console.WriteLine("数量は1以上10以下にしてください。");
        continue;
    }

    decimal unitPrice = 120m;
    decimal subtotal = unitPrice * quantity;
    Console.WriteLine($"{quantity}個の注文を受け付けました。");
    Console.WriteLine($"小計：{subtotal}円");
    break;
}
