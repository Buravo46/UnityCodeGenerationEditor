using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnPlayerConnected関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnPlayerConnectedCommand : Command
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
        m_builder.AppendLine("    * @brief 新しいプレイヤーが接続されたときにサーバーで呼び出されるメソッド");
        m_builder.AppendLine("    * @param NetworkPlayer ネットワークでつながれたプレイヤー情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnPlayerConnected (NetworkPlayer player)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
