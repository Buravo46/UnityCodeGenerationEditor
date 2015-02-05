using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnJointBreak関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnJointBreakCommand : Command
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
        m_builder.AppendLine("    * @brief ジョイントが破壊されたときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param float 関節に適用されるブレーク力.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnJointBreak (float breakForce)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
