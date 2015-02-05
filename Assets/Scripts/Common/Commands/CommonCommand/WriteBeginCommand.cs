using UnityEngine;
using System.Collections;
using System;
/*===============================================================*/
/**
* 開始時の記述を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteBeginCommand : CommonCommand
{

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        // カルチャの設定.
        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");
        m_builder.AppendLine("");
        m_builder.AppendLine("/*===============================================================*/");
        m_builder.AppendLine("/**");
        m_builder.AppendLine("* " + m_summary);
        m_builder.AppendLine("* " + System.DateTime.Now.ToString("D", ci) + " " + m_author);
        m_builder.AppendLine("*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
