// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.DXGI
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	internal static class DXGI
	{
		public static unsafe void CreateDXGIFactory1([In] Guid obj0, out IntPtr _param1)
		{
			Result dxgiFactory1;
			fixed (IntPtr* numPtr = &_param1)
				dxgiFactory1 = (Result)SharpDX.DXGI.DXGI.CreateDXGIFactory1_((void*)&obj0, (void*)numPtr);
			dxgiFactory1.CheckError();
		}

		[DllImport("dxgi.dll", EntryPoint = "CreateDXGIFactory1", CallingConvention = CallingConvention.StdCall)]
		private static extern unsafe int CreateDXGIFactory1_([In] void* obj0, [In] void* obj1);
	}
}
