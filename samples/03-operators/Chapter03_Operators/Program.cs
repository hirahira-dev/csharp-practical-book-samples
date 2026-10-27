string productName = "ノート";
decimal unitPrice = 120m;
int quantity = 10;
decimal discountPerItem = 20m;
const decimal FreeShippingThreshold = 1000m;

decimal subtotal = unitPrice * quantity;
decimal discountTotal = discountPerItem * quantity;
decimal total = subtotal - discountTotal;
bool isFreeShipping = total >= FreeShippingThreshold;

Console.WriteLine($"商品名：{productName}");
Console.WriteLine($"小計：{subtotal}円");
Console.WriteLine($"値引き額：{discountTotal}円");
Console.WriteLine($"値引き後の金額：{total}円");
Console.WriteLine($"送料無料の条件を満たす：{isFreeShipping}");
