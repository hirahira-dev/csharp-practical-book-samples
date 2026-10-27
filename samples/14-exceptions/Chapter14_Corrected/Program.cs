string path = "chapter14-note.txt";
string content;

try
{
    content = File.ReadAllText(path);
}
catch (FileNotFoundException)
{
    Console.WriteLine("ファイルが見つからないため、表示を中止します。");
    return;
}

Console.WriteLine(content);
Console.WriteLine("読み込みに成功しました。");
