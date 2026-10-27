# 第3章のサンプル

第3章「演算子を使って値を計算・比較しよう」の完成例と、整数除算を確かめる例です。.NET 10、C# 14、Nullable有効、暗黙的なusing有効で動作します。

| プロジェクト | 用途 |
| --- | --- |
| `Chapter03_Operators/Chapter03_Operators.csproj` | 「注文金額と送料無料の条件を確かめる」の完成例。値引き後の金額と送料無料の判定を表示する。送料を加えた支払額は計算しない。 |
| `IntegerDivision/Chapter03_Exercise/Chapter03_Exercise.csproj` | 平均価格の小数部分が失われる原因を調べるための演習版。コンパイルできるが、求めたい平均価格を得られない。完成例ではない。 |
| `IntegerDivision/Chapter03_Corrected/Chapter03_Corrected.csproj` | 割り算の前にdecimalへ変換する修正版。1001円・2個から500.5円を求める。 |

Visual Studio 2026では、対象のcsprojを開き、Ctrl+F5で実行してください。本文の短いコードは、それぞれProgram.cs全体を置き換えて試せます。本文中の1行の置き換え指示は、その行だけを変更します。

CLIでは、リポジトリのルートで次のコマンドを使います。

```powershell
dotnet run --project samples/03-operators/Chapter03_Operators/Chapter03_Operators.csproj
dotnet run --project samples/03-operators/IntegerDivision/Chapter03_Exercise/Chapter03_Exercise.csproj
dotnet run --project samples/03-operators/IntegerDivision/Chapter03_Corrected/Chapter03_Corrected.csproj
```

## 確認する結果

| 確認対象 | 期待する結果 |
| --- | --- |
| 注文10個 | 小計1200円、値引き200円、値引き後1000円、送料無料の条件を満たすTrue |
| 注文9個・11個 | 値引き後900円・1100円、送料無料の判定False・True |
| 正しい別の式 | `(unitPrice - discountPerItem) * quantity`も、同じ数量で同じ金額になる |
| 整数除算の演習版／修正版 | 合計1001円・2個では500円／500.5円。合計1000円なら両者とも500円 |
| 変換するタイミング | `(decimal)(totalPrice / quantity)`では、1001円・2個でも500円になり、小数部分を取り戻せない |
| 数量の範囲 | 1以上10以下なら、0・1・10・11に対してFalse・True・True・False |
| 短絡評価 | 数量0なら右側を計算せずFalse、数量2なら平均500.5円が予算600円以内なのでTrue |

整数除算の演習版や、かっこなしの計算はC#の動作を理解するための比較例であり、特定のAI出力を再現したものではありません。

## 参考資料

- [算術演算子](https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/arithmetic-operators)：整数除算、剰余、複合代入、増減の仕様。
- [ブール論理演算子](https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/boolean-logical-operators)：&&と||の短絡評価、!と優先順位。
- [演算子と式](https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/)：式と演算子の優先順位。
