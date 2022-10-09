// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.OutputDescription
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using SharpDX.Mathematics.Interop;
using System;
using System.Runtime.InteropServices;

namespace SharpDX.DXGI
{
	public struct OutputDescription
	{
		public string DeviceName;
		public RawRectangle DesktopBounds;
		public RawBool IsAttachedToDesktop;
		public DisplayModeRotation Rotation;
		public IntPtr MonitorHandle;

		internal unsafe void __MarshalFrom([In] ref OutputDescription.__Native obj0)
		{
			fixed (char* chPtr = &obj0.DeviceName)
				this.DeviceName = Utilities.PtrToStringUni((IntPtr)(void*)chPtr, 31);
			this.DesktopBounds = obj0.DesktopBounds;
			this.IsAttachedToDesktop = obj0.IsAttachedToDesktop;
			this.Rotation = obj0.Rotation;
			this.MonitorHandle = obj0.MonitorHandle;
		}

		internal struct __Native
		{
			public char DeviceName;
			public char __DeviceName1;
			public char __DeviceName2;
			public char __DeviceName3;
			public char __DeviceName4;
			public char __DeviceName5;
			public char __DeviceName6;
			public char __DeviceName7;
			public char __DeviceName8;
			public char __DeviceName9;
			public char __DeviceName10;
			public char __DeviceName11;
			public char __DeviceName12;
			public char __DeviceName13;
			public char __DeviceName14;
			public char __DeviceName15;
			public char __DeviceName16;
			public char __DeviceName17;
			public char __DeviceName18;
			public char __DeviceName19;
			public char __DeviceName20;
			public char __DeviceName21;
			public char __DeviceName22;
			public char __DeviceName23;
			public char __DeviceName24;
			public char __DeviceName25;
			public char __DeviceName26;
			public char __DeviceName27;
			public char __DeviceName28;
			public char __DeviceName29;
			public char __DeviceName30;
			public char __DeviceName31;
			public RawRectangle DesktopBounds;
			public RawBool IsAttachedToDesktop;
			public DisplayModeRotation Rotation;
			public IntPtr MonitorHandle;
		}
	}
}
