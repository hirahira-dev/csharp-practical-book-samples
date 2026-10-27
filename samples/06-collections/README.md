# 第6章のサンプル

配列・List・Dictionaryの基本操作と、コレクションの選択を確認するレビュー課題です。.NET 10、C# 14、Nullable有効、暗黙的なusing有効で動作します。

| プロジェクト | 内容 |
| --- | --- |
| `Chapter06_Collections/Chapter06_Collections.csproj` | Listにタスク名を追加し、件数と一覧を表示する完成例。 |
| `Chapter06_ProductLookup/Chapter06_ProductLookup.csproj` | TryGetValueで商品名を取得し、未登録の場合は案内する完成例。 |
| `AiCollectionReview/Chapter06_Exercise/Chapter06_Exercise.csproj` | 学習用に二つの問題を含めた演習版。コンパイルはできるが、タスクを追加せず置き換え、未登録キーで実行時エラーになる。通常の完成例ではない。 |
| `AiCollectionReview/Chapter06_Corrected/Chapter06_Corrected.csproj` | ListのAdd・CountとDictionaryのTryGetValueを使った修正版。 |

## 実行方法

Visual Studioでは対象のcsprojを開きます。CLIではリポジトリのルートから、例えば次のように実行します。

```powershell
dotnet run --project samples/06-collections/Chapter06_Collections/Chapter06_Collections.csproj
dotnet run --project samples/06-collections/Chapter06_ProductLookup/Chapter06_ProductLookup.csproj
dotnet run --project samples/06-collections/AiCollectionReview/Chapter06_Corrected/Chapter06_Corrected.csproj
```

入力待ちはありません。本文の各コード例はProgram.cs全体を置き換えて試します。演習版は未登録キーの直接取得で意図的にエラーになるため、まず要求とコードを確認してください。

## レビュー課題

元の「資料を作る」を残して「メールを返す」を追加し、さらにタスクが増えても追加できること、登録済みの商品コードなら商品名、未登録なら案内を表示することが要求です。

先に自分で問題箇所と理由を考え、同じ要求と演習コードをAIにも渡して修正案を比較します。必要な箇所だけを修正して実行し、変更しなかった箇所の理由も確認します。見慣れない記法だけを誤りにしません。

| 確認 | 演習版 | 修正版 |
| --- | --- | --- |
| タスク追加 | 1件となり、元のタスクが消える | 元のタスクを残して2件 |
| 商品コード0099 | 実行時エラー | 未登録の案内 |
| 商品コード0012 | 商品名ノートを表示。ただしタスク追加は不適切なまま | 商品名ノートを表示、タスクも2件 |
| 修正版に買い物をするを追加 | — | 3件となり、元の2件も残る |

元コードでの配列のLengthは正しい記述です。Listへ変更した際にCountへ変えます。Dictionaryの選択、重複のないキーのAdd、foreachの表示も適切なので維持します。

## 参考資料

- [配列の固定長・初期値](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)
- [Listの基本操作とRemove](https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-collections-generic-list%7Bt%7D)
- [Dictionaryの基本操作](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-10.0)
- [TryGetValueの成否と取得値](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.trygetvalue?view=net-10.0)
