using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnAnimatorIK関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnAnimatorIKCommand : Command
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
        m_builder.AppendLine("    * @brief アニメーションIK(インバースキネマティクス)をセットアップするときのコールバックメソッド");
        m_builder.AppendLine("    * @param int IKソルバーが呼び出しされたレイヤーのインデックス.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnAnimatorIK (int layerIndex)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
