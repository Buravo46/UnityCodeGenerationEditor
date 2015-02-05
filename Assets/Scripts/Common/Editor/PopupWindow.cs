using UnityEngine;
using UnityEditor;
using System.Collections;
/*===============================================================*/
/**
* ポップアップウィンドウ
* 2014年12月25日 Buravo
*/ 
public class PopupWindow : EditorWindow 
{
    #region パブリック変数
    /*===============================================================*/
    /**
    * @brief YES用の処理を使うためのデリゲート宣言
    */
    public delegate void Callback(bool t_check);
    /**
    * @brief YES用の処理を使うためのデリゲート変数
    */
    public Callback callBack;
    /*===============================================================*/
    #endregion

    #region メンバ変数
    /*===============================================================*/
    /**
    * @brief 表示するテキスト
    */
    private string m_text = "";
    /**
    * @brief 表示するテキストのスタイル
    */
    private GUIStyle m_text_style;
    /*===============================================================*/
    #endregion

    #region アクセサ
    /*===============================================================*/
    /**
    * @brief 表示するテキスト
    */
    public string Text
    {
        set
        {
            m_text = value;
        }
        get
        {
            return m_text;
        }
    }
    /*===============================================================*/
    #endregion
 
    /*===============================================================*/
    /**
    * @brief 初期化処理
    */
    static void Init () 
    {
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief ウィンドウ表示時に自動で呼ばれるメソッド。
    */ 
    void OnEnable ()
    {
        m_text_style = new GUIStyle();
        m_text_style.alignment = TextAnchor.MiddleCenter;
        m_text_style.fontSize = 18;
        m_text_style.wordWrap = true;
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief 選択内容の変更時に自動で呼ばれるメソッド。
    */
    void OnSelectionChange () 
    {
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
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // テキストの表示.
            GUILayout.Label(m_text, m_text_style);
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            // 水平に配置するGUIグループを作成開始.
            EditorGUILayout.BeginHorizontal();
            // レイアウトグループ内に全体の幅に対して均一となるスペースを生成し挿入する.
            GUILayout.FlexibleSpace();
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            if (GUILayout.Button("Yes", GUILayout.Width(150), GUILayout.Height(50)))
            {
                callBack(true);
                this.Close();
            }
            // スペースで間隔をとる.
            EditorGUILayout.Space();
            if (GUILayout.Button("No", GUILayout.Width(150), GUILayout.Height(50)))
            {
                this.Close();
            }
            // レイアウトグループ内に全体の幅に対して均一となるスペースを生成し挿入する.
            GUILayout.FlexibleSpace();
            // 水平に配置するGUIグループを作成終了.
            EditorGUILayout.EndHorizontal();
            
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