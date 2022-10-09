// Decompiled with JetBrains decompiler
// Type: SharpDX.Mathematics.Interop.RawBool
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Mathematics.Interop
{
	public struct RawBool : IEquatable<RawBool>
	{
		private readonly int boolValue;

		public RawBool([In] bool obj0) => this.boolValue = obj0 ? 1 : 0;

		public bool Equals([In] RawBool obj0) => this.boolValue == obj0.boolValue;

		public override bool Equals([In] object obj0) => obj0 != null && obj0 is RawBool rawBool && this.Equals(rawBool);

		public override int GetHashCode() => this.boolValue;

		public static bool operator ==([In] RawBool obj0, [In] RawBool obj1) => obj0.Equals(obj1);

		public static bool operator !=([In] RawBool obj0, [In] RawBool obj1) => !obj0.Equals(obj1);

		public static implicit operator bool([In] RawBool obj0) => obj0.boolValue != 0;

		public static implicit operator RawBool([In] bool obj0) => new RawBool(obj0);

		public override string ToString() => string.Format("{0}", new object[1]
		{
	  (object) (this.boolValue != 0)
		});
	}
}
