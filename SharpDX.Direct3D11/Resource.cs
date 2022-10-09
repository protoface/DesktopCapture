// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.Resource
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	[Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d")]
	public class Resource : DeviceChild
	{
		public Resource([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Resource([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Resource(obj0) : (Resource)null;
	}
}
