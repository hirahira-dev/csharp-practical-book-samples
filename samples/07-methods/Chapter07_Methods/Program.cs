decimal price = 120m;
int orderQuantity = 3;

decimal amount = CalculateSubtotal(price, orderQuantity);
Console.WriteLine($"小計：{amount}円");

static decimal CalculateSubtotal(decimal unitPrice, int quantity)
{
    decimal subtotal = unitPrice * quantity;
    return subtotal;
}
