﻿namespace CSProtocol
{
    using System;

    public enum COM_TRANSACTION_CONTEXT_TYPE
    {
        COM_TRANSACTION_CONTEXT_ADD_ARENAFIGHT_HISTORY = 14,
        COM_TRANSACTION_CONTEXT_ADD_FIGHTHISTORY = 0x16,
        COM_TRANSACTION_CONTEXT_ADD_RANKCURSEASONDATA = 0x11,
        COM_TRANSACTION_CONTEXT_ADD_RANKPASTSEASONDATA = 0x12,
        COM_TRANSACTION_CONTEXT_APPOINT_POSITION = 12,
        COM_TRANSACTION_CONTEXT_APPROVE_JOIN_GUILD = 4,
        COM_TRANSACTION_CONTEXT_CHANGE_GUILD_NAME = 0x15,
        COM_TRANSACTION_CONTEXT_CHANGE_PLAYER_NAME = 20,
        COM_TRANSACTION_CONTEXT_DEAL_GUILD_INVITE = 8,
        COM_TRANSACTION_CONTEXT_DELETEBURNINGENEMY = 15,
        COM_TRANSACTION_CONTEXT_FIRE_MEMBER = 13,
        COM_TRANSACTION_CONTEXT_GETARENA_TARGETDATA = 11,
        COM_TRANSACTION_CONTEXT_GUILD_GETNAME = 10,
        COM_TRANSACTION_CONTEXT_GUILD_INVITE = 6,
        COM_TRANSACTION_CONTEXT_GUILD_RECOMMEND = 9,
        COM_TRANSACTION_CONTEXT_JOIN_GUILD = 3,
        COM_TRANSACTION_CONTEXT_LUCKYDRAW = 0x13,
        COM_TRANSACTION_CONTEXT_ONLINECHK = 2,
        COM_TRANSACTION_CONTEXT_QUIT_GUILD = 5,
        COM_TRANSACTION_CONTEXT_RANK = 1,
        COM_TRANSACTION_CONTEXT_SEARCH_GUILD = 7,
        COM_TRANSACTION_CONTEXT_TRANS_BASE_INFO = 0x10,
        COM_TRANSACTION_CONTEXT_TRANS_REGISTER_INFO = 0x17
    }
}
