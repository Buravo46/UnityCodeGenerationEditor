using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* コマンドを生成するファクトリークラスの基底クラス
* 2015年2月4日 Buravo
*/
public abstract class CommandFactory
{

    /*===============================================================*/
    /**
    * @brief コマンドを生成する処理
    * @param string コマンド名.
    * @return Command 生成したコマンド.
    */
    public abstract Command GetCommand (string t_command_name);
    /*===============================================================*/

}
/*===============================================================*/
