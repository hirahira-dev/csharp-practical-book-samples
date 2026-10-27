# 第5章のサンプル

第5章「繰り返し処理を使おう」の完成例です。.NET 10、C# 14、Nullable有効、暗黙的なusing有効で動作します。

| プロジェクト | 内容 |
| --- | --- |
| `Chapter05_Loops/Chapter05_Loops.csproj` | 最初のforeachの例。配列の商品名を順に表示する。本文の短い例はProgram.cs全体を置き換えて試せる。 |
| `Chapter05_QuantityRetry/Chapter05_QuantityRetry.csproj` | 変換失敗や範囲外では再入力し、1以上10以下なら注文と小計を表示して終了する。nullなら入力終了の案内で止める。 |

Visual Studio 2026で対象のcsprojを開き、Ctrl+F5で実行します。ステップ実行の実習では、本文どおりF9でブレークポイントを置き、F5で開始してF10で進めます。

CLIではリポジトリのルートから実行してください。

```powershell
dotnet run --project samples/05-loops/Chapter05_Loops/Chapter05_Loops.csproj
dotnet run --project samples/05-loops/Chapter05_QuantityRetry/Chapter05_QuantityRetry.csproj
```

## 入力と期待結果

数量の再入力では、単価120円、受付範囲1以上10以下を使います。

| 入力する順番 | 期待する結果 |
| --- | --- |
| 1／10 | それぞれ小計120円／1200円で受け付け、終了 |
| ノート → 0 → 3 | 変換失敗の案内、範囲外の案内の後、3個・360円で受け付けて終了 |
| 0 → 11 → 3 | 範囲外の案内を2回表示し、3個を受け付けて終了 |
| Enterだけ → 2 | 変換失敗の案内の後、2個・240円で受け付けて終了 |
| 入力終了 | 入力終了の案内で停止し、受付・小計を表示しない |
| 無効な入力の後で入力終了 | 一度再入力を求めた後、入力終了の案内で停止する |

nullは、本文の案内どおりReadLineの行を一時的にnullの代入へ置き換えて確認できます。確認後は元へ戻します。

本文の演習では、変換失敗時に終了してしまうコードを読み、再入力するように修正します。Chapter05_QuantityRetryは修正後の例です。

## 参考資料

- [繰り返しステートメント](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)：forの初期化・条件・更新の順序、foreach、while、ループ変数の範囲。
- [ジャンプステートメント](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements)：breakが抜ける範囲、continue後の処理。
- [配列](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)：初期化、0始まりのインデックス、Length。
- [Listの列挙子](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.enumerator?view=net-10.0)：列挙中の一覧変更で問題が起きる例の根拠。本文では実装の詳細へ広げない。
- [Visual Studioのデバッガー](https://learn.microsoft.com/en-us/visualstudio/debugger/debugger-feature-tour?view=visualstudio)：ブレークポイント、ステップ実行、変数の確認。
