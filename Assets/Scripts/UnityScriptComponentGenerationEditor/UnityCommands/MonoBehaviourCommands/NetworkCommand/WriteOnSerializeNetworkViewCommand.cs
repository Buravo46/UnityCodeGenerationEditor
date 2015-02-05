using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnSerializeNetworkView関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnSerializeNetworkViewCommand : Command
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
        m_builder.AppendLine("    * @brief ネットワークビューによって使われる値の直列化をカスタマイズしたいときに使用するメソッド");
        m_builder.AppendLine("    * @param BitStream ストリームにパックされたシリアライズされた変数を表すクラス.");
        m_builder.AppendLine("    * @param NetworkMessageInfo ネットワークから受信したメッセージに関する情報.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnSerializeNetworkView (BitStream stream, NetworkMessageInfo info)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
