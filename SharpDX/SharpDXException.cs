// Decompiled with JetBrains decompiler
// Type: SharpDX.SharpDXException
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public class SharpDXException : Exception
	{
		private ResultDescriptor descriptor;

		public SharpDXException([In] Result obj0)
		  : this(ResultDescriptor.Find(obj0))
		{
			this.HResult = (int)obj0;
		}

		public SharpDXException([In] ResultDescriptor obj0)
		  : base(obj0.ToString())
		{
			this.descriptor = obj0;
			this.HResult = (int)obj0.Result;
		}

		public Result ResultCode => this.descriptor.Result;
	}
}
