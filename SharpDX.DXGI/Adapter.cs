// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.Adapter
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
	public class Adapter : DXGIObject
	{
		public Output GetOutput([In] int obj0)
		{
			Output output;
			this.GetOutput(obj0, out output).CheckError();
			return output;
		}

		public Adapter([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Adapter([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Adapter(obj0) : (Adapter)null;

		internal unsafe Result GetOutput([In] int obj0, out Output _param2)
		{
			IntPtr zero = IntPtr.Zero;
			void* nativePointer = _nativePointer;
			Result result = ((delegate* unmanaged[Stdcall]<void*, int, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)7 * (nint)sizeof(void*))))(nativePointer, obj0, &zero);
			if (zero != IntPtr.Zero)
			{
				_param2 = new Output(zero);
				return result;
			}

			_param2 = null;
			return result;
		}
	}
}
