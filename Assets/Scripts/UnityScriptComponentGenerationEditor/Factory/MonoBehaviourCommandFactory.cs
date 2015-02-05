using UnityEngine;
using System.Collections;
/*===============================================================*/
/**
* MonoBehaviourのコマンドを生成するファクトリークラス
* 2015年2月4日 Buravo
*/
public class MonoBehaviourCommandFactory : CommandFactory
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
            case "Awake":
                return new WriteAwakeCommand();
            case "FixedUpdate":
                return new WriteFixedUpdateCommand();
            case "LateUpdate":
                return new WriteLateUpdateCommand();
            case "OnAnimatorIK":
                return new WriteOnAnimatorIKCommand();
            case "OnAnimatorMove":
                return new WriteOnAnimatorMoveCommand();
            case "OnApplicationFocus":
                return new WriteOnApplicationFocusCommand();
            case "OnApplicationPause":
                return new WriteOnApplicationPauseCommand();
            case "OnApplicationQuit":
                return new WriteOnApplicationQuitCommand();
            case "OnAudioFilterRead":
                return new WriteOnAudioFilterReadCommand();
            case "OnBecameInvisible":
                return new WriteOnBecameInvisibleCommand();
            case "OnBecameVisible":
                return new WriteOnBecameVisibleCommand();
            case "OnCollisionEnter":
                return new WriteOnCollisionEnterCommand();
            case "OnCollisionEnter2D":
                return new WriteOnCollisionEnter2DCommand();
            case "OnCollisionExit":
                return new WriteOnCollisionExitCommand();
            case "OnCollisionExit2D":
                return new WriteOnCollisionExit2DCommand();
            case "OnCollisionStay":
                return new WriteOnCollisionStayCommand();
            case "OnCollisionStay2D":
                return new WriteOnCollisionStay2DCommand();
            case "OnConnectedToServer":
                return new WriteOnConnectedToServerCommand();
            case "OnControllerColliderHit":
                return new WriteOnControllerColliderHitCommand();
            case "OnDestroy":
                return new WriteOnDestroyCommand();
            case "OnDisable":
                return new WriteOnDisableCommand();
            case "OnDisconnectedFromServer":
                return new WriteOnDisconnectedFromServerCommand();
            case "OnDrawGizmos":
                return new WriteOnDrawGizmosCommand();
            case "OnDrawGizmosSelected":
                return new WriteOnDrawGizmosSelectedCommand();
            case "OnEnable":
                return new WriteOnEnableCommand();
            case "OnFailedToConnect":
                return new WriteOnFailedToConnectCommand();
            case "OnFailedToConnectToMasterServer":
                return new WriteOnFailedToConnectToMasterServerCommand();
            case "OnGUI":
                return new WriteOnGUICommand();
            case "OnJointBreak":
                return new WriteOnJointBreakCommand();
            case "OnLevelWasLoaded":
                return new WriteOnLevelWasLoadedCommand();
            case "OnMasterServerEvent":
                return new WriteOnMasterServerEventCommand();
            case "OnMouseDown":
                return new WriteOnMouseDownCommand();
            case "OnMouseDrag":
                return new WriteOnMouseDragCommand();
            case "OnMouseEnter":
                return new WriteOnMouseEnterCommand();
            case "OnMouseExit":
                return new WriteOnMouseExitCommand();
            case "OnMouseOver":
                return new WriteOnMouseOverCommand();
            case "OnMouseUp":
                return new WriteOnMouseUpCommand();
            case "OnMouseUpAsButton":
                return new WriteOnMouseUpAsButtonCommand();
            case "OnNetworkInstantiate":
                return new WriteOnNetworkInstantiateCommand();
            case "OnParticleCollision":
                return new WriteOnParticleCollisionCommand();
            case "OnPlayerConnected":
                return new WriteOnPlayerConnectedCommand();
            case "OnPlayerDisconnected":
                return new WriteOnPlayerDisconnectedCommand();
            case "OnPostRender":
                return new WriteOnPostRenderCommand();
            case "OnPreCull":
                return new WriteOnPreCullCommand();
            case "OnPreRender":
                return new WriteOnPreRenderCommand();
            case "OnRenderImage":
                return new WriteOnRenderImageCommand();
            case "OnRenderObject":
                return new WriteOnRenderObjectCommand();
            case "OnSerializeNetworkView":
                return new WriteOnSerializeNetworkViewCommand();
            case "OnServerInitialized":
                return new WriteOnServerInitializedCommand();
            case "OnTransformChildrenChanged":
                return new WriteOnTransformChildrenChangedCommand();
            case "OnTransformParentChanged":
                return new WriteOnTransformParentChangedCommand();
            case "OnTriggerEnter":
                return new WriteOnTriggerEnterCommand();
            case "OnTriggerEnter2D":
                return new WriteOnTriggerEnter2DCommand();
            case "OnTriggerExit":
                return new WriteOnTriggerExitCommand();
            case "OnTriggerExit2D":
                return new WriteOnTriggerExit2DCommand();
            case "OnTriggerStay":
                return new WriteOnTriggerStayCommand();
            case "OnTriggerStay2D":
                return new WriteOnTriggerStay2DCommand();
            case "OnValidate":
                return new WriteOnValidateCommand();
            case "OnWillRenderObject":
                return new WriteOnWillRenderObjectCommand();
            case "Reset":
                return new WriteResetCommand();
            case "Start":
                return new WriteStartCommand();
            case "Update":
                return new WriteUpdateCommand();
        }
        return null;
    }
    /*===============================================================*/
}
/*===============================================================*/
