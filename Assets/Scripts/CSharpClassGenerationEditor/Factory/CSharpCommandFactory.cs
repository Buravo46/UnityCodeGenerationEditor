using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* CSharpのコマンドを生成するファクトリークラス
* 2015年2月5日 Buravo
*/
public class CSharpCommandFactory : CommandFactory
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
            case "Constructor":
                return new WriteConstructorCommand();
            case "Initialize":
                return new WriteInitializeCommand();
            case "Execution":
                return new WriteExecutionCommand();
        }
        return null;
    }
    /*===============================================================*/
}
/*===============================================================*/
