PrintQuantity(0);
PrintQuantity(3);
Console.WriteLine("数量の確認が終わりました。");

static void PrintQuantity(int quantity)
{
    if (quantity < 1 || quantity > 10)
    {
        Console.WriteLine("数量は1以上10以下にしてください。");
        return;
    }

    Console.WriteLine($"注文する数量：{quantity}個");
}
