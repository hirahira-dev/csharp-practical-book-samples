# 第15章のサンプル

| プロジェクト | 内容 |
| --- | --- |
| `Chapter15_AsyncAwait` | 保存完了後に成功と表示し、保存内容を読み返す例 |
| `Chapter15_Exercise` | AI提案例として、完了を待つ前に成功と表示する問題入りコード |
| `Chapter15_Corrected` | 成功表示の前にawaitする修正版。順序確認用の待ち時間と表示を含む |
| `Chapter15_SaveNote` | 確認用の待ち時間と表示を除いた通常の保存例 |

ファイルは実行時の作業フォルダーへ保存します。同名のファイルは上書きするため、実習専用のファイル名で使ってください。`Chapter15_AsyncAwait`は作業フォルダーも表示します。

演習では`path`を`chapter15-review.txt`と`.`へ変え、毎回起動し直します。`.`は既存の作業フォルダーを指すため、ファイルとして書き込めず失敗します。権限設定の変更や既存ファイルの削除は不要です。

| 例 | 保存成功 | 保存失敗 |
| --- | --- | --- |
| 演習版 | 保存しました。→書き込み完了 | 成功表示の後に失敗表示。要求違反 |
| 修正版 | 書き込み完了→保存しました。 | 失敗表示のみ |
| 通常例 | 保存しました。 | 失敗表示のみ |

演習版は学習用の問題を含み、通常の完成例ではありません。関数内の逐次awaitと例外捕捉は残し、呼び出し側の待つ位置を修正します。

## 技術確認資料

- [Microsoft Learn：非同期プログラミング](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/)
- [Microsoft Learn：非同期プログラミングのシナリオ](https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios)
