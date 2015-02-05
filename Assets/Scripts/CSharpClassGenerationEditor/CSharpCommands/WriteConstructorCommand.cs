using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* コンストラクタを書き込むコマンド
* 2015年2月3日 Buravo
*/
public class WriteConstructorCommand : CSharpCommand
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
        m_builder.AppendLine("    * @brief コンストラクタ");
        m_builder.AppendLine("    * @param void.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        if (m_has_base_class)
        {
            m_builder.AppendLine("    " + m_constructor_access_level + " " + m_class_name + " () : base ()");
        }
        else
        {
            m_builder.AppendLine("    " + m_constructor_access_level + " " + m_class_name + " ()");
        }
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
