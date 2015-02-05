using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* フィールドを書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteFieldCommand : Command
{

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        m_builder.AppendLine("");
        m_builder.AppendLine("    #region フィールド");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("    /**");
        m_builder.AppendLine("    * @brief ");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("    #endregion");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
