## 目的

C#のソースジェネレーターの使い方に関する個人的まとめ

[使い方に関するまとめ](./HotChocoErrorFilterGeneratorSample.ErrorFilterGenerator/README.md)

## プロジェクト構成

### メインプロジェクト

./HotChocoErrorFilterGeneratorSample.WebApi/

ASP.NET Core のテンプレートから作成<br>
C#で GraphQL を実装するためのライブラリである HotChocolate を使って検証用の Query API を作ってある<br>
メインプロジェクトに例外クラスを作成していき、その例外クラスを読み込んで自動でエラーフィルターを生成してもらうようにする

### ソースジェネレータープロジェクト

./HotChocoErrorFilterGeneratorSample.ErrorFilterGenerator/

メインプロジェクトの構文解析結果を読み込んでソース生成を行う用のプロジェクト
