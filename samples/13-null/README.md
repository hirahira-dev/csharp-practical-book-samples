# 第13章のサンプル

null許容型と関連演算子を、任意の期限とタスク検索へ応用するサンプルです。

| プロジェクト | 内容 |
| --- | --- |
| `Chapter13_Null` | 本文の「タスクが見つからない場合を扱う」の完成例 |
| `Chapter13_Exercise` | 問題入り演習版。IDが99だと意図的に例外が発生する |
| `Chapter13_Corrected` | タスクの有無を先に確認する修正版 |

各`Program.cs`の`targetId`を1、2、99へ変更して、毎回起動し直します。

| ID | 完成例・修正版の期待結果 | 演習版 |
| --- | --- | --- |
| 1 | 資料を作る／期限：2026-10-01 | 同じ表示 |
| 2 | 机を片付ける／期限：期限なし | 同じ表示 |
| 99 | タスクが見つかりません。 | NullReferenceException |

演習版は通常の完成例ではありません。null免除演算子による警告抑制と、実行時に値があることの違いを確かめます。期限をnullで表すこと、タスクがある場合の`?.`と`??`による表示は正しい部分です。

## 技術確認資料

- [Microsoft Learn：null許容参照型](https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references)
- [Microsoft Learn：null許容値型](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
- [Microsoft Learn：null条件演算子](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-conditional-operators)
- [Microsoft Learn：??と??=](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)
- [Microsoft Learn：null免除演算子](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving)
