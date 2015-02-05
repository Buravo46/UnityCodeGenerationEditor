using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnApplicationFocus関数を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteOnApplicationFocusCommand : Command
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
        m_builder.AppendLine("    * @brief アプリケーションがフォーカスされたときや外れたときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param bool フォーカスされているかの判定.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnApplicationFocus (bool isFocus)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
