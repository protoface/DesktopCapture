// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.Adapter1
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("29038f61-3839-4626-91fd-086879011a05")]
	public class Adapter1 : Adapter
	{
		public Adapter1([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Adapter1([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Adapter1(obj0) : (Adapter1)null;
	}
}
