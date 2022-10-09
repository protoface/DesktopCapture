// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.ComputeShader
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	[Guid("4f5b196e-c2bd-495e-bd01-1fded38e4969")]
	public class ComputeShader : DeviceChild
	{
		public ComputeShader([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator ComputeShader([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new ComputeShader(obj0) : (ComputeShader)null;
	}
}
