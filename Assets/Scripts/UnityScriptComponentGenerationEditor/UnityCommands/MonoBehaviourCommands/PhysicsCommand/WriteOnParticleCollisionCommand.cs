using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnParticleCollision関数を書き込むコマンド
* 2015年2月3日 Buravo
*/
public class WriteOnParticleCollisionCommand : Command
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
        m_builder.AppendLine("    * @brief パーティクルがcolliderオブジェクトに衝突したときに呼び出されるメソッド.");
        m_builder.AppendLine("    * @param GameObject 衝突したオブジェクト.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnParticleCollision (GameObject obj)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/


