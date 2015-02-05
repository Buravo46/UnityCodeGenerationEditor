using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* OnAudioFilterRead関数を書き込むコマンド
* 2015年2月5日 Buravo
*/
public class WriteOnAudioFilterReadCommand : Command
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
        m_builder.AppendLine("    * @brief DSPチェーンにカスタムフィルターを挿入する際に使用するメソッド");
        m_builder.AppendLine("    * @param float[] オーディオデータからなるfloatの配列.");
        m_builder.AppendLine("    * @param int このデリゲートに渡された音声データのチャネル数を格納する整数.");
        m_builder.AppendLine("    * @return void.");
        m_builder.AppendLine("    */");
        m_builder.AppendLine("    void OnAudioFilterRead (float[] data, int channels)");
        m_builder.AppendLine("    {");
        m_builder.AppendLine("    }");
        m_builder.AppendLine("    /*===============================================================*/");
        m_builder.AppendLine("");
    }
    /*===============================================================*/

}
/*===============================================================*/
