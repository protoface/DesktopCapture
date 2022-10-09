// Decompiled with JetBrains decompiler
// Type: SharpDX.Direct3D11.ResourceOptionFlags
// Assembly: SharpDX.Direct3D11, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: B224494F-92AB-4C77-B008-46E73F551FD0
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.Direct3D11.dll

using System;

namespace SharpDX.Direct3D11
{
	[Flags]
	public enum ResourceOptionFlags
	{
		GenerateMipMaps = 1,
		Shared = 2,
		TextureCube = 4,
		DrawIndirectArguments = 16, // 0x00000010
		BufferAllowRawViews = 32, // 0x00000020
		BufferStructured = 64, // 0x00000040
		ResourceClamp = 128, // 0x00000080
		SharedKeyedmutex = 256, // 0x00000100
		GdiCompatible = 512, // 0x00000200
		SharedNthandle = 2048, // 0x00000800
		RestrictedContent = 4096, // 0x00001000
		RestrictSharedResource = 8192, // 0x00002000
		RestrictSharedResourceDriver = 16384, // 0x00004000
		Guarded = 32768, // 0x00008000
		TilePool = 131072, // 0x00020000
		Tiled = 262144, // 0x00040000
		HwProtected = 524288, // 0x00080000
		None = 0,
	}
}
