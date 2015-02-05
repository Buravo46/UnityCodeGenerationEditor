using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnNetworkInstantiate関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnNetworkInstantiateCommand : Command
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
        m_builder.AppendLine("    * @brief ネットワーク上でNetwork.Instantiate関数を用いてインスタンス化されたオブジェクトに対して呼び出されるメソッド");
        m_builder.AppendLine("    * @param NetworkMessageInfo ネットワークから受信したメッセージに関する情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnNetworkInstantiate (NetworkMessageInfo info)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
