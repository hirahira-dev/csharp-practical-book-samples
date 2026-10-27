# 第4章のサンプル

第4章「条件によって処理を分けよう」の入力変換例と、数量の受付条件をレビューする演習です。.NET 10、C# 14、Nullable有効、暗黙的なusing有効で動作します。

| プロジェクト | 用途 |
| --- | --- |
| `Chapter04_Conditionals/Chapter04_Conditionals.csproj` | 本文の「TryParseで受け取る二つの結果」の完成例。TryParseの成否で表示を分ける。数量の受付範囲は確認せず、nullも変換失敗として扱う。 |
| `AiQuantityReview/Chapter04_Exercise/Chapter04_Exercise.csproj` | 学習用に問題を組み込んだ演習版。1個と10個を受け付けない。通常の完成例ではない。 |
| `AiQuantityReview/Chapter04_Corrected/Chapter04_Corrected.csproj` | 受付範囲を1以上10以下へ直した修正版。入力終了・変換失敗・範囲外・受付成功を区別する。 |

Visual Studio 2026で対象のcsprojを開き、Ctrl+F5で実行します。本文の各コード例は、特に指定がなければProgram.cs全体を置き換えて試してください。修正箇所として示した1行だけの例は、指定した行へ組み込みます。

CLIではリポジトリのルートから実行できます。

```powershell
dotnet run --project samples/04-conditions/Chapter04_Conditionals/Chapter04_Conditionals.csproj
dotnet run --project samples/04-conditions/AiQuantityReview/Chapter04_Exercise/Chapter04_Exercise.csproj
dotnet run --project samples/04-conditions/AiQuantityReview/Chapter04_Corrected/Chapter04_Corrected.csproj
```

## 演習の要求と確認結果

入力は一度だけ受け取り、再入力しません。単価は120円です。

| 入力 | 要求／修正版 | 問題入りの演習版 |
| --- | --- | --- |
| 0、11 | 範囲外の案内だけを表示 | 要求どおり |
| 1 | 受付と小計120円を表示 | 範囲外と判定してしまう |
| 10 | 受付と小計1200円を表示 | 範囲外と判定してしまう |
| 3 | 受付と小計360円を表示 | 要求どおり |
| ノート、空文字列、3.5、2147483648 | 整数入力の案内だけを表示 | 要求どおり |
| null（入力終了） | 入力終了の案内だけを表示 | 要求どおり |

修正するのは受付範囲の比較演算子です。null確認、変換失敗の分岐、decimalに推論されるvar、受付ブロック内だけで使う変数の宣言は、要求に合っているため変更しません。

nullを手動で確認する場合は、本文の案内どおりReadLineの行を一時的にnullの代入へ置き換え、確認後は戻します。Enterだけを押した入力はnullではなく空文字列です。

## 参考資料

- [if文とswitch文](https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/statements/selection-statements)：分岐の実行とbreak、defaultの扱い。
- [Int32.TryParse](https://learn.microsoft.com/ja-jp/dotnet/api/system.int32.tryparse?view=net-10.0)：戻り値とoutの結果、null・空文字列・範囲外の数値の扱い。
- [switch式](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression)：候補と値の対応、網羅されない場合の動作。
- [条件演算子](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator)：条件に応じた値の選択。
- [Visual Studioのデバッガー](https://learn.microsoft.com/en-us/visualstudio/debugger/debugger-feature-tour?view=visualstudio)：停止位置、ステップオーバー、変数の確認。
- [Visual Studioのショートカット](https://learn.microsoft.com/en-us/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio?view=visualstudio)：F9、F5、F10、Shift+F5の操作。
