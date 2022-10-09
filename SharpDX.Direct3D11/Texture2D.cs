// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.Texture2D
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	[Guid("6f15aaf2-d208-4e89-9ab4-489535d34f9c")]
	public class Texture2D : Resource
	{
		public Texture2D([In] Device obj0, [In] Texture2DDescription obj1)
		  : base(IntPtr.Zero)
		{
			obj0.CreateTexture2D(ref obj1, (DataBox[])null, this);
		}

		public Texture2D([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Texture2D([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Texture2D(obj0) : (Texture2D)null;
	}
}
