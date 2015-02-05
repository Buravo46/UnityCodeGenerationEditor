using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* クラスの開始時を書き込むコマンド
* 2015年2月4日 Buravo
*/
public class WriteClassCommand : CommonCommand
{

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        // 基底クラスが存在するかどうか.
        if (m_base_name != null && m_base_name != "")
        {
            m_builder.AppendLine(m_class_access_level + " class " + m_class_name + " : " + m_base_name);
        }
        else
        {
            m_builder.AppendLine(m_class_access_level + " class " + m_class_name);
        }
        m_builder.AppendLine("{");
    }
    /*===============================================================*/

}
/*===============================================================*/
