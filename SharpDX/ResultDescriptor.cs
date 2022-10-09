// Decompiled with JetBrains decompiler
// Type: SharpDX.ResultDescriptor
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SharpDX
{
	public sealed class ResultDescriptor
	{
		private static readonly object LockDescriptor = new object();
		private static readonly List<Type> RegisteredDescriptorProvider = new List<Type>();
		private static readonly Dictionary<Result, ResultDescriptor> Descriptors = new Dictionary<Result, ResultDescriptor>();

		public ResultDescriptor([In] Result obj0, [In] string obj1, [In] string obj2, [In] string obj3, string _param5 = null)
		{
			this.Result = obj0;
			this.Module = obj1;
			this.NativeApiCode = obj2;
			this.ApiCode = obj3;
			this.Description = _param5;
		}

		public Result Result { get; [param: In] private set; }

		public string Module { get; [param: In] private set; }

		public string NativeApiCode { get; [param: In] private set; }

		public string ApiCode { get; [param: In] private set; }

		public string Description { get; [param: In] set; }

		public bool Equals([In] ResultDescriptor obj0)
		{
			if ((object)obj0 == null)
				return false;
			return (object)this == (object)obj0 || obj0.Result.Equals(this.Result);
		}

		public override bool Equals([In] object obj0)
		{
			if (obj0 == null)
				return false;
			if ((object)this == obj0)
				return true;
			return (object)obj0.GetType() == (object)typeof(ResultDescriptor) && this.Equals((ResultDescriptor)obj0);
		}

		public override int GetHashCode() => this.Result.GetHashCode();

		public override string ToString() => string.Format("HRESULT: [0x{0:X}], Module: [{1}], ApiCode: [{2}/{3}], Message: {4}", (object)this.Result.Code, (object)this.Module, (object)this.NativeApiCode, (object)this.ApiCode, (object)this.Description);

		public static implicit operator Result([In] ResultDescriptor obj0) => obj0.Result;

		public static explicit operator int([In] ResultDescriptor obj0) => obj0.Result.Code;

		public static explicit operator uint([In] ResultDescriptor obj0) => (uint)obj0.Result.Code;

		public static bool operator ==([In] ResultDescriptor obj0, [In] Result obj1) => (object)obj0 != null && obj0.Result.Code == obj1.Code;

		public static bool operator !=([In] ResultDescriptor obj0, [In] Result obj1) => (object)obj0 != null && obj0.Result.Code != obj1.Code;

		public static void RegisterProvider([In] Type obj0)
		{
			lock (ResultDescriptor.LockDescriptor)
			{
				if (ResultDescriptor.RegisteredDescriptorProvider.Contains(obj0))
					return;
				ResultDescriptor.RegisteredDescriptorProvider.Add(obj0);
			}
		}

		public static ResultDescriptor Find([In] Result obj0)
		{
			ResultDescriptor resultDescriptor;
			lock (ResultDescriptor.LockDescriptor)
			{
				if (ResultDescriptor.RegisteredDescriptorProvider.Count > 0)
				{
					foreach (Type type in ResultDescriptor.RegisteredDescriptorProvider)
						ResultDescriptor.AddDescriptorsFromType(type);
					ResultDescriptor.RegisteredDescriptorProvider.Clear();
				}
				if (!ResultDescriptor.Descriptors.TryGetValue(obj0, out resultDescriptor))
					resultDescriptor = new ResultDescriptor(obj0, "Unknown", "Unknown", "Unknown");
				if (resultDescriptor.Description == null)
				{
					string descriptionFromResultCode = ResultDescriptor.GetDescriptionFromResultCode(obj0.Code);
					resultDescriptor.Description = descriptionFromResultCode ?? "Unknown";
				}
			}
			return resultDescriptor;
		}

		private static void AddDescriptorsFromType([In] Type obj0)
		{
			foreach (FieldInfo declaredField in obj0.GetTypeInfo().DeclaredFields)
			{
				if ((object)declaredField.FieldType == (object)typeof(ResultDescriptor) && declaredField.IsPublic && declaredField.IsStatic)
				{
					ResultDescriptor resultDescriptor = (ResultDescriptor)declaredField.GetValue((object)null);
					if (!ResultDescriptor.Descriptors.ContainsKey(resultDescriptor.Result))
						ResultDescriptor.Descriptors.Add(resultDescriptor.Result, resultDescriptor);
				}
			}
		}

		private static string GetDescriptionFromResultCode([In] int obj0)
		{
			IntPtr zero = IntPtr.Zero;
			int num = (int)ResultDescriptor.FormatMessageW(4864, IntPtr.Zero, obj0, 0, ref zero, 0, IntPtr.Zero);
			string stringUni = Marshal.PtrToStringUni(zero);
			Marshal.FreeHGlobal(zero);
			return stringUni;
		}

		[DllImport("kernel32.dll")]
		private static extern uint FormatMessageW(
		  [In] int obj0,
		  [In] IntPtr obj1,
		  [In] int obj2,
		  [In] int obj3,
		  [In] ref IntPtr obj4,
		  [In] int obj5,
		  [In] IntPtr obj6);
	}
}
