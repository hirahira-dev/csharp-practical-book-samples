# 第17章のサンプル

第16章の`Chapter16_TodoApp`に、JSON保存・復元を追加した完成例です。本文では新しいプロジェクトを作らず、第16章のプロジェクトをそのまま編集します。このフォルダーの同名プロジェクトは、第17章の完成状態を確認するためのものです。

```text
dotnet run --project samples/17-json-file/Chapter16_TodoApp
```

メニューは`1:追加  2:一覧  3:完了  4:検索  0:終了`です。保存先は起動時に絶対パスで表示します。実行時の作業フォルダーの`tasks.json`を使い、終了時に上書きします。実習用のデータで確認してください。

## 保存・復元の確認

タスクを二件追加し、一件を完了にして終了します。再起動して、ID・タイトル・状態・優先度・期限が保存前と同じことを確認してください。続けて追加したタスクのIDは、保存済みの最大IDに1を足した値になります。

ファイルがない場合だけ、空の一覧から開始します。読み込みやデータの検証に失敗した場合は、メニューと保存へ進みません。保存が正常に完了してから「保存しました。」と表示します。

`fixtures`には、保存データの確認用ファイルを置いています。アプリを終了してから、確認したいファイルを実行先の`tasks.json`へコピーします。元の教材を直接書き換える必要はありません。

| ファイル | 確認すること |
| --- | --- |
| `valid-gap.json` | ID 1・3の次は4。保存済みの状態・優先度・期限を復元する |
| `empty.json` | 空の一覧として開始する |
| `null.json` | 空の一覧とは区別し、読み込みを中止する |
| `broken.json` | 不正なJSONでは続行しない |
| `duplicate-id.json` | IDの重複を検出する |
| `null-element.json` | 一覧内のnull要素を検出する |

読み込み失敗時には、元のファイルが書き換えられていないことも確認します。保存途中の障害からの復旧やバックアップは、このサンプルでは扱いません。

## 技術確認資料

- [Microsoft Learn：コンストラクタを使った復元](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/immutability)
- [Microsoft Learn：必須コンストラクタ引数](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/required-properties)
- [Microsoft Learn：null許容の注釈とデシリアライズ](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/nullable-annotations)
