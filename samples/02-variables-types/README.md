# 第2章のサンプル

`Chapter02_VariablesTypes/Program.cs`は、第2章「キーボードから文字列を受け取る」の完成例です。商品名を1行読み取り、「入力した商品名：」に続けて表示します。商品名の検証や数値の入力判定は第4章以降で扱います。

章末の演習は`AiProductReview/`に分けてあります。`Chapter02_Exercise/`は要求に合わない箇所を意図的に含む演習版、`Chapter02_Corrected/`は修正版です。既存のChapter02_VariablesTypesはそのまま使用します。

## 実行方法

Visual Studio 2026で`Chapter02_VariablesTypes/Chapter02_VariablesTypes.csproj`を開き、`Ctrl`+`F5`で実行します。プロジェクトは.NET 10、C# 14、Nullable有効、暗黙的なusing有効です。

リポジトリのルートからCLIで実行する場合は、次のコマンドを使います。

```powershell
dotnet build samples/02-variables-types/Chapter02_VariablesTypes/Chapter02_VariablesTypes.csproj
dotnet run --project samples/02-variables-types/Chapter02_VariablesTypes/Chapter02_VariablesTypes.csproj
```

商品名として`ノート`などを入力してEnterを押してください。空行や入力終了の場合は商品名の表示が空になります。この段階では、入力を受け取って表示する動きを確認します。

## 本文中の短い例

各C#コードブロックは、特に断りがなければそれぞれ`Program.cs`全体を置き換えて試します。複数の例を同じファイルへ続けて貼り付けないでください。演習の修正例で示す1行だけは、演習コードの先頭行を置き換えます。

「nullの可能性を知らせる警告」の例だけは、警告を確認するために意図的に`string`で入力を受け取ります。通常の完成例には含めていません。確認後は`string?`へ戻してください。

## 演習の進め方

本文で要求を確認し、演習版のコードを読みます。変数ごとの型・初期値・後の代入を読み取り、表示を予測してから実行してください。結果を要求と照合し、違いの理由を説明して修正し、再実行します。修正版は結果を確認してから参照します。

Visual Studioでは、次のどちらかのプロジェクトを開き、Ctrl+F5で実行します。両者とも.NET 10、C# 14、Nullable有効です。

- 演習版：`AiProductReview/Chapter02_Exercise/Chapter02_Exercise.csproj`
- 修正版：`AiProductReview/Chapter02_Corrected/Chapter02_Corrected.csproj`

リポジトリのルートからCLIで試す場合は、それぞれ次のコマンドを使います。

```powershell
dotnet run --project samples/02-variables-types/AiProductReview/Chapter02_Exercise/Chapter02_Exercise.csproj
dotnet run --project samples/02-variables-types/AiProductReview/Chapter02_Corrected/Chapter02_Corrected.csproj
```

| 確認対象 | 期待する表示・確認点 |
| --- | --- |
| 演習版 | 商品コードが12になり、0012を保持する要求に合わないことを確認する。数量は代入後の5個。 |
| 修正版 | 商品コード0012、商品名ノート、単価120円、数量5個。 |
| 修正版の値を変更 | 商品コードの初期値を"0007"、後の数量の代入を2にすると、0007・2個と表示され、商品名と単価は変わらない。 |

商品コードは先頭の0を保持する文字列へ修正します。商品名のstring、単価のdecimal、数量のvarによるintの型推論と後の代入は要求に合うため、変更する必要はありません。入力検証など後続章の処理は追加しません。

## 仕様の確認資料

- [Console.ReadLineの戻り値](https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-10.0)
- [小数を扱う数値型と精度・範囲・性能の違い](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)
- [定数の値の埋め込みと、共通部品を更新するときの注意](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants)
- [null許容参照型と警告](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types)
