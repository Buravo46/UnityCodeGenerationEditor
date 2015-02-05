using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* UnityEngineライブラリを書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteUnityEngineCommand : Command
{

    /*===============================================================*/
    /**
    * @brief 実行処理
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        m_builder.AppendLine("using UnityEngine;");
    }
    /*===============================================================*/

}
/*===============================================================*/
