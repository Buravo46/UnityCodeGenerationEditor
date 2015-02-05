using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnMasterServerEvent関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnMasterServerEventCommand : Command
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
        m_builder.AppendLine("    * @brief マスターサーバーからのイベントを受け取ったときに、クライアントやサーバーで呼び出されるメソッド");
        m_builder.AppendLine("    * @param MasterServerEvent マスターサーバーからのステータスメッセージ.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnMasterServerEvent (MasterServerEvent event)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
