# 第10章のサンプルコード

.NET 10 / C# 14用。基本例からTodoItemへの組み込み、入力の検証までを確認します。

| プロジェクト | 内容 |
| --- | --- |
| Chapter10_Enums | 第9章の完了フラグをStatusへ置き換えた完成例 |
| Chapter10_StatusInput | TryParseとIsDefinedで変換結果を確認し、switch式で日本語表示する完成例 |

本文ではChapter10_EnumsのProgram.csを順に置き換えます。Chapter10_StatusInputは、最後の入力実習を保存したサンプルです。入力処理に不要なTodoItem.csはこのサンプルに含めていません。

Completed、2、Unknown、99の入力で、定義済みの状態だけを受け付けるか確認します。本文の99の変換例は、TryParseだけでは定義済みと判断できないことを調べる実験用コードです。

## 仕様確認に使った公式資料

- [列挙型](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
- [既定値](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)
- [Enum.TryParse](https://learn.microsoft.com/en-us/dotnet/api/system.enum.tryparse?view=net-10.0)
- [Enum.IsDefined](https://learn.microsoft.com/en-us/dotnet/api/system.enum.isdefined?view=net-10.0)
