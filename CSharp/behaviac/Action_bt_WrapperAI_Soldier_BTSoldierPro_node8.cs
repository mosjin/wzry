﻿namespace behaviac
{
    using Assets.Scripts.GameLogic;

    internal class Action_bt_WrapperAI_Soldier_BTSoldierPro_node8 : Action
    {
        protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
        {
            ((ObjAgent) pAgent).ClearTarget();
            return EBTStatus.BT_SUCCESS;
        }
    }
}
