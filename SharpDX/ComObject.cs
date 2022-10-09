// Decompiled with JetBrains decompiler
// Type: SharpDX.ComObject
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using SharpDX.Diagnostics;
using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
	[Guid("00000000-0000-0000-C000-000000000046")]
	public class ComObject : CppObject, IUnknown, ICallbackable, IDisposable
	{
		public static Action<string> LogMemoryLeakWarning = (Action<string>)delegate { };

		protected ComObject()
		{
		}

		public virtual void QueryInterface([In] Guid obj0, out IntPtr _param2) => ((IUnknown)this).QueryInterface(ref obj0, out _param2).CheckError();

		public virtual T QueryInterface<T>() where T : ComObject
		{
			IntPtr num;
			this.QueryInterface(Utilities.GetGuidFromType(typeof(T)), out num);
			return CppObject.FromPointer<T>(num);
		}

		Result IUnknown.QueryInterface([In] ref Guid obj0, out IntPtr _param2) => (Result)Marshal.QueryInterface(this.NativePointer, ref obj0, out _param2);

		int IUnknown.AddReference() => !(this.NativePointer == IntPtr.Zero) ? Marshal.AddRef(this.NativePointer) : throw new InvalidOperationException("COM Object pointer is null");

		int IUnknown.Release() => !(this.NativePointer == IntPtr.Zero) ? Marshal.Release(this.NativePointer) : throw new InvalidOperationException("COM Object pointer is null");

		protected override unsafe void Dispose([In] bool obj0)
		{
			if (this.NativePointer != IntPtr.Zero)
			{
				if (!obj0 && Configuration.EnableTrackingReleaseOnFinalizer && !Configuration.EnableReleaseOnFinalizer)
				{
					ObjectReference objectReference = ObjectTracker.Find(this);
					Action<string> memoryLeakWarning = ComObject.LogMemoryLeakWarning;
					if (memoryLeakWarning != null)
						memoryLeakWarning(string.Format("Warning: Live ComObject [0x{0:X}], potential memory leak: {1}", new object[2]
						{
			  (object) this.NativePointer.ToInt64(),
			  (object) objectReference
						}));
				}
				if (obj0 || Configuration.EnableReleaseOnFinalizer)
					((IUnknown)this).Release();
				if (Configuration.EnableObjectTracking)
					ObjectTracker.UnTrack(this);
				this._nativePointer = (void*)null;
			}
			base.Dispose(obj0);
		}

		protected override void NativePointerUpdating()
		{
			if (!Configuration.EnableObjectTracking)
				return;
			ObjectTracker.UnTrack(this);
		}

		protected override void NativePointerUpdated([In] IntPtr obj0)
		{
			if (!Configuration.EnableObjectTracking)
				return;
			ObjectTracker.Track(this);
		}

		public ComObject([In] IntPtr obj0)
		  : base(obj0)
		{
		}

		public static explicit operator ComObject([In] IntPtr obj0) => !(obj0 == IntPtr.Zero) ? new ComObject(obj0) : (ComObject)null;
	}
}
