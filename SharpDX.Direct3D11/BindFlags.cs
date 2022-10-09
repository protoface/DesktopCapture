// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.BindFlags
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;

namespace SharpDX.Direct3D11
{
	[Flags]
	public enum BindFlags
	{
		VertexBuffer = 1,
		IndexBuffer = 2,
		ConstantBuffer = 4,
		ShaderResource = 8,
		StreamOutput = 16, // 0x00000010
		RenderTarget = 32, // 0x00000020
		DepthStencil = 64, // 0x00000040
		UnorderedAccess = 128, // 0x00000080
		Decoder = 512, // 0x00000200
		VideoEncoder = 1024, // 0x00000400
		None = 0,
	}
}
