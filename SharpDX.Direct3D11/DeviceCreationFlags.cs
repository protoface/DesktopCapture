// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.DeviceCreationFlags
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;

namespace SharpDX.Direct3D11
{
	[Flags]
	public enum DeviceCreationFlags
	{
		SingleThreaded = 1,
		Debug = 2,
		SwitchToRef = 4,
		PreventThreadingOptimizations = 8,
		BgraSupport = 32, // 0x00000020
		Debuggable = 64, // 0x00000040
		PreventAlteringLayerSettingsFromRegistry = 128, // 0x00000080
		DisableGpuTimeout = 256, // 0x00000100
		VideoSupport = 2048, // 0x00000800
		None = 0,
	}
}
