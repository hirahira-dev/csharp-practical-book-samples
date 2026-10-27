# 第16章のサンプル

追加から始め、本文で加える順に機能を組み合わせたコンソールアプリです。

| プロジェクト | 内容 |
| --- | --- |
| `stages/Chapter16_AddTasks` | タイトル・優先度・任意の期限を入力して追加 |
| `stages/Chapter16_ListTasks` | 追加と一覧表示 |
| `stages/Chapter16_CompleteTasks` | IDを指定する完了操作を追加 |
| `stages/Chapter16_SearchTasks` | タイトル検索とタイトル順の表示を追加 |
| `Chapter16_TodoApp` | 追加・一覧・完了・検索を備えた完成例 |

各プロジェクトの`Program.cs`、`TodoItem.cs`、`TodoStatus.cs`、`TodoPriority.cs`で動きます。実行例は次のとおりです。

```text
dotnet run --project samples/16-todo-app/Chapter16_TodoApp
```

各アプリは空の一覧から始め、終了するとデータは失われます。JSON保存や非同期I/Oは第17章で追加します。

完成時のメニューは`1:追加  2:一覧  3:完了  4:検索  0:終了`です。`Chapter16_SearchTasks`と完成例は同じ機能を持ちます。

## 第17章への引き継ぎ

`TodoItem`はID・タイトル・状態・優先度・任意の期限を、一つの公開コンストラクタで受け取り保持します。引数名と型はプロパティに対応させています。IDを生成したり状態を未着手へ戻したりする処理を、コンストラクタへ入れていません。

`RunMenu`は終了時に呼び出し元へ戻ります。第17章では読み込み・検証に成功してからメニューを呼び、その後に保存します。保存値の検証や、復元した最大IDからの採番再開は第17章で扱います。第16章の採番は空の一覧から1ずつ進める範囲です。

## 技術確認資料

- [Microsoft Learn：DateTime.TryParse](https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tryparse?view=net-10.0)
- [Microsoft Learn：String.IsNullOrWhiteSpace](https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-10.0)
