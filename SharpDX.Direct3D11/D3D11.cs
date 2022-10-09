// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.D3D11
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using SharpDX.Direct3D;
using SharpDX.DXGI;
using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	internal static class D3D11
	{
		public static unsafe Result CreateDevice(
		  [In] Adapter obj0,
		  [In] DriverType obj1,
		  [In] IntPtr obj2,
		  [In] DeviceCreationFlags obj3,
		  [In] FeatureLevel[] obj4,
		  [In] int obj5,
		  [In] int obj6,
		  [In] Device obj7,
		  out FeatureLevel _param8,
		  out DeviceContext _param9)
		{
			IntPtr zero1 = IntPtr.Zero;
			IntPtr zero2 = IntPtr.Zero;
			IntPtr zero3 = IntPtr.Zero;
			IntPtr callbackPtr = CppObject.ToCallbackPtr<Adapter>((ICallbackable)obj0);
			Result device;
			fixed (FeatureLevel* featureLevelPtr1 = &_param8)
			fixed (FeatureLevel* featureLevelPtr2 = obj4)
				device = (Result)D3D11.D3D11CreateDevice_((void*)callbackPtr, (int)obj1, (void*)obj2, (int)obj3, (void*)featureLevelPtr2, obj5, obj6, (void*)&zero2, (void*)featureLevelPtr1, (void*)&zero3);
			obj7.NativePointer = zero2;
			if (zero3 != IntPtr.Zero)
			{
				_param9 = new DeviceContext(zero3);
				return device;
			}
			_param9 = (DeviceContext)null;
			return device;
		}

		[DllImport("d3d11.dll", EntryPoint = "D3D11CreateDevice", CallingConvention = CallingConvention.StdCall)]
		private static extern unsafe int D3D11CreateDevice_(
		  [In] void* obj0,
		  [In] int obj1,
		  [In] void* obj2,
		  [In] int obj3,
		  [In] void* obj4,
		  [In] int obj5,
		  [In] int obj6,
		  [In] void* obj7,
		  [In] void* obj8,
		  [In] void* obj9);
	}
}
