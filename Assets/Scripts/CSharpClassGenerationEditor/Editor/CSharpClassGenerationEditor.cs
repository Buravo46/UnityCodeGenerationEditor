using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;
/*===============================================================*/
/**
* CSharp用のクラス生成エディタ
* 2015年2月4日 Buravo
*/
public class CSharpClassGenerationEditor : EditorWindow
{
    #region メンバ変数
    /*===============================================================*/
    /**
    * @brief コードのパス
    */
    private string m_path = "Assets/";
    /**
    * @brief 概要
    */
    private string m_summary;
    /**
    * @brief 作成者
    */
    private string m_author;
    /**
    * @brief クラスのアクセスレベル
    */
    private string[] m_class_access_levels;
    /**
    * @brief クラスのアクセスレベルの添え字
    */
    private int m_class_access_levels_index;
    /**
    * @brief コンストラクタのアクセスレベル
    */
    private string[] m_constructor_access_levels;
    /**
    * @brief コンストラクタのアクセスレベルの添え字
    */
    private int m_constructor_access_levels_index;
    /**
    * @brief クラス名
    */
    private string m_class_name;
    /**
    * @brief 基底クラス名
    */
    private string m_base_name = "";
    /**
    * @brief 検索するライブラリ名
    */
    private string m_search_library = "";
    /**
    * @brief 検索する関数名
    */
    private string m_search_method = "";
    /**
    * @brief フィールドを必要とするかどうかの判定
    */
    private bool m_use_field = false;
    /**
    * @brief ライブラリのデータテーブル
    */
    private CSVTable m_library_table;
    /**
    * @brief 使用するライブラリ一覧
    */
    private Dictionary<string, bool> m_library_list;
    /**
    * @brief メソッドのデータテーブル
    */
    private CSVTable m_method_table;
    /**
    * @brief 使用するメソッド一覧
    */
    private Dictionary<string, bool> m_method_list;
    /**
    * @brief 全体のスクロール座標
    */
    private Vector2 m_all_scroll_position;
    /**
    * @brief ライブラリ一覧のスクロール座標
    */
    private Vector2 m_library_scroll_position;
    /**
    * @brief 関数一覧のスクロール座標
    */
    private Vector2 m_method_scroll_position;
    /*===============================================================*/
    #endregion

    /*===============================================================*/
    /**
    * @brief 初期化処理
    */
    // メニューから呼び出せるエディタの項目を追加.
    [MenuItem("CustomMenu/Script/CSharp Class Generation Editor")]
    static void Init ()
    {
        // 専用のウィンドウを表示.
        EditorWindow.GetWindow<CSharpClassGenerationEditor>(false, "CSharp Class Generation Editor");
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief ウィンドウ表示時に自動で呼ばれるメソッド
    */
    void OnEnable ()
    {
        // リストの初期化.
        m_library_list = new Dictionary<string, bool>();
        m_method_list = new Dictionary<string, bool>();
        // ローダーの生成.
        CSVLoader loader = new CSVLoader();
        // CSVを読み込み,CSVのデータテーブルを生成.
        m_library_table = loader.LoadCSV("CSV/LibraryList");
        m_method_table = loader.LoadCSV("CSV/CSharpMethodList");
        // データテーブル作成.
        foreach (CSVRecord record in m_library_table.Records)
        {
            bool isUse;
            Boolean.TryParse(record.GetField("isUse"), out isUse);
            m_library_list.Add(record.GetField("Library"), isUse);
        }
        foreach (CSVRecord record in m_method_table.Records)
        {
            bool isUse;
            Boolean.TryParse(record.GetField("isUse"), out isUse);
            m_method_list.Add(record.GetField("Method"), isUse);
        }
        m_class_access_levels = new string[4]{
            "public", 
            "private",
            "internal",
            "protected",
        };
        m_constructor_access_levels = new string[3]{
            "public", 
            "private",
            "protected",
        };
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief 選択内容の変更時に自動で呼ばれるメソッド
    */
    void OnSelectionChange ()
    {
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief ライブラリ一覧を表示するメソッド
    */
    void LibraryView ()
    {
        // スクロールビューの表示を開始.
        m_library_scroll_position = EditorGUILayout.BeginScrollView(m_library_scroll_position, GUILayout.Height(100));
        // ライブラリ一覧を表示.
        foreach (CSVRecord record in m_library_table.Records)
        {
            string key = record.GetField("Library");
            // 入力された文字が含まれている関数のみを表示.
            if (key.Contains(m_search_library))
            {
                m_library_list[key] = EditorGUILayout.Toggle(key, m_library_list[key]);
            }
        }
        // スクロールビューの表示を終了.
        EditorGUILayout.EndScrollView();
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief CSharpでよく使用する関数一覧を表示するメソッド
    */
    void CSharpMethodView ()
    {
        // スクロールビューの表示を開始.
        m_method_scroll_position = EditorGUILayout.BeginScrollView(m_method_scroll_position, GUILayout.Height(100));
        // 関数一覧を表示.
        foreach (CSVRecord record in m_method_table.Records)
        {
            string key = record.GetField("Method");
            // 入力された文字が含まれている関数のみを表示.
            if (key.Contains(m_search_method))
            {
                m_method_list[key] = EditorGUILayout.Toggle(key, m_method_list[key]);
            }
        }
        // スクロールビューの表示を終了.
        EditorGUILayout.EndScrollView();
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief コード生成処理
    * @param bool 生成するかどうかの判定
    */
    private void GenerateCode (bool t_generate)
    {
        if (t_generate && m_class_name != "")
        {
            // 高速に文字列を処理するStringBuilderのインスタンスを生成.
            StringBuilder builder = new System.Text.StringBuilder();
            // コマンド管理クラスの生成.
            CommandManager commandManager = new CommandManager();
            // ライブラリコマンド生成クラスの生成.
            CommandFactory libraryCommandFactory = new LibraryCommandFactory();
            // 関数コマンド生成クラスの生成.
            CommandFactory methodCommandFactory = new CSharpCommandFactory();
            // ライブラリのコマンド.
            foreach (KeyValuePair<string, bool> library in m_library_list)
            {
                if (library.Value)
                {
                    Command command = libraryCommandFactory.GetCommand(library.Key);
                    command.SetBuilder(builder);
                    commandManager.AddCommand(command);
                }
            }
            // 開始時のコマンド.
            CommonCommand beginCommand = new WriteBeginCommand();
            beginCommand.SetBeginInfo(m_summary, m_author);
            beginCommand.SetBuilder(builder);
            commandManager.AddCommand(beginCommand);
            // クラス開始時のコマンド.
            CommonCommand classCommand = new WriteClassCommand();
            classCommand.SetClassInfo(m_class_access_levels[m_class_access_levels_index], m_class_name, m_base_name);
            classCommand.SetBuilder(builder);
            commandManager.AddCommand(classCommand);
            // フィールドのコマンド.
            if (m_use_field)
            {
                Command fieldCommand = new WriteFieldCommand();
                fieldCommand.SetBuilder(builder);
                commandManager.AddCommand(fieldCommand);
            }
            // 関数のコマンド.
            foreach (KeyValuePair<string, bool> method in m_method_list)
            {
                if (method.Value)
                {
                    Command command;
                    if (method.Key.Contains("Constructor"))
                    {
                        command = methodCommandFactory.GetCommand(method.Key);
                        CSharpCommand constructor = command as CSharpCommand;
                        constructor.SetConstructorInfo(m_constructor_access_levels[m_constructor_access_levels_index], m_class_name, m_base_name != "" ? true : false);
                        command = constructor as Command;
                    }
                    else
                    {
                        command = methodCommandFactory.GetCommand(method.Key);
                    }
                    command.SetBuilder(builder);
                    commandManager.AddCommand(command);
                }
            }
            // 終了時のコマンド.
            Command endCommand = new WriteEndCommand();
            endCommand.SetBuilder(builder);
            commandManager.AddCommand(endCommand);
            // まとめて書き込み.
            commandManager.Execution();
            // 新しいファイルを作成して文字列を書き込み.
            System.IO.File.WriteAllText(m_path + m_class_name + ".cs", builder.ToString(), System.Text.Encoding.UTF8);
            // AssetDatabaseをリフレッシュ.
            AssetDatabase.Refresh(ImportAssetOptions.ImportRecursive);
        }
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief CSharpのClassの設定をする処理
    * @param bool 設定をするかどうかの判定
    */
    private void SettingCSharpClass (bool t_setting)
    {
        if (t_setting)
        {
            m_path = "Assets/";
            m_summary = "Default";
            m_author = "UserName";
            m_class_access_levels_index = 0;
            m_constructor_access_levels_index = 0;
            m_class_name = "Example";
            m_base_name = "";
            m_use_field = false;
            m_search_method = "";
            m_search_library = "";
            foreach (CSVRecord record in m_library_table.Records)
            {
                string key = record.GetField("Library");
                m_library_list[key] = false;
            }
            foreach (CSVRecord record in m_method_table.Records)
            {
                string key = record.GetField("Method");
                m_method_list[key] = false;
            }
            m_library_list["UnityEngine"] = true;
            m_library_list["System.Collections"] = true;
            m_method_list["Constructor"] = true;
            m_method_list["Initialize"] = true;
            m_method_list["Execution"] = true;
        }
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief 表示されている全ての関数のトグルにをチェックインする処理
    * @param bool チェックインするかどうかの判定
    */
    private void AllViewMethodCheckIn (bool t_check_in)
    {
        if (t_check_in)
        {
            foreach (CSVRecord record in m_library_table.Records)
            {
                string key = record.GetField("Library");
                // 入力された文字が含まれている関数のみを表示.
                if (key.Contains(m_search_library))
                {
                    m_library_list[key] = true;
                }
            }
            foreach (CSVRecord record in m_method_table.Records)
            {
                string key = record.GetField("Method");
                // 入力された文字が含まれている関数のみを表示.
                if (key.Contains(m_search_method))
                {
                    m_method_list[key] = true;
                }
            }
        }
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief 表示されている全ての関数のトグルにをチェックアウトする処理
    * @param bool チェックアウトするかどうかの判定
    */
    private void AllViewMethodCheckOut (bool t_check_out)
    {
        if (t_check_out)
        {
            foreach (CSVRecord record in m_library_table.Records)
            {
                string key = record.GetField("Library");
                // 入力された文字が含まれているライブラリのみを非表示.
                if (key.Contains(m_search_library))
                {
                    m_library_list[key] = false;
                }
            }
            foreach (CSVRecord record in m_method_table.Records)
            {
                string key = record.GetField("Method");
                // 入力された文字が含まれている関数のみを非表示.
                if (key.Contains(m_search_method))
                {
                    m_method_list[key] = false;
                }
            }
        }
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief GUI表示処理
    */
    void OnGUI ()
    {
        try
        {
            // 全体のスクロールビューの表示を開始.
            m_all_scroll_position = EditorGUILayout.BeginScrollView(m_all_scroll_position);
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // Labelの表示.
            GUILayout.Label("CSharp Class Generation Editor", EditorStyles.boldLabel);
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // コードを吐き出して置くパスを入力するテキストフィールド.
            m_path = EditorGUILayout.TextField("Output Path", m_path);
            // 概要を入力するテキストフィールド.
            m_summary = EditorGUILayout.TextField("Summary", m_summary);
            // 作成者名を入力するテキストフィールド.
            m_author = EditorGUILayout.TextField("Author Name", m_author);
            // クラスのアクセスレベルを選択するポップアップフィールド.
            m_class_access_levels_index = EditorGUILayout.Popup("Class Access Level", m_class_access_levels_index, m_class_access_levels);
            // コンストラクタのアクセスレベルを選択するポップアップフィールド.
            m_constructor_access_levels_index = EditorGUILayout.Popup("Constructor Access Level", m_constructor_access_levels_index, m_constructor_access_levels);
            // クラス名を入力するテキストフィールド.
            m_class_name = EditorGUILayout.TextField("Class Name", m_class_name);
            // 基底クラス名を入力するテキストフィールド.
            m_base_name = EditorGUILayout.TextField("Base Class Name", m_base_name);
            // フィールドを必要とするかのトグル.
            m_use_field = EditorGUILayout.Toggle("Use Field", m_use_field);
            // 検索すライブラリ名を入力するテキストフィールド.
            m_search_library = EditorGUILayout.TextField("Search Library", m_search_library);
            // Labelの表示.
            GUILayout.Label("Library List", EditorStyles.boldLabel);
            // ライブラリを表示.
            LibraryView();
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // 検索する関数名を入力するテキストフィールド.
            m_search_method = EditorGUILayout.TextField("Search Method", m_search_method);
            // Labelの表示.
            GUILayout.Label("CSharp Method List", EditorStyles.boldLabel);
            // 関数を表示.
            CSharpMethodView();
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // 水平に配置するGUIグループの作成を開始.
            EditorGUILayout.BeginHorizontal();
            // レイアウトグループ内に全体の幅に対して均一となるスペースを生成し挿入する.
            GUILayout.FlexibleSpace();
            // 垂直に配置するGUIグループの作成を開始.
            EditorGUILayout.BeginVertical();
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // チェックインの設定.
            if (GUILayout.Button("All View Method Check In", GUILayout.Width(200), GUILayout.Height(50)))
            {
                // ポップアップウィンドウの作成.
                PopupWindow pop = EditorWindow.GetWindow<PopupWindow>(true, "Do you check in all method ?");
                // 処理の代入.
                pop.callBack = AllViewMethodCheckIn;
                // テキストの代入.
                pop.Text = "Do you check in all method ?";
            }
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // チェックアウトの設定.
            if (GUILayout.Button("All View Method Check Out", GUILayout.Width(200), GUILayout.Height(50)))
            {
                // ポップアップウィンドウの作成.
                PopupWindow pop = EditorWindow.GetWindow<PopupWindow>(true, "Do you check out all method ?");
                // 処理の代入.
                pop.callBack = AllViewMethodCheckOut;
                // テキストの代入.
                pop.Text = "Do you check out all method ?";
            }
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // デフォルトの設定.
            if (GUILayout.Button("Setting CSharp Class", GUILayout.Width(200), GUILayout.Height(50)))
            {
                // ポップアップウィンドウの作成.
                PopupWindow pop = EditorWindow.GetWindow<PopupWindow>(true, "Do you set csharp class parameter ?");
                // 処理の代入.
                pop.callBack = SettingCSharpClass;
                // テキストの代入.
                pop.Text = "Do you set csharp class parameter ?";
            }
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // コード生成.
            if (GUILayout.Button("Code Generation", GUILayout.Width(200), GUILayout.Height(50)))
            {
                // ポップアップウィンドウの作成.
                PopupWindow pop = EditorWindow.GetWindow<PopupWindow>(true, "Do you generate code ?");
                // 処理の代入.
                pop.callBack = GenerateCode;
                // テキストの代入.
                pop.Text = "Do you generate code ?";
            }
            // 垂直に配置するGUIグループの作成を終了.
            EditorGUILayout.EndVertical();
            // レイアウトグループ内に全体の幅に対して均一となるスペースを生成し挿入する.
            GUILayout.FlexibleSpace();
            // 水平に配置するGUIグループの作成を終了.
            EditorGUILayout.EndHorizontal();
            // スクロールビューの表示を終了.
            EditorGUILayout.EndScrollView();
        }
        catch (System.FormatException)
        {
        }
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief インスペクタ更新処理
    */
    void OnInspectorUpdate ()
    {
        Repaint();
    }
    /*===============================================================*/
}
/*===============================================================*/

