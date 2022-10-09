// Decompiled with JetBrains decompiler
// Type: SharpDX.DisposeBase
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public abstract class DisposeBase : IDisposable
	{
		~DisposeBase() => this.CheckAndDispose(false);

		/// <summary>
		/// Occurs when this instance is starting to be disposed.
		/// </summary>
		public event EventHandler<EventArgs> Disposing;

		/// <summary>
		/// Occurs when this instance is fully disposed.
		/// </summary>
		public event EventHandler<EventArgs> Disposed;

		public bool IsDisposed { get; [param: In] private set; }

		public void Dispose() => this.CheckAndDispose(true);

		private void CheckAndDispose([In] bool obj0)
		{
			if (this.IsDisposed)
				return;
			// ISSUE: reference to a compiler-generated field
			EventHandler<EventArgs> disposing = this.Disposing;
			if (disposing != null)
				disposing((object)this, (EventArgs)DisposeEventArgs.Get(obj0));
			this.Dispose(obj0);
			GC.SuppressFinalize((object)this);
			this.IsDisposed = true;
			// ISSUE: reference to a compiler-generated field
			EventHandler<EventArgs> disposed = this.Disposed;
			if (disposed == null)
				return;
			disposed((object)this, (EventArgs)DisposeEventArgs.Get(obj0));
		}

		protected abstract void Dispose([In] bool obj0);
	}
}
