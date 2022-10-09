// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.Output
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
	public class Output : DXGIObject
	{
		public Output([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Output([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Output(obj0) : (Output)null;

		public OutputDescription Description
		{
			get
			{
				OutputDescription description;
				this.GetDescription(out description);
				return description;
			}
		}

		internal unsafe void GetDescription(out OutputDescription _param1)
		{
			OutputDescription.__Native @ref = default(OutputDescription.__Native);
			_param1 = default(OutputDescription);
			void* nativePointer = _nativePointer;
			Result result = ((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)7 * (nint)sizeof(void*))))(nativePointer, &@ref);
			_param1.__MarshalFrom(ref @ref);
			result.CheckError();
		}
	}
}
