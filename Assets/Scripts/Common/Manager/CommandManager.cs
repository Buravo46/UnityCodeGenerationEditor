using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/*===============================================================*/
/**
* コマンドの管理クラス.
* 2015年2月1日 Buravo
*/
public class CommandManager : Command
{
    #region メンバ変数
    /*===============================================================*/
    /**
    * @brief コマンドリスト.
    */
    protected List<Command> m_commands = new List<Command>();
    /*===============================================================*/
    #endregion

    /*===============================================================*/
    /**
    * @brief 実行処理.
    * @param void.
    * @return void.
    */
    public override void Execution ()
    {
        foreach (Command command in m_commands)
        {
            command.Execution();
        }
    }
    /*===============================================================*/

    /*===============================================================*/
    /**
    * @brief コマンド追加処理.
    * @param Command コマンド.
    * @return void.
    */
    public void AddCommand (Command t_command)
    {
        m_commands.Add(t_command);
    }
    /*===============================================================*/

}
/*===============================================================*/
