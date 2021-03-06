﻿using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnPlayerDisconnected関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnPlayerDisconnectedCommand : Command
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
        m_builder.AppendLine("    * @brief サーバーからプレイヤーが切断されたときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param NetworkPlayer ネットワークでつながれたプレイヤー情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnPlayerDisconnected (NetworkPlayer player)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
