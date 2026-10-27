# 第14章のサンプル

| プロジェクト | 本文の対応箇所 |
| --- | --- |
| `Chapter14_Exceptions` | 読み込み関数の呼び出し元で捕捉し、失敗時は表示を中止する完成例 |
| `Chapter14_Resources` | using宣言でStreamReaderを解放する例 |
| `Chapter14_Exercise` | 空のcatch後に成功と表示する、AI提案例としての問題入り教材 |
| `Chapter14_Corrected` | 失敗時に理由を表示して終了する修正版 |

## 実行する前に

本文冒頭の準備コードを、実行するプロジェクトの`Program.cs`で一度動かしてください。表示された作業フォルダーに`chapter14-note.txt`を作ります。同名のファイルを上書きするため、実習専用のファイルとして使います。その後、各プロジェクトのコードへ戻してください。

プロジェクトを切り替えると作業フォルダーが変わる場合があります。サンプルコードにファイルの自動作成は含めていません。本文の準備コードで、使用するフォルダーとファイルを確認します。

`path`を`chapter14-note.txt`と、存在しない`missing-note.txt`へ変え、毎回起動し直します。

- 完成例・修正版：ファイルありなら内容と成功表示。なしなら中止理由だけを表示。
- 演習版：ファイルなしでも空の行と成功表示が出る。通常の完成例として使わない。
- リソース例：ファイルありなら内容表示。なしなら中止理由を表示。

この章ではFileNotFoundExceptionを中心に検証しています。他の種類の失敗をすべて捕捉するアプリではありません。

## 確認資料

- [Microsoft Learn：例外のベストプラクティス](https://learn.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions)
- [Microsoft Learn：例外処理の文](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements)
- [Microsoft Learn：ASP.NET Coreのエラー処理](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling-api?view=aspnetcore-10.0)
