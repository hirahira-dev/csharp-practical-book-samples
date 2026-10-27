# 第8章のサンプル

List<int>とList<string>でLINQの絞り込み・並べ替え・変換・検索を学ぶ教材です。.NET 10、C# 14、Nullable有効、暗黙的なusing有効で動作します。

| プロジェクト | 内容 |
| --- | --- |
| `Chapter08_Linq/Chapter08_Linq.csproj` | 偶数を選び、小さい順に表示する完成例。 |
| `Chapter08_ProductSearch/Chapter08_ProductSearch.csproj` | 商品名をFirstOrDefaultで探し、nullなら案内する完成例。 |
| `AiLinqReview/Chapter08_Exercise/Chapter08_Exercise.csproj` | 数量1を除外する条件と、逆の並び順を含む演習版。コンパイルはできるが要求を満たさない。 |
| `AiLinqReview/Chapter08_Corrected/Chapter08_Corrected.csproj` | 1以上10以下を小さい順に表示し、件数を表示する修正版。 |

本文のその他のコード例は、Program.cs全体を置き換えて試します。入力待ちはありません。

## 実行方法

Visual Studioでは対象のcsprojを開きます。CLIではリポジトリのルートから、例えば次のように実行します。

```powershell
dotnet run --project samples/08-linq/Chapter08_Linq/Chapter08_Linq.csproj
dotnet run --project samples/08-linq/AiLinqReview/Chapter08_Corrected/Chapter08_Corrected.csproj
```

## 演習

要求は、数量の一覧から1以上10以下を選び、小さい順に表示し、件数も表示することです。元の一覧は変更しません。学習用の問題を二つ組み込んだコードです。

| 確認 | 結果 |
| --- | --- |
| 演習版：3、0、10、1、11 | 10、3の順で件数2。数量1がなく、降順になっている |
| 条件だけ修正 | 10、3、1の順で件数3。並び順の問題が残る |
| 並び順だけ修正 | 3、10の順で件数2。数量1の問題が残る |
| 修正版：3、0、10、1、11 | 1、3、10の順で件数3 |
| 修正版：0、11 | 件数0だけ |
| 修正版：空のList | 件数0だけ |

ToList、foreach、ListのCountと、上限の条件は正しいため維持します。各処理と具体的な結果を考え、予測・実行・要求との比較・必要な修正・再実行を行います。

## 参考資料

- [Whereと遅延評価](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-10.0)
- [FirstOrDefaultの戻り値](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=net-10.0)
- [ToListでの結果の取得](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.tolist?view=net-10.0)
- [ラムダ式](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions)
