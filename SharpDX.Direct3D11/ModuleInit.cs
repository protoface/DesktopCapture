﻿// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.ModuleInit
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

namespace SharpDX.Direct3D11
{
	internal class ModuleInit
	{
		[Tag("SharpDX.ModuleInit")]
		internal static void Setup() => ResultDescriptor.RegisterProvider(typeof(ResultCode));
	}
}
