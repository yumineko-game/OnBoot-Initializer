# OnBoot Initializer

Unity起動時に初期化シーンを自動的に読み込むためのシンプルなパッケージです。

## 機能

- アプリケーション起動時に、BuildIndex = 0のシーンを初期化シーンとして読み込みます
- Editorモードでは設定ウィンドウから機能のON/OFFを切り替え可能です

## インストール方法

以下のいずれかの方法でインストールできます：

1. Package ManagerのGitHub URLから：
   ```
   https://github.com/yumineko-game/OnBoot-Initializer.git
   ```

2. manifest.jsonに直接追加：
   ```json
   {
     "dependencies": {
       "com.yumineko.onboot-initializer": "https://github.com/yumineko-game/OnBoot-Initializer.git"
     }
   }
   ```

## 使用方法

1. 初期化用のシーンを作成し、Build Settingsで最初のシーン（BuildIndex = 0）として設定します
2. Editorモードで使用する場合：
   - メニューから `Window > Yumineko > OnBoot Initializer Settings` を開きます
   - チェックボックスをONにすることで機能が有効になります

## 依存パッケージ

- [UniTask](https://github.com/Cysharp/UniTask)