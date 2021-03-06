﻿using com.tencent.pandora;
using System;
using System.Collections;

public class IEnumeratorWrap
{
    private static System.Type classType = typeof(IEnumerator);

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    private static int _CreateIEnumerator(IntPtr L)
    {
        LuaDLL.luaL_error(L, "IEnumerator class does not have a constructor function");
        return 0;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    private static int get_Current(IntPtr L)
    {
        IEnumerator luaObject = (IEnumerator) LuaScriptMgr.GetLuaObject(L, 1);
        if (luaObject == null)
        {
            if (LuaDLL.lua_type(L, 1) == LuaTypes.LUA_TTABLE)
            {
                LuaDLL.luaL_error(L, "unknown member name Current");
            }
            else
            {
                LuaDLL.luaL_error(L, "attempt to index Current on a nil value");
            }
        }
        LuaScriptMgr.PushVarObject(L, luaObject.Current);
        return 1;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    private static int GetClassType(IntPtr L)
    {
        LuaScriptMgr.Push(L, classType);
        return 1;
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    private static int MoveNext(IntPtr L)
    {
        LuaScriptMgr.CheckArgsCount(L, 1);
        bool b = ((IEnumerator) LuaScriptMgr.GetNetObjectSelf(L, 1, "IEnumerator")).MoveNext();
        LuaScriptMgr.Push(L, b);
        return 1;
    }

    public static void Register(IntPtr L)
    {
        LuaMethod[] regs = new LuaMethod[] { new LuaMethod("MoveNext", new LuaCSFunction(IEnumeratorWrap.MoveNext)), new LuaMethod("Reset", new LuaCSFunction(IEnumeratorWrap.Reset)), new LuaMethod("New", new LuaCSFunction(IEnumeratorWrap._CreateIEnumerator)), new LuaMethod("GetClassType", new LuaCSFunction(IEnumeratorWrap.GetClassType)) };
        LuaField[] fields = new LuaField[] { new LuaField("Current", new LuaCSFunction(IEnumeratorWrap.get_Current), null) };
        LuaScriptMgr.RegisterLib(L, "System.Collections.IEnumerator", typeof(IEnumerator), regs, fields, null);
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    private static int Reset(IntPtr L)
    {
        LuaScriptMgr.CheckArgsCount(L, 1);
        ((IEnumerator) LuaScriptMgr.GetNetObjectSelf(L, 1, "IEnumerator")).Reset();
        return 0;
    }
}

