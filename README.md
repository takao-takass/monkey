# 🐒monkey

- 予算管理をするアプリケーション

# 🧭技術（予定）
### 使用技術
- Frontend
  - [Avalonia UI](https://avaloniaui.net/)
- Backend
  - [ASP.NET Core](https://dotnet.microsoft.com/ja-jp/apps/aspnet)
- Database
  - [Cockroach DB](https://cockroachlabs.cloud/)

### 選定理由
気になってたものをかき集めてみた。深い理由はない。これら技術による開発がどのような感じなのかを検証する目的もある。一応の理由は以下の通り。

- 前提として.NET系を軸とした選定を行う。
- ASP.NET Core
    - .NETのWebフレームワークのド定番。
- Avalonia UI
    - .NET系のフロントエンド技術。
    - ネイティブアプリ版とブラウザ版の両方を作りたかったが、Microsoft純正フレームワークの`MAUI`はブラウザに対応していなかった。（Blazorと組み合わせれば可能らしいが。）
- Cockroach DB
    - いわゆるNew SQLと呼ばれているデータベース群の１つ。New SQL使ってみたさで選定してみた。（あとは無料枠があるのも決め手）
