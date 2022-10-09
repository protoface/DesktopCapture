// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.DeviceChild
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
	public class DeviceChild : DXGIObject
	{
		public DeviceChild([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator DeviceChild([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new DeviceChild(obj0) : (DeviceChild)null;
	}
}
