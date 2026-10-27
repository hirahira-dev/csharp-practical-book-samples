List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

var sortedNumbers = numbers
    .Where(number => number % 2 == 0)
    .OrderBy(number => number);

foreach (int number in sortedNumbers)
{
    Console.WriteLine(number);
}
