// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.DXGIObject
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
	public class DXGIObject : ComObject
	{
		public DXGIObject([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator DXGIObject([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new DXGIObject(obj0) : (DXGIObject)null;
	}
}
