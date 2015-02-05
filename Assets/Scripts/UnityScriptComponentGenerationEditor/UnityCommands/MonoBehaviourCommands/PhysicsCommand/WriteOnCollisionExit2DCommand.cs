using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnCollisionExit2D関数を書き込むコマンド
* 2015年2月1日 Buravo
*/
public class WriteOnCollisionExit2DCommand : Command
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
        m_builder.AppendLine("    * @brief colliderやrigidbodyオブジェクトが他のcolliderやrigidbodyオブジェクトに離れたときに呼び出されるメソッド.(2D物理挙動のみ).");
        m_builder.AppendLine("    * @param Collision2D 衝突したオブジェクトの情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnCollisionExit2D (Collision2D collision2D)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

