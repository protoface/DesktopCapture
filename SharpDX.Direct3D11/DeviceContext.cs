// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.DeviceContext
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;
using System.Runtime.InteropServices;

namespace SharpDX.Direct3D11
{
	[Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da")]
	public class DeviceContext : DeviceChild
	{
		public void CopyResource([In] Resource obj0, [In] Resource obj1) => this.CopyResource_(obj1, obj0);

		public DataBox MapSubresource([In] Resource obj0, [In] int obj1, [In] MapMode obj2, [In] MapFlags obj3)
		{
			Result result = this.MapSubresource(obj0, obj1, obj2, obj3, out DataBox dataBox);
			if ((obj3 & MapFlags.DoNotWait) != MapFlags.None && result == (Result)SharpDX.DXGI.ResultCode.WasStillDrawing)
				return dataBox;
			result.CheckError();
			return dataBox;
		}

		public DeviceContext([In] IntPtr obj0)
		  : base(obj0)
		{
			this.VertexShader = new VertexShaderStage(obj0);
			this.PixelShader = new PixelShaderStage(obj0);
			this.InputAssembler = new InputAssemblerStage(obj0);
			this.GeometryShader = new GeometryShaderStage(obj0);
			this.OutputMerger = new OutputMergerStage(obj0);
			this.StreamOutput = new StreamOutputStage(obj0);
			this.Rasterizer = new RasterizerStage(obj0);
			this.HullShader = new HullShaderStage(obj0);
			this.DomainShader = new DomainShaderStage(obj0);
			this.ComputeShader = new ComputeShaderStage(obj0);
		}

		public static explicit operator DeviceContext([In] IntPtr obj0) => (obj0 != IntPtr.Zero) ? new DeviceContext(obj0) : (DeviceContext)null;

		protected override void NativePointerUpdated([In] IntPtr obj0)
		{
			base.NativePointerUpdated(obj0);
			if (this.VertexShader == null)
				this.VertexShader = new VertexShaderStage(IntPtr.Zero);
			this.VertexShader.NativePointer = this.NativePointer;
			if (this.PixelShader == null)
				this.PixelShader = new PixelShaderStage(IntPtr.Zero);
			this.PixelShader.NativePointer = this.NativePointer;
			if (this.InputAssembler == null)
				this.InputAssembler = new InputAssemblerStage(IntPtr.Zero);
			this.InputAssembler.NativePointer = this.NativePointer;
			if (this.GeometryShader == null)
				this.GeometryShader = new GeometryShaderStage(IntPtr.Zero);
			this.GeometryShader.NativePointer = this.NativePointer;
			if (this.OutputMerger == null)
				this.OutputMerger = new OutputMergerStage(IntPtr.Zero);
			this.OutputMerger.NativePointer = this.NativePointer;
			if (this.StreamOutput == null)
				this.StreamOutput = new StreamOutputStage(IntPtr.Zero);
			this.StreamOutput.NativePointer = this.NativePointer;
			if (this.Rasterizer == null)
				this.Rasterizer = new RasterizerStage(IntPtr.Zero);
			this.Rasterizer.NativePointer = this.NativePointer;
			if (this.HullShader == null)
				this.HullShader = new HullShaderStage(IntPtr.Zero);
			this.HullShader.NativePointer = this.NativePointer;
			if (this.DomainShader == null)
				this.DomainShader = new DomainShaderStage(IntPtr.Zero);
			this.DomainShader.NativePointer = this.NativePointer;
			if (this.ComputeShader == null)
				this.ComputeShader = new ComputeShaderStage(IntPtr.Zero);
			this.ComputeShader.NativePointer = this.NativePointer;
		}

		public VertexShaderStage VertexShader { get; [param: In] private set; }

		public PixelShaderStage PixelShader { get; [param: In] private set; }

		public InputAssemblerStage InputAssembler { get; [param: In] private set; }

		public GeometryShaderStage GeometryShader { get; [param: In] private set; }

		public OutputMergerStage OutputMerger { get; [param: In] private set; }

		public StreamOutputStage StreamOutput { get; [param: In] private set; }

		public RasterizerStage Rasterizer { get; [param: In] private set; }

		public HullShaderStage HullShader { get; [param: In] private set; }

		public DomainShaderStage DomainShader { get; [param: In] private set; }

		public ComputeShaderStage ComputeShader { get; [param: In] private set; }

		internal unsafe Result MapSubresource([In] Resource obj0, [In] int obj1, [In] MapMode obj2, [In] MapFlags obj3, out DataBox _param5)
		{
			IntPtr zero = CppObject.ToCallbackPtr<Resource>(obj0);
			_param5 = default;
			Result result;
			fixed (DataBox* ptr = &_param5)
			{
				void* ptr2 = ptr;
				void* nativePointer = _nativePointer;
				void* intPtr = (void*)zero;
				result = ((delegate* unmanaged[Stdcall]<void*, void*, int, int, int, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)14 * (nint)sizeof(void*))))(nativePointer, intPtr, obj1, (int)obj2, (int)obj3, ptr2);
			}

			return result;
		}

		public unsafe void UnmapSubresource([In] Resource obj0, [In] int obj1)
		{
			IntPtr zero = CppObject.ToCallbackPtr<Resource>(obj0);
			void* nativePointer = _nativePointer;
			void* intPtr = (void*)zero;
			((delegate* unmanaged[Stdcall]<void*, void*, int, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)15 * (nint)sizeof(void*))))(nativePointer, intPtr, obj1);
		}

		internal unsafe void CopyResource_(Resource dstResourceRef, Resource srcResourceRef)
		{
			IntPtr zero = CppObject.ToCallbackPtr<Resource>(dstResourceRef);
			IntPtr zero2 = CppObject.ToCallbackPtr<Resource>(srcResourceRef);
			void* nativePointer = _nativePointer;
			void* intPtr = (void*)zero;
			void* intPtr2 = (void*)zero2;
			((delegate* unmanaged[Stdcall]<void*, void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)47 * (nint)sizeof(void*))))(nativePointer, intPtr, intPtr2);
		}
	}
}
