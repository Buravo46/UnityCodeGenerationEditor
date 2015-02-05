using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnLevelWasLoaded関数を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteOnLevelWasLoadedCommand : Command
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
        m_builder.AppendLine("    * @brief 新しいレベル(シーン)がロードされたときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param int SceneのIndex.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnLevelWasLoaded (int level)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

