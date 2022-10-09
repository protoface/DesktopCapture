// Decompiled with JetBrains decompiler
// Type: SharpDX.DXGI.ResultCode
// Assembly: SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1
// MVID: 172D0041-6F49-4556-B490-B47FBBA34A0B
// Assembly location: C:\Users\felix\source\repos\PcPlaner3.0\PcPlaner_Server\bin\Release\net7.0-windows\win-x64\publish\SharpDX.DXGI.dll

namespace SharpDX.DXGI
{
	public static class ResultCode
	{
		public static readonly ResultDescriptor InvalidCall = new(-2005270527, "SharpDX.DXGI", "DXGI_ERROR_INVALID_CALL", nameof(InvalidCall));
		public static readonly ResultDescriptor NotFound = new(-2005270526, "SharpDX.DXGI", "DXGI_ERROR_NOT_FOUND", nameof(NotFound));
		public static readonly ResultDescriptor MoreData = new(-2005270525, "SharpDX.DXGI", "DXGI_ERROR_MORE_DATA", nameof(MoreData));
		public static readonly ResultDescriptor Unsupported = new(-2005270524, "SharpDX.DXGI", "DXGI_ERROR_UNSUPPORTED", nameof(Unsupported));
		public static readonly ResultDescriptor DeviceRemoved = new(-2005270523, "SharpDX.DXGI", "DXGI_ERROR_DEVICE_REMOVED", nameof(DeviceRemoved));
		public static readonly ResultDescriptor DeviceHung = new(-2005270522, "SharpDX.DXGI", "DXGI_ERROR_DEVICE_HUNG", nameof(DeviceHung));
		public static readonly ResultDescriptor DeviceReset = new(-2005270521, "SharpDX.DXGI", "DXGI_ERROR_DEVICE_RESET", nameof(DeviceReset));
		public static readonly ResultDescriptor WasStillDrawing = new(-2005270518, "SharpDX.DXGI", "DXGI_ERROR_WAS_STILL_DRAWING", nameof(WasStillDrawing));
		public static readonly ResultDescriptor FrameStatisticsDisjoint = new(-2005270517, "SharpDX.DXGI", "DXGI_ERROR_FRAME_STATISTICS_DISJOINT", nameof(FrameStatisticsDisjoint));
		public static readonly ResultDescriptor GraphicsVidpnSourceInUse = new(-2005270516, "SharpDX.DXGI", "DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE", nameof(GraphicsVidpnSourceInUse));
		public static readonly ResultDescriptor DriverInternalError = new(-2005270496, "SharpDX.DXGI", "DXGI_ERROR_DRIVER_INTERNAL_ERROR", nameof(DriverInternalError));
		public static readonly ResultDescriptor Nonexclusive = new(-2005270495, "SharpDX.DXGI", "DXGI_ERROR_NONEXCLUSIVE", nameof(Nonexclusive));
		public static readonly ResultDescriptor NotCurrentlyAvailable = new(-2005270494, "SharpDX.DXGI", "DXGI_ERROR_NOT_CURRENTLY_AVAILABLE", nameof(NotCurrentlyAvailable));
		public static readonly ResultDescriptor RemoteClientDisconnected = new(-2005270493, "SharpDX.DXGI", "DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED", nameof(RemoteClientDisconnected));
		public static readonly ResultDescriptor RemoteOufOfMemory = new(-2005270492, "SharpDX.DXGI", "DXGI_ERROR_REMOTE_OUTOFMEMORY", nameof(RemoteOufOfMemory));
		public static readonly ResultDescriptor AccessLost = new(-2005270490, "SharpDX.DXGI", "DXGI_ERROR_ACCESS_LOST", nameof(AccessLost));
		public static readonly ResultDescriptor WaitTimeout = new(-2005270489, "SharpDX.DXGI", "DXGI_ERROR_WAIT_TIMEOUT", nameof(WaitTimeout));
		public static readonly ResultDescriptor SessionDisconnected = new(-2005270488, "SharpDX.DXGI", "DXGI_ERROR_SESSION_DISCONNECTED", nameof(SessionDisconnected));
		public static readonly ResultDescriptor RestrictToOutputStale = new(-2005270487, "SharpDX.DXGI", "DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE", nameof(RestrictToOutputStale));
		public static readonly ResultDescriptor CannotProtectContent = new(-2005270486, "SharpDX.DXGI", "DXGI_ERROR_CANNOT_PROTECT_CONTENT", nameof(CannotProtectContent));
		public static readonly ResultDescriptor AccessDenied = new(-2005270485, "SharpDX.DXGI", "DXGI_ERROR_ACCESS_DENIED", nameof(AccessDenied));
		public static readonly ResultDescriptor NameAlreadyExists = new(-2005270484, "SharpDX.DXGI", "DXGI_ERROR_NAME_ALREADY_EXISTS", nameof(NameAlreadyExists));
		public static readonly ResultDescriptor SdkComponentMissing = new(-2005270483, "SharpDX.DXGI", "DXGI_ERROR_SDK_COMPONENT_MISSING", nameof(SdkComponentMissing));
		public static readonly ResultDescriptor NotCurrent = new(-2005270482, "SharpDX.DXGI", "DXGI_ERROR_NOT_CURRENT", nameof(NotCurrent));
		public static readonly ResultDescriptor HwProtectionOufOfMemory = new(-2005270480, "SharpDX.DXGI", "DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY", nameof(HwProtectionOufOfMemory));
		public static readonly ResultDescriptor DynamicCodePolicyViolation = new(-2005270479, "SharpDX.DXGI", "DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION", nameof(DynamicCodePolicyViolation));
		public static readonly ResultDescriptor NonCompositedUi = new(-2005270478, "SharpDX.DXGI", "DXGI_ERROR_NON_COMPOSITED_UI", nameof(NonCompositedUi));
		public static readonly ResultDescriptor ModeChangeInProgress = new(-2005270491, "SharpDX.DXGI", "DXGI_ERROR_MODE_CHANGE_IN_PROGRESS", nameof(ModeChangeInProgress));
		public static readonly ResultDescriptor CacheCorrupt = new(-2005270477, "SharpDX.DXGI", "DXGI_ERROR_CACHE_CORRUPT", nameof(CacheCorrupt));
		public static readonly ResultDescriptor CacheFull = new(-2005270476, "SharpDX.DXGI", "DXGI_ERROR_CACHE_FULL", nameof(CacheFull));
		public static readonly ResultDescriptor CacheHashCollision = new(-2005270475, "SharpDX.DXGI", "DXGI_ERROR_CACHE_HASH_COLLISION", nameof(CacheHashCollision));
		public static readonly ResultDescriptor AlreadyExists = new(-2005270474, "SharpDX.DXGI", "DXGI_ERROR_ALREADY_EXISTS", nameof(AlreadyExists));
	}
}
