// Decompiled with JetBrains decompiler
// Type: SharpDX.Utilities
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public static class Utilities
	{
		//public unsafe static int SizeOf<T>() where T : struct 
		//{
		//	return sizeof(T);
		//}

		public static Guid GetGuidFromType([In] Type obj0) => obj0.GetTypeInfo().GUID;

		public static string PtrToStringUni([In] IntPtr obj0, [In] int obj1)
		{
			string stringUni = Marshal.PtrToStringUni(obj0);
			if (stringUni != null && stringUni.Length > obj1)
				stringUni = stringUni.Substring(0, obj1);
			return stringUni;
		}
	}
}
