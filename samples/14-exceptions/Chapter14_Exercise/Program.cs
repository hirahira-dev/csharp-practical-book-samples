string path = "chapter14-note.txt";
string content = "";

try
{
    content = File.ReadAllText(path);
}
catch (FileNotFoundException)
{
}

Console.WriteLine(content);
Console.WriteLine("読み込みに成功しました。");
