// Decompiled with JetBrains decompiler
// Type: SharpDX.Diagnostics.ComObjectEventArgs
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Diagnostics
{
	public class ComObjectEventArgs : EventArgs
	{
		public ComObject Object;

		public ComObjectEventArgs([In] ComObject obj0) => this.Object = obj0;
	}
}
