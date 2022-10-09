// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.Factory1
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	[Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
	public class Factory1 : Factory
	{
		public Factory1()
		  : base(IntPtr.Zero)
		{
			IntPtr num;
			SharpDX.DXGI.DXGI.CreateDXGIFactory1(Utilities.GetGuidFromType(this.GetType()), out num);
			this.NativePointer = num;
		}

		public Adapter1 GetAdapter1([In] int obj0)
		{
			Adapter1 adapter1;
			this.GetAdapter1(obj0, out adapter1).CheckError();
			return adapter1;
		}

		public Factory1([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Factory1([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Factory1(obj0) : (Factory1)null;

		internal unsafe Result GetAdapter1([In] int obj0, out Adapter1 _param2)
		{
			IntPtr zero = IntPtr.Zero;
			void* nativePointer = _nativePointer;
			Result result = ((delegate* unmanaged[Stdcall]<void*, int, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)12 * (nint)sizeof(void*))))(nativePointer, obj0, &zero);
			if (zero != IntPtr.Zero)
			{
				_param2 = new Adapter1(zero);
				return result;
			}

			_param2 = null;
			return result;
		}
	}
}
