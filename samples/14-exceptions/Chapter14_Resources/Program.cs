string path = "chapter14-note.txt";

try
{
    using StreamReader reader = new StreamReader(path);
    string content = reader.ReadToEnd();
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("ファイルが見つからないため、表示を中止します。");
}
