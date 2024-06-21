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
    - Avalonia UI
        - .NETで使えるサードパーティ製のクロスプラットフォーム対応フレームワーク
        - クロスプラットフォーム対応のフレームワークとしては、Microsoft純正フレームワークの`MAUI`もある。ただ、こちらはブラウザに対応していなかった。
            - Blazorと組み合わせれば可能らしいが、ちょっと手間取りそうなので、素でブラウザにも対応しているものを選定。
    - ASP.NET Core
        - .NETのWebフレームワークのド定番。
        - `takao-takass`の中で習熟度が一番高いフレームワーク。
            - 今回はバックエンドの基盤はサクっと作りたかったので、習熟度が一番高いものを選んだ。
    - Cockroach DB
        - いわゆるNew SQLと呼ばれているデータベース群の１つ。New SQL使ってみたさで選定してみた。
        - メジャーなNew SQL製品はだいたいMySQL互換だが、こちらはPostgreSQL互換。
        - PostgreSQLは全く使ったことが無いので興味が湧いた。
