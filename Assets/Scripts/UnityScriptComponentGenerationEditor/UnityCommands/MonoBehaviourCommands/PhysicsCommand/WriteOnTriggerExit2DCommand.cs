using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnTriggerExit2D関数を書き込むコマンド
* 2015年2月1日 Buravo
*/
public class WriteOnTriggerExit2DCommand : Command
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
        m_builder.AppendLine("    * @brief トリガーオブジェクトに他のコライダーオブジェクトが出たときに呼び出されるメソッド.(2D物理挙動のみ).");
        m_builder.AppendLine("    * @param Collider2D オブジェクトの情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnTriggerExit2D (Collider2D collider2D)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

