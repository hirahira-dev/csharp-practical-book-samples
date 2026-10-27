List<int> quantities = new List<int> { 3, 0, 10, 1, 11 };

List<int> selectedQuantities = quantities
    .Where(quantity => quantity >= 1 && quantity <= 10)
    .OrderBy(quantity => quantity)
    .ToList();

foreach (int quantity in selectedQuantities)
{
    Console.WriteLine(quantity);
}

Console.WriteLine($"件数：{selectedQuantities.Count}");
