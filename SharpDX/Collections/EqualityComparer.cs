// Decompiled with JetBrains decompiler
// Type: SharpDX.Collections.EqualityComparer
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SharpDX.Collections
{
	internal static class EqualityComparer
	{
		public static readonly IEqualityComparer<IntPtr> DefaultIntPtr = (IEqualityComparer<IntPtr>)new EqualityComparer.IntPtrComparer();

		internal class IntPtrComparer : EqualityComparer<IntPtr>
		{
			public override bool Equals([In] IntPtr obj0, [In] IntPtr obj1) => obj0 == obj1;

			public override int GetHashCode([In] IntPtr obj0) => obj0.GetHashCode();
		}
	}
}
