// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.OutputDuplication
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("191cfac3-a341-470d-b26e-a864f428319c")]
	public class OutputDuplication : DXGIObject
	{
		public OutputDuplication([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator OutputDuplication([In] IntPtr obj0) => (obj0 != IntPtr.Zero) ? new OutputDuplication(obj0) : null;

		public unsafe Result TryAcquireNextFrame([In] int obj0, out OutputDuplicateFrameInformation _param2, out Resource _param3)
		{
			_param2 = default;
			IntPtr zero = IntPtr.Zero;
			Result result;
			fixed (OutputDuplicateFrameInformation* ptr = &_param2)
			{
				void* ptr2 = ptr;
				void* nativePointer = _nativePointer;
				result = ((delegate* unmanaged[Stdcall]<void*, int, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)8 * (nint)sizeof(void*))))(nativePointer, obj0, ptr2, &zero);
			}

			if (zero != IntPtr.Zero)
			{
				_param3 = new Resource(zero);
				return result;
			}

			_param3 = null;
			return result;
		}

		public unsafe void ReleaseFrame()
		{
			void* nativePointer = _nativePointer;
			((Result)((delegate* unmanaged[Stdcall]<void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)14 * (nint)sizeof(void*))))(nativePointer)).CheckError();
		}
	}
}
