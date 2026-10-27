# 『AI時代のC#実践入門』サンプルコード

## このリポジトリについて

書籍『AI時代のC#実践入門』の読者向けサンプルコードです。各章に対応するフォルダに、完成例や途中段階のコード、演習用のコードを収録しています。

本文に沿って自分でコードを書き、実行した結果を確認してください。サンプルは、動作を確かめたり、途中で動かなくなったコードと比較したりするときに使えます。

## 動作環境

- Visual Studio 2026（推奨）
- .NET 10
- C# 14

各プロジェクトでNullableを有効にしています。.NET 10 SDKが利用できる環境では、コマンドラインからもビルド・実行できます。

## サンプルコードの使い方

1. ダウンロードしたファイルを展開し、下の表から学習する章のフォルダを開きます。
2. 章のREADMEで目的に合うサンプルを選び、そのプロジェクトの`.csproj`をVisual Studioで開きます。第1章は`samples/01-getting-started/FirstApp/FirstApp.csproj`から始めてください。
3. `Program.cs`や関連するクラスを開き、本文と比べながらコードを読みます。
4. `Ctrl`+`F5`で実行し、表示や入力に対する動きを本文と比較します。

演習版には、要求に合わない処理や、意図的に実行時エラーになる処理が含まれます。各章のREADMEで完成例・演習版・修正版の違いを確認してください。

CLIを使う場合は、このREADMEがあるフォルダで、例えば次を実行します。

```powershell
dotnet build samples/01-getting-started/FirstApp/FirstApp.csproj
dotnet run --project samples/01-getting-started/FirstApp/FirstApp.csproj
```

## 章とフォルダの対応

| 章 | 内容 | フォルダ |
| --- | --- | --- |
| 第1章 | まずはC#を書いて動かしてみよう | [samples/01-getting-started](samples/01-getting-started/) |
| 第2章 | 変数とデータ型を理解しよう | [samples/02-variables-types](samples/02-variables-types/) |
| 第3章 | 演算子を使って値を計算・比較しよう | [samples/03-operators](samples/03-operators/) |
| 第4章 | 条件によって処理を分けよう | [samples/04-conditions](samples/04-conditions/) |
| 第5章 | 繰り返し処理を使おう | [samples/05-loops](samples/05-loops/) |
| 第6章 | 配列・List・Dictionaryを使い分けよう | [samples/06-collections](samples/06-collections/) |
| 第7章 | メソッドを使って処理を分けよう | [samples/07-methods](samples/07-methods/) |
| 第8章 | LINQでデータを検索・加工しよう | [samples/08-linq](samples/08-linq/) |
| 第9章 | クラスとオブジェクトを理解しよう | [samples/09-classes](samples/09-classes/) |
| 第10章 | enumで状態をわかりやすく表現しよう | [samples/10-enum](samples/10-enum/) |
| 第11章 | recordとclassを使い分けよう | [samples/11-record](samples/11-record/) |
| 第12章 | 継承・インターフェース・ポリモーフィズムを理解しよう | [samples/12-oop-advanced](samples/12-oop-advanced/) |
| 第13章 | nullを安全に扱おう | [samples/13-null](samples/13-null/) |
| 第14章 | 例外処理を正しく使おう | [samples/14-exceptions](samples/14-exceptions/) |
| 第15章 | async / awaitで非同期処理を書こう | [samples/15-async-await](samples/15-async-await/) |
| 第16章 | タスク管理アプリを作ろう | [samples/16-todo-app](samples/16-todo-app/) |
| 第17章 | タスクをJSONファイルに保存しよう | [samples/17-json-file](samples/17-json-file/) |

## 第16章・第17章について

第16章の完成例は[samples/16-todo-app/Chapter16_TodoApp](samples/16-todo-app/Chapter16_TodoApp/)です。[stages](samples/16-todo-app/stages/)には、追加・一覧・完了・検索を順に組み込んだ4段階のコードがあります。

第17章の[samples/17-json-file/Chapter16_TodoApp](samples/17-json-file/Chapter16_TodoApp/)は、第16章のアプリへJSON保存・復元を追加した完成例です。本文では新しいプロジェクトを作らず、第16章のプロジェクトを引き続き編集します。サンプルでは両方の完成状態を比較できるよう、章ごとに保存しています。

保存データを確認する教材は、第17章の[fixtures](samples/17-json-file/fixtures/)にあります。使い方は[第17章のREADME](samples/17-json-file/README.md)を参照してください。

## サンプルと本文が違って見える場合

本文の手順に沿って作成することを基本に、サンプルは完成状態や途中状態の確認に使ってください。本文の途中段階では、その後の節で追加するコードがまだ含まれていない場合があります。比較するときは、同じ段階のコードかどうかを確かめましょう。

## License

本リポジトリのサンプルコードはMIT Licenseで公開します。

書籍本文、画像、スクリーンショット、その他の書籍コンテンツはMIT Licenseの対象外です。
