using UnityEngine;
using System.Collections;
using System.Text;
/*===============================================================*/
/**
* CSharp用の書き込むコマンドの親クラス
* 2015年2月3日 Buravo
*/
public abstract class CSharpCommand : Command
{
    #region メンバ変数
    /*===============================================================*/
    /**
    * @brief コンストラクタのアクセスレベル
    */
    protected string m_constructor_access_level;
    /**
    * @brief クラス名
    */
    protected string m_class_name;
    /**
    * @brief 基底クラスが存在するかどうかの判定
    */
    protected bool m_has_base_class;
    /*===============================================================*/
    #endregion

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief コンストラクタの情報を設定する処理.
    * @param string コンストラクタのアクセスレベル.
    * @param string クラス名.
    * @param bool 基底クラスが存在するかどうかの判定.
    * @return void.
    */
    public void SetConstructorInfo (string t_constructor_access_level, string t_class_name, bool t_has_base_class)
    {
        m_constructor_access_level = t_constructor_access_level;
        m_class_name = t_class_name;
        m_has_base_class = t_has_base_class;
    }
    /*===============================================================*/

}
/*===============================================================*/
