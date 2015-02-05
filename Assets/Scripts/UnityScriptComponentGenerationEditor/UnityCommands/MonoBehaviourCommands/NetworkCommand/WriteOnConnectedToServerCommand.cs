using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnConnectedToServer関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnConnectedToServerCommand : Command
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
        m_builder.AppendLine("    * @brief クライアントがサーバーに接続完了したときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param void.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnConnectedToServer ()");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
