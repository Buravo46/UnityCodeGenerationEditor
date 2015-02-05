using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnTriggerStay関数を書き込むコマンド
* 2015年2月1日 Buravo
*/
public class WriteOnTriggerStayCommand : Command
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
        m_builder.AppendLine("    * @brief トリガーオブジェクトに他のコライダーオブジェクトが留まっているときに毎フレーム呼び出されるメソッド.");
        m_builder.AppendLine("    * @param Collider オブジェクトの情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnTriggerStay (Collider collider)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

