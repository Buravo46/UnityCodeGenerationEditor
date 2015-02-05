using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnCollisionExit関数を書き込むコマンド
* 2015年2月1日 Buravo
*/
public class WriteOnCollisionExitCommand : Command
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
        m_builder.AppendLine("    * @brief colliderやrigidbodyオブジェクトが他のcolliderやrigidbodyオブジェクトに離れたときに呼び出されるメソッド.");
        m_builder.AppendLine("    * @param Collision 衝突したオブジェクトの情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnCollisionExit (Collision collision)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

