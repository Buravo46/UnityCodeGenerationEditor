using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnDisconnectedFromServer関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnDisconnectedFromServerCommand : Command
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
        m_builder.AppendLine("    * @brief クライアントがサーバーへの接続を失ったときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param NetworkDisconnection サーバーから切断されたときの内容.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnDisconnectedFromServer (NetworkDisconnection info)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
