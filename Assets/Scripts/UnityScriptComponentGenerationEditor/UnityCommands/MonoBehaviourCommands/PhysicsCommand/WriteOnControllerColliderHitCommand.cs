using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnControllerColliderHit関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnControllerColliderHitCommand : Command
{

    /*===============================================================*/
    /**
    * @brief 実行処理
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        m_builder.AppendLine("");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("    /**");
        m_builder.AppendLine("    * @brief 移動中にコントローラーがColliderオブジェクトに衝突したときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param ControllerColliderHit 衝突の詳細情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnControllerColliderHit (ControllerColliderHit hit)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
