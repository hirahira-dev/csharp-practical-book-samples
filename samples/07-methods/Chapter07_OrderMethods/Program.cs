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

    if (!IsValidQuantity(quantity))
    {
        Console.WriteLine("数量は1以上10以下にしてください。");
        continue;
    }

    decimal subtotal = CalculateSubtotal(120m, quantity);
    PrintOrder(quantity, subtotal);
    break;
}

static bool IsValidQuantity(int quantity)
{
    return quantity >= 1 && quantity <= 10;
}

static decimal CalculateSubtotal(decimal unitPrice, int quantity)
{
    decimal subtotal = unitPrice * quantity;
    return subtotal;
}

static void PrintOrder(int quantity, decimal subtotal)
{
    Console.WriteLine($"{quantity}個の注文を受け付けました。");
    Console.WriteLine($"小計：{subtotal}円");
}
