using UnityEngine;
using System.Collections;
using System.Text;
/*===============================================================*/
/**
* 共通した記述を書き込むコマンドの親クラス
* 2015年2月4日 Buravo
*/
public abstract class CommonCommand : Command
{
    #region メンバ変数
    /*===============================================================*/
    /**
    * @brief 概要
    */
    protected string m_summary;
    /**
    * @brief 作成者
    */
    protected string m_author;
    /**
    * @brief クラスのアクセスレベル
    */
    protected string m_class_access_level;
    /**
    * @brief クラス名
    */
    protected string m_class_name;
    /**
    * @brief 基底クラス名
    */
    protected string m_base_name;
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
    * @brief 開始時の情報を設定する処理.
    * @param string 概要.
    * @param string 作成者名.
    * @return void.
    */
    public void SetBeginInfo (string t_summary, string t_author)
    {
        m_summary = t_summary;
        m_author = t_author;
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief クラスの情報を設定する処理.
    * @param string クラスのアクセスレベル.
    * @param string クラス名.
    * @param string 基底クラス名.
    * @return void.
    */
    public void SetClassInfo (string t_class_access_level, string t_class_name, string t_base_name)
    {
        m_class_access_level = t_class_access_level;
        m_class_name = t_class_name;
        m_base_name = t_base_name;
    }
    /*===============================================================*/

}
/*===============================================================*/
