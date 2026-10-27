# 第7章のサンプル

メソッドの引数・戻り値・早期returnを、staticローカル関数で学ぶ完成例です。.NET 10、C# 14、Nullable有効、暗黙的なusing有効で動作します。

| プロジェクト | 内容 |
| --- | --- |
| `Chapter07_Methods/Chapter07_Methods.csproj` | 単価と数量を渡し、小計を受け取る完成例。本文の短い例はProgram.csを置き換えて試す。 |
| `Chapter07_GuardClause/Chapter07_GuardClause.csproj` | 数量が範囲外なら早期returnし、呼び出し元へ戻る完成例。 |
| `Chapter07_OrderOriginal/Chapter07_OrderOriginal.csproj` | 第5章の数量再入力の例を保存した比較元。 |
| `Chapter07_OrderMethods/Chapter07_OrderMethods.csproj` | 判定・計算・表示を分けた共通の分割例。 |

すべて通常の完成例です。意図的な問題を含む演習版はありません。入力・変換・再入力はトップレベル側のwhileに残し、判定・計算・表示だけを関数へ分けています。

## 実行方法

Visual Studioでは対象のcsprojを開きます。CLIではリポジトリのルートから、例えば次のように実行します。

```powershell
dotnet run --project samples/07-methods/Chapter07_Methods/Chapter07_Methods.csproj
dotnet run --project samples/07-methods/Chapter07_OrderOriginal/Chapter07_OrderOriginal.csproj
dotnet run --project samples/07-methods/Chapter07_OrderMethods/Chapter07_OrderMethods.csproj
```

注文の2プロジェクトでは数量を入力します。有効な数量を受け付けるか、入力が終了すると終了します。nullの分岐は、本文の案内どおり入力を受け取る行を一時的に`string? quantityText = null;`へ置き換えて確認できます。確認後は元へ戻してください。

## 分割前後の比較

数量1、0から3への再入力、ノートから3への再入力、入力終了の4ケースで、分割前後の動作を比較します。最初は各関数の役割・引数・戻り値の使い道を読み、結果を予測します。

分割前後で同じ入力を使い、表示内容と処理の終わり方が変わっていないか確認します。

## 参考資料

- [ローカル関数の定義とstaticの制約](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
- [最上位レベルのステートメント](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)
- [メソッドの引数と戻り値](https://learn.microsoft.com/en-us/dotnet/csharp/methods)
- [returnと制御の移動](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements)
