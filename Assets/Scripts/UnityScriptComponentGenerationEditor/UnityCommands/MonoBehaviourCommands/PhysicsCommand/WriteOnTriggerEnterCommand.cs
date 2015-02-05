using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnTriggerEnter関数を書き込むコマンド
* 2015年2月1日 Buravo
*/
public class WriteOnTriggerEnterCommand : Command
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
        m_builder.AppendLine("    * @brief トリガーオブジェクトに他のコライダーオブジェクトが入ったときに呼び出されるメソッド.");
        m_builder.AppendLine("    * @param Collider オブジェクトの情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnTriggerEnter (Collider collider)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

