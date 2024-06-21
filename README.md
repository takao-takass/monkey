# 🐒monkey

- 予算管理をするアプリケーション
- 直近で目指すところ：スマホから使用した金額をPOSTできる

# 🧭技術
※ 相性が悪かったりした場合は随時更新
- Frontend
  - [MAUI](https://learn.microsoft.com/ja-jp/dotnet/maui/?view=net-maui-8.0)
  - Blazor
- Backend
  - [ASP.NET Core](https://dotnet.microsoft.com/ja-jp/apps/aspnet)
  - [.NET Aspire](https://learn.microsoft.com/ja-jp/dotnet/aspire/)
- Database
  - PostgreSQL

# 進行予定
* バックエンド（Aspire+ASP.NET Core WebAPI）
* ブラウザ版フロント（Blazor）
* ネイティブ版フロント（MAUI）
* 運用環境構築

# 運用環境
### 一旦オンプレミスで動かす。
- Web版フロントコンテナ
- WebAPIコンテナ
- PostgreSQLコンテナ
- （願望）Minikube使えたら使ってみたいなぁ
- （必須）自動デプロイの方法を検討する必要あり。
  - コンテナレジストリをどこに置くか。
  - オンプレマシンはどうやってコンテナレジストリの更新を検知するか。
  - オンプレマシンはどうやって自動で新イメージを取得するか。
  - 上記をどのCI/CD製品でやるのか。または自分でスクリプトを書いて仕組みを構築するのか。
- （必須）オンプレ用のマシンを準備する
  - Linux OSのセットアップをやる。
