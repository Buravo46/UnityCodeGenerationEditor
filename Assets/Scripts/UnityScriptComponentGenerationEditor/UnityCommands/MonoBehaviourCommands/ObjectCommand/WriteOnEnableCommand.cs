using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnEnable関数を書き込むコマンド
* 2015年2月3日 Buravo
*/
public class WriteOnEnableCommand : Command
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
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("    /**");
        m_builder.AppendLine("    * @brief オブジェクトが有効化されたときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param void.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnEnable ()");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

