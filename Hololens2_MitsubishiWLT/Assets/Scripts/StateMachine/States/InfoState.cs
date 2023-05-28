using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MitsubishiAR.Components.Object.States.ShowObjectsComponent;
using static MitsubishiAR.Components.Object.States.HideObjectsComponent;

namespace MitsubishiAR.StateMachine
{
    public class InfoState : State
    {
        public InfoState(SceneContent sceneContent, StateMachine stateMachine) : base(sceneContent, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            ShowObjects(sceneContent.Tips);
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();            
        }

        public override void Exit()
        {
            base.Exit();
            HideObjects(sceneContent.Tips);
        }
    }

}
