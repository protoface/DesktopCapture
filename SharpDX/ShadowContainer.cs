// Decompiled with JetBrains decompiler
// Type: SharpDX.ShadowContainer
// Assembly: SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: D6E2E6B1-B3C5-46B6-96AB-7C91DE83948F
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SharpDX
{
	internal class ShadowContainer : DisposeBase
	{
		private readonly Dictionary<Guid, CppObjectShadow> guidToShadow = new Dictionary<Guid, CppObjectShadow>();
		private static readonly Dictionary<Type, List<Type>> typeToShadowTypes = new Dictionary<Type, List<Type>>();
		private IntPtr guidPtr;

		public IntPtr[] Guids { get; [param: In] private set; }

		public unsafe void Initialize([In] ICallbackable obj0)
		{
			obj0.Shadow = (IDisposable)this;
			Type type1 = obj0.GetType();
			List<Type> typeList;
			lock (ShadowContainer.typeToShadowTypes)
			{
				if (!ShadowContainer.typeToShadowTypes.TryGetValue(type1, out typeList))
				{
					IEnumerable<Type> implementedInterfaces = type1.GetTypeInfo().ImplementedInterfaces;
					typeList = new List<Type>();
					typeList.AddRange(implementedInterfaces);
					ShadowContainer.typeToShadowTypes.Add(type1, typeList);
					foreach (Type type2 in implementedInterfaces)
					{
						if (ShadowAttribute.Get(type2) == null)
						{
							typeList.Remove(type2);
						}
						else
						{
							foreach (Type implementedInterface in type2.GetTypeInfo().ImplementedInterfaces)
								typeList.Remove(implementedInterface);
						}
					}
				}
			}
			CppObjectShadow cppObjectShadow = (CppObjectShadow)null;
			foreach (Type type3 in typeList)
			{
				CppObjectShadow instance = (CppObjectShadow)Activator.CreateInstance(ShadowAttribute.Get(type3).Type);
				instance.Initialize(obj0);
				if (cppObjectShadow == null)
				{
					cppObjectShadow = instance;
					this.guidToShadow.Add(ComObjectShadow.IID_IUnknown, cppObjectShadow);
				}
				this.guidToShadow.Add(Utilities.GetGuidFromType(type3), instance);
				foreach (Type implementedInterface in type3.GetTypeInfo().ImplementedInterfaces)
				{
					if (ShadowAttribute.Get(implementedInterface) != null)
						this.guidToShadow.Add(Utilities.GetGuidFromType(implementedInterface), instance);
				}
			}
			int length = 0;
			foreach (Guid key in this.guidToShadow.Keys)
			{
				if (key != Utilities.GetGuidFromType(typeof(IInspectable)) && key != Utilities.GetGuidFromType(typeof(IUnknown)))
					++length;
			}
			this.guidPtr = Marshal.AllocHGlobal(sizeof(Guid) * length);
			this.Guids = new IntPtr[length];
			int index = 0;
			Guid* guidPtr = (Guid*)(void*)this.guidPtr;
			foreach (Guid key in this.guidToShadow.Keys)
			{
				if (!(key == Utilities.GetGuidFromType(typeof(IInspectable))) && !(key == Utilities.GetGuidFromType(typeof(IUnknown))))
				{
					guidPtr[index] = key;
					this.Guids[index] = new IntPtr((void*)(guidPtr + index));
					++index;
				}
			}
		}

		internal IntPtr Find([In] Type obj0) => this.Find(Utilities.GetGuidFromType(obj0));

		internal IntPtr Find([In] Guid obj0)
		{
			CppObjectShadow shadow = this.FindShadow(obj0);
			return shadow != null ? shadow.NativePointer : IntPtr.Zero;
		}

		internal CppObjectShadow FindShadow([In] Guid obj0)
		{
			CppObjectShadow shadow;
			this.guidToShadow.TryGetValue(obj0, out shadow);
			return shadow;
		}

		protected override void Dispose([In] bool obj0)
		{
			if (!obj0)
				return;
			foreach (DisposeBase disposeBase in this.guidToShadow.Values)
				disposeBase.Dispose();
			this.guidToShadow.Clear();
			if (!(this.guidPtr != IntPtr.Zero))
				return;
			Marshal.FreeHGlobal(this.guidPtr);
			this.guidPtr = IntPtr.Zero;
		}
	}
}
