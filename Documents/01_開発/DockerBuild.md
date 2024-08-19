# Docker ImageのビルドおよびPUSH

### ビルドコマンド

dockerfileがあるディレクトリで実行する。

``` bash
cd <dockerfileがあるディレクトリ>
docker build -t <image_name>:<tag> .
```

### PUSHコマンド

``` bash
docker login
docker push <image_name>:<tag>
```