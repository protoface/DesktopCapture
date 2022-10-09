// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.Device
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using SharpDX.Direct3D;
using SharpDX.DXGI;
using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	[Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140")]
	public class Device : ComObject
	{
		protected internal DeviceContext ImmediateContext__;

		public Device([In] Adapter obj0)
		  : this(obj0, DeviceCreationFlags.None)
		{
		}

		public Device([In] Adapter obj0, [In] DeviceCreationFlags obj1) => this.CreateDevice(obj0, DriverType.Unknown, obj1, (FeatureLevel[])null);

		protected override void Dispose([In] bool obj0)
		{
			if (obj0 && this.ImmediateContext__ != null)
			{
				this.ImmediateContext__.Dispose();
				this.ImmediateContext__ = (DeviceContext)null;
			}
			base.Dispose(obj0);
		}

		private void CreateDevice(
		  [In] Adapter obj0,
		  [In] DriverType obj1,
		  [In] DeviceCreationFlags obj2,
		  [In] FeatureLevel[] obj3)
		{
			D3D11.CreateDevice(obj0, obj1, IntPtr.Zero, obj2, obj3, obj3 == null ? 0 : obj3.Length, 7, this, out FeatureLevel _, out this.ImmediateContext__).CheckError();
			if (this.ImmediateContext__ == null)
				return;
			((IUnknown)this).AddReference();
			this.ImmediateContext__.Device__ = this;
		}

		public Device([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator Device([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new Device(obj0) : (Device)null;

		public DeviceContext ImmediateContext
		{
			get
			{
				if (this.ImmediateContext__ == null)
					this.GetImmediateContext(out this.ImmediateContext__);
				return this.ImmediateContext__;
			}
		}

		internal unsafe void CreateTexture2D([In] ref Texture2DDescription obj0, [In] DataBox[] obj1, [In] Texture2D obj2)
		{
			IntPtr zero = IntPtr.Zero;
			Result result;
			fixed (DataBox* ptr = obj1)
			{
				void* ptr2 = ptr;
				fixed (Texture2DDescription* ptr3 = &obj0)
				{
					void* ptr4 = ptr3;
					void* nativePointer = _nativePointer;
					result = ((delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)5 * (nint)sizeof(void*))))(nativePointer, ptr4, ptr2, &zero);
				}
			}

			obj2.NativePointer = zero;
			result.CheckError();
		}

		internal unsafe void GetImmediateContext(out DeviceContext _param1)
		{
			IntPtr zero = IntPtr.Zero;
			void* nativePointer = _nativePointer;
			((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)40 * (nint)sizeof(void*))))(nativePointer, &zero);
			if (zero != IntPtr.Zero)
			{
				_param1 = new DeviceContext(zero);
			}
			else
			{
				_param1 = null;
			}
		}
	}
}
