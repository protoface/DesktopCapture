// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.Output1
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("00cddea8-939b-4b83-a340-a685226666cc")]
	public class Output1 : Output
	{
		public Output1([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Output1([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Output1(obj0) : (Output1)null;

		public unsafe OutputDuplication DuplicateOutput([In] IUnknown obj0)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			zero = CppObject.ToCallbackPtr<IUnknown>(obj0);
			void* nativePointer = _nativePointer;
			void* intPtr = (void*)zero;
			Result result = ((delegate* unmanaged[Stdcall]<void*, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)22 * (nint)sizeof(void*))))(nativePointer, intPtr, &zero2);
			OutputDuplication result2 = ((!(zero2 != IntPtr.Zero)) ? null : new OutputDuplication(zero2));
			result.CheckError();
			return result2;
		}
	}
}
