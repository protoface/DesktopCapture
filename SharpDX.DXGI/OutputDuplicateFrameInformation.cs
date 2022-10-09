// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.OutputDuplicateFrameInformation
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

using SharpDX.Mathematics.Interop;

namespace SharpDX.DXGI
{
	public struct OutputDuplicateFrameInformation
	{
		public long LastPresentTime;
		public long LastMouseUpdateTime;
		public int AccumulatedFrames;
		public RawBool RectsCoalesced;
		public RawBool ProtectedContentMaskedOut;
		public OutputDuplicatePointerPosition PointerPosition;
		public int TotalMetadataBufferSize;
		public int PointerShapeBufferSize;
	}
}
