﻿namespace behaviac
{
    using Assets.Scripts.GameLogic;

    internal class Action_bt_WrapperAI_Hero_HeroWarmNormalAI_node471 : Action
    {
        protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
        {
            return ((ObjAgent) pAgent).IsLadder();
        }
    }
}

