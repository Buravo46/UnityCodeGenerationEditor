##【Unity】CSharpClassGenerationEditor

####概要
このエディタは簡易的にCSharpのクラスを生成することができます。

####利用方法

このエディタはメニューの(CustomMenu/Script/CSharp Class Generation Editor)で呼び出し、項目を設定することでクラスの生成ができます。

設定するエディタの項目には

+ Output Path : 生成するコードの吐き出すパスの設定
+ Summary : 生成するコードの概要
+ Author Name : 作成者名
+ Class Access Level : 生成するコードのクラスアクセスレベル
+ Constructor Access Level : 生成するコードのコンストラクタで使用するアクセスレベル
+ Class Name : クラス名
+ Base Name : 基底クラス名
+ Use Field : フィールドの使用
+ Search Library : ライブラリの検索
+ Library List : 使用するライブラリ一覧
+ Search Method : 関数の検索
+ CSharp Method List : 使用する関数一覧
+ All View Method Check In : 表示されている関数一覧の関数を全てチェックインする
+ All View Method Check Out : 表示されている関数一覧の関数を全てチェックアウトする
+ Setting Script Component : デフォルトの設定
+ Code Generartion : コード生成
があります。

上記項目を設定してCode Generartionボタンを押すことでコードが生成されます。

このエディタを使用する場合はCommonフォルダとセットで使用する必要があります。
同階層のディレクトリに配置するようにご注意ください。

