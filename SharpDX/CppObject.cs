// Decompiled with JetBrains decompiler
// Type: SharpDX.CppObject
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public class CppObject : DisposeBase, ICallbackable, IDisposable
	{
		protected internal unsafe void* _nativePointer;

		public CppObject([In] IntPtr obj0) => this.NativePointer = obj0;

		protected CppObject()
		{
		}

		public unsafe IntPtr NativePointer
		{
			get => (IntPtr)this._nativePointer;
			[param: In]
			set
			{
				void* voidPtr = (void*)value;
				if (this._nativePointer == voidPtr)
					return;
				this.NativePointerUpdating();
				void* nativePointer = this._nativePointer;
				this._nativePointer = voidPtr;
				this.NativePointerUpdated((IntPtr)nativePointer);
			}
		}

		public static explicit operator IntPtr([In] CppObject obj0) => obj0 != null ? obj0.NativePointer : IntPtr.Zero;

		protected virtual void NativePointerUpdating()
		{
		}

		protected virtual void NativePointerUpdated([In] IntPtr obj0)
		{
		}

		protected override void Dispose([In] bool obj0)
		{
		}

		public static T FromPointer<T>([In] IntPtr obj0) where T : CppObject
		{
			if (obj0 == IntPtr.Zero)
				return default(T);
			return (T)Activator.CreateInstance(typeof(T), (object)obj0);
		}

		public static IntPtr ToCallbackPtr<TCallback>([In] ICallbackable obj0) where TCallback : ICallbackable
		{
			if (obj0 == null)
				return IntPtr.Zero;
			if (obj0 is CppObject)
				return ((CppObject)obj0).NativePointer;
			if (!(obj0.Shadow is ShadowContainer shadowContainer))
			{
				shadowContainer = new ShadowContainer();
				shadowContainer.Initialize(obj0);
			}
			return shadowContainer.Find(typeof(TCallback));
		}

		IDisposable ICallbackable.Shadow
		{
			get => throw new InvalidOperationException("Invalid access to Callback. This is used internally.");
			[param: In]
			set => throw new InvalidOperationException("Invalid access to Callback. This is used internally.");
		}
	}
}
