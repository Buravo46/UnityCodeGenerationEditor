using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnFailedToConnectToMasterServer関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnFailedToConnectToMasterServerCommand : Command
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
        m_builder.AppendLine("    * @brief マスターサーバーへの接続に問題が発生したときに、クライアントやサーバーで呼び出されるメソッド");
        m_builder.AppendLine("    * @param NetworkConnectionError ネットワークに接続する際に返ってくるエラー内容.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnFailedToConnectToMasterServer (NetworkConnectionError info)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
