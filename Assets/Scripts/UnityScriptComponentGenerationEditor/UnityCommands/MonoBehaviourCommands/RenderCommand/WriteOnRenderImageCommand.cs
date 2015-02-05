using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnRenderImage関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnRenderImageCommand : Command
{

    /*===============================================================*/
    /**
    * @brief 実行処理
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        m_builder.AppendLine("");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("    /**");
        m_builder.AppendLine("    * @brief すべてのレンダーイメージのレンダリングが完了したときに呼び出されるメソッド");
        m_builder.AppendLine("    * @param RenderTexture 元レンダリングテクスチャ.");
        m_builder.AppendLine("    * @param RenderTexture 目的レンダリングテクスチャ.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnRenderImage (RenderTexture source, RenderTexture destination)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
