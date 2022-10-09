// Decompiled with JetBrains decompiler
// Type: SharpDX.DisposeEventArgs
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public class DisposeEventArgs : EventArgs
	{
		public static readonly DisposeEventArgs DisposingEventArgs = new DisposeEventArgs(true);
		public static readonly DisposeEventArgs NotDisposingEventArgs = new DisposeEventArgs(false);
		public readonly bool Disposing;

		private DisposeEventArgs([In] bool obj0) => this.Disposing = obj0;

		public static DisposeEventArgs Get([In] bool obj0) => !obj0 ? DisposeEventArgs.NotDisposingEventArgs : DisposeEventArgs.DisposingEventArgs;
	}
}
