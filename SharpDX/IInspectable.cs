﻿// Decompiled with JetBrains decompiler
// Type: SharpDX.IInspectable
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
	[Shadow(typeof(InspectableShadow))]
	[Guid("AF86E2E0-B12D-4c6a-9C5A-D7AA65101E90")]
	public interface IInspectable : ICallbackable, IDisposable
	{
	}
}
