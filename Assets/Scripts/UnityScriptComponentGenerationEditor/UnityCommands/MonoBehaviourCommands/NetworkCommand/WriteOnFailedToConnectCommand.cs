using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnFailedToConnect関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnFailedToConnectCommand : Command
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
        m_builder.AppendLine("    * @brief 何らかの理由で接続が失敗した場合に、クライアントで呼び出されるメソッド");
        m_builder.AppendLine("    * @param NetworkConnectionError ネットワークに接続する際に返ってくるエラー内容.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnFailedToConnect (NetworkConnectionError error)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
