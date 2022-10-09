// Decompiled with JetBrains decompiler
// Type: SharpDX.Result
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public struct Result : IEquatable<Result>
	{
		private int _code;
		public static readonly Result Ok = new Result(0);
		public static readonly Result False = new Result(1);
		public static readonly ResultDescriptor Abort = new ResultDescriptor(-2147467260, "General", "E_ABORT", "Operation aborted");
		public static readonly ResultDescriptor AccessDenied = new ResultDescriptor(-2147024891, "General", "E_ACCESSDENIED", "General access denied error");
		public static readonly ResultDescriptor Fail = new ResultDescriptor(-2147467259, "General", "E_FAIL", "Unspecified error");
		public static readonly ResultDescriptor Handle = new ResultDescriptor(-2147024890, "General", "E_HANDLE", "Invalid handle");
		public static readonly ResultDescriptor InvalidArg = new ResultDescriptor(-2147024809, "General", "E_INVALIDARG", "Invalid Arguments");
		public static readonly ResultDescriptor NoInterface = new ResultDescriptor(-2147467262, "General", "E_NOINTERFACE", "No such interface supported");
		public static readonly ResultDescriptor NotImplemented = new ResultDescriptor(-2147467263, "General", "E_NOTIMPL", "Not implemented");
		public static readonly ResultDescriptor OutOfMemory = new ResultDescriptor(-2147024882, "General", "E_OUTOFMEMORY", "Out of memory");
		public static readonly ResultDescriptor InvalidPointer = new ResultDescriptor(-2147467261, "General", "E_POINTER", "Invalid pointer");
		public static readonly ResultDescriptor UnexpectedFailure = new ResultDescriptor(-2147418113, "General", "E_UNEXPECTED", "Catastrophic failure");
		public static readonly ResultDescriptor WaitAbandoned = new ResultDescriptor(128, "General", "WAIT_ABANDONED", nameof(WaitAbandoned));
		public static readonly ResultDescriptor WaitTimeout = new ResultDescriptor(258, "General", "WAIT_TIMEOUT", nameof(WaitTimeout));
		public static readonly ResultDescriptor Pending = new ResultDescriptor(-2147483638, "General", "E_PENDING", nameof(Pending));

		public Result([In] int obj0) => this._code = obj0;

		public Result([In] uint obj0) => this._code = (int)obj0;

		public int Code => this._code;

		public static explicit operator int([In] Result obj0) => obj0.Code;

		public static explicit operator uint([In] Result obj0) => (uint)obj0.Code;

		public static implicit operator Result([In] int obj0) => new Result(obj0);

		public static implicit operator Result([In] uint obj0) => new Result(obj0);

		public bool Equals([In] Result obj0) => this.Code == obj0.Code;

		public override bool Equals([In] object obj0) => obj0 is Result result && this.Equals(result);

		public override int GetHashCode() => this.Code;

		public static bool operator ==([In] Result obj0, [In] Result obj1) => obj0.Code == obj1.Code;

		public static bool operator !=([In] Result obj0, [In] Result obj1) => obj0.Code != obj1.Code;

		public override string ToString() => string.Format((IFormatProvider)CultureInfo.InvariantCulture, "HRESULT = 0x{0:X}", new object[1]
		{
	  (object) this._code
		});

		public void CheckError()
		{
			if (this._code < 0)
				throw new SharpDXException(this);
		}
	}
}
