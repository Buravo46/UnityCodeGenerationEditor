using UnityEngine;
using System.Collections;
using System;
/*===============================================================*/
/**
* 終了時の記述を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteEndCommand : CommonCommand
{

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        m_builder.AppendLine("}");
        m_builder.AppendLine("/*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
