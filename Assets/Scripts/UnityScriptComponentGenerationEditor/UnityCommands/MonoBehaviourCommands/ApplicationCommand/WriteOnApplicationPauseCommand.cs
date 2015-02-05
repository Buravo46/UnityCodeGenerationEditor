using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnApplicationPause関数を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteOnApplicationPauseCommand : Command
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
        m_builder.AppendLine("    * @brief アプリケーションが一時停止したときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param bool 一時停止されているかの判定.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnApplicationPause (bool isPause)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/

