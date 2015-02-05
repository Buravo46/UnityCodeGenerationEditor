using UnityEngine;
using System.Collections;
using System.Text;
/*===============================================================*/
/**
* 書き込むコマンドの親クラス
* 2015年2月1日 Buravo
*/
public abstract class Command
{
    #region メンバ変数
    /*===============================================================*/
    /**
    * @brief StringBuilder
    */
    protected StringBuilder m_builder;
    /*===============================================================*/
    #endregion

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public abstract void Execution ();
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief ビルダーの設定処理.
    * @param StringBuilder ビルダー.
    * @return void.
    */
    public void SetBuilder (StringBuilder t_builder)
    {
        m_builder = t_builder;
    }
    /*===============================================================*/

}
/*===============================================================*/
