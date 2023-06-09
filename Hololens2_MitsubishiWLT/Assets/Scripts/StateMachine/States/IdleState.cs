using UnityEngine;

namespace MitsubishiAR.StateMachine
{
    public class IdleState : State
    {
        public IdleState(SceneContent sceneContent, StateMachine stateMachine) : base(sceneContent, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            sceneContent.UpdateSceneAnimator(sceneContent.SceneContentAnimator);
            sceneContent.MainMenu.MenuState(true);
            sceneContent.HandMenu.MenuState(true);
            sceneContent.HandMenu.MainMenuMode();
        }

        public override void LogicUpdate()
        {
            if (sceneContent.AdminMenu.gameObject.activeSelf == true)
            {
                stateMachine.ChangeState(sceneContent.Admin);
                Debug.Log("State changed to Admin");
            }
        }

        public override void LateEnter()
        {
            base.LateEnter();
            sceneContent.AdminMenu.SwitchBoundsState();
        }

        public override void Exit()
        {
            base.Exit();
            sceneContent.MainMenu.MenuState(false);
            sceneContent.HandMenu.OutOfMainMenuMode();
        }
    }

}
