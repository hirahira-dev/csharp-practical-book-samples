string path = "chapter15-review.txt";

try
{
    Task saveTask = SaveNoteAsync(path, "会議資料を確認する。");
    Console.WriteLine("保存しました。");
    await saveTask;
}
catch (IOException)
{
    Console.WriteLine("保存に失敗しました。");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("この場所には保存できません。");
}

static async Task SaveNoteAsync(string path, string content)
{
    await Task.Delay(1000);
    await File.WriteAllTextAsync(path, content);
    Console.WriteLine("書き込み完了");
}
