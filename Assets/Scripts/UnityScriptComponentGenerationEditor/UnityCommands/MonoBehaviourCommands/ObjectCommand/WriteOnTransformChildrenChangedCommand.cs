using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnTransformChildrenChanged関数を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteOnTransformChildrenChangedCommand : Command
{

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        m_builder.AppendLine("");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("    /**");
        m_builder.AppendLine("    * @brief 子供オブジェクトとの親子関係が変更されるタイミングで呼び出されるメソッド");
        m_builder.AppendLine("    * @param void.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnTransformChildrenChanged ()");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

