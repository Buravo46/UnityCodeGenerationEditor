using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* ライブラリのコマンドを生成するファクトリークラス
* 2015年2月5日 Buravo
*/
public class LibraryCommandFactory : CommandFactory
{

    /*===============================================================*/
    /**
    * @brief コマンドを生成して取得する処理
    * @param string コマンド名.
    * @return Command 生成したコマンド.
    */
    public override Command GetCommand (string t_command_name)
    {
        switch (t_command_name)
        {
            case "UnityEngine":
                return new WriteUnityEngineCommand();
            case "UnityEditor":
                return new WriteUnityEditorCommand();
            case "System":
                return new WriteSystemCommand();
            case "System.Collections":
                return new WriteSystemCollectionsCommand();
            case "System.Collections.Generic":
                return new WriteSystemCollectionsGenericCommand();
            case "System.Data":
                return new WriteSystemDataCommand();
            case "System.IO":
                return new WriteSystemIOCommand();
            case "System.Linq":
                return new WriteSystemLinqCommand();
            case "System.Net":
                return new WriteSystemNetCommand();
            case "System.Resources":
                return new WriteSystemResourcesCommand();
            case "System.Text":
                return new WriteSystemTextCommand();
            case "System.Xaml":
                return new WriteSystemXamlCommand();
            case "System.Xml":
                return new WriteSystemXmlCommand();
        }
        return null;
    }
    /*===============================================================*/

}
/*===============================================================*/
