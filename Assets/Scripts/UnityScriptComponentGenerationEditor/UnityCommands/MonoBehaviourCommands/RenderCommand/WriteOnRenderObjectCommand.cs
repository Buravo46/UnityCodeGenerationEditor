using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnRenderObject関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnRenderObjectCommand : Command
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
        m_builder.AppendLine("    * @brief オブジェクトが可視状態のとき、カメラごとに一度呼び出されるメソッド");
        m_builder.AppendLine("    * @param void.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnRenderObject ()");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
