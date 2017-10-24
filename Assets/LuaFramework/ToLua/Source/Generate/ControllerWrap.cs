﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Controller), typeof(System.Object));
		L.RegFunction("ExecuteCommand", ExecuteCommand);
		L.RegFunction("RegisterCommand", RegisterCommand);
		L.RegFunction("RegisterViewCommand", RegisterViewCommand);
		L.RegFunction("HasCommand", HasCommand);
		L.RegFunction("RemoveCommand", RemoveCommand);
		L.RegFunction("RemoveViewCommand", RemoveViewCommand);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExecuteCommand(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Controller obj = (Controller)ToLua.CheckObject<Controller>(L, 1);
			IMessage arg0 = (IMessage)ToLua.CheckObject<IMessage>(L, 2);
			obj.ExecuteCommand(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterCommand(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Controller obj = (Controller)ToLua.CheckObject<Controller>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			System.Type arg1 = ToLua.CheckMonoType(L, 3);
			obj.RegisterCommand(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterViewCommand(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Controller obj = (Controller)ToLua.CheckObject<Controller>(L, 1);
			IView arg0 = (IView)ToLua.CheckObject<IView>(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			obj.RegisterViewCommand(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasCommand(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Controller obj = (Controller)ToLua.CheckObject<Controller>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.HasCommand(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveCommand(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Controller obj = (Controller)ToLua.CheckObject<Controller>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.RemoveCommand(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveViewCommand(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Controller obj = (Controller)ToLua.CheckObject<Controller>(L, 1);
			IView arg0 = (IView)ToLua.CheckObject<IView>(L, 2);
			string[] arg1 = ToLua.CheckStringArray(L, 3);
			obj.RemoveViewCommand(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, Controller.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
