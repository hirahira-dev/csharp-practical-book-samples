string path = "chapter15-note.txt";
Console.WriteLine($"作業フォルダー：{Directory.GetCurrentDirectory()}");

await File.WriteAllTextAsync(path, "資料の準備ができました。");
Console.WriteLine("保存しました。");

string content = await File.ReadAllTextAsync(path);
Console.WriteLine(content);
