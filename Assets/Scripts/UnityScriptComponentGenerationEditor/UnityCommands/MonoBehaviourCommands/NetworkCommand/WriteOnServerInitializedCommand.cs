using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnServerInitialized関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnServerInitializedCommand : Command
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
        m_builder.AppendLine("    * @brief Network.InitializeServer関数が呼び出され完了したときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param void.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnServerInitialized ()");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
