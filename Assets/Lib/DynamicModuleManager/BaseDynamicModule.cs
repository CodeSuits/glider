﻿using UnityEngine;
using System.Collections;

public abstract class BaseDynamicModule : IDynamicModule {

	public abstract string GetModuleId();

	public virtual void OnRegister(DynamicModuleManager mgr)
	{

	}
	
	public virtual void OnRegisterModule(IDynamicModule module , DynamicModuleManager mgr)
	{

	}
}
