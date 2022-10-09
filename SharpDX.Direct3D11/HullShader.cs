// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.HullShader
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	[Guid("8e5c6061-628a-4c8e-8264-bbe45cb3d5dd")]
	public class HullShader : DeviceChild
	{
		public HullShader([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator HullShader([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new HullShader(obj0) : (HullShader)null;
	}
}
