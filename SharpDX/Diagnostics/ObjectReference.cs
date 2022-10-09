// Decompiled with JetBrains decompiler
// Type: SharpDX.Diagnostics.ObjectReference
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpDX.Diagnostics
{
	public class ObjectReference
	{
		public ObjectReference([In] DateTime obj0, [In] ComObject obj1, [In] string obj2)
		{
			this.CreationTime = obj0;
			this.Object = new WeakReference((object)obj1, true);
			this.StackTrace = obj2;
		}

		public DateTime CreationTime { get; [param: In] private set; }

		public WeakReference Object { get; [param: In] private set; }

		public string StackTrace { get; [param: In] private set; }

		public bool IsAlive => this.Object.IsAlive;

		public override string ToString()
		{
			if (!(this.Object.Target is ComObject target))
				return "";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat((IFormatProvider)CultureInfo.InvariantCulture, "Active COM Object: [0x{0:X}] Class: [{1}] Time [{2}] Stack:\r\n{3}", (object)target.NativePointer.ToInt64(), (object)target.GetType().FullName, (object)this.CreationTime, (object)this.StackTrace).AppendLine();
			return stringBuilder.ToString();
		}
	}
}
