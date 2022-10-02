using System;
using System.Runtime.Serialization;

namespace DesktopDuplication
{
	[Serializable]
	public class DesktopDuplicationException : Exception
	{
		public ExceptionType exception { get; set; }

		protected DesktopDuplicationException(SerializationInfo info, StreamingContext context)
			: base(info, context) { }

		public DesktopDuplicationException(ExceptionType type, Exception innerException)
			: base(type.ToString(), innerException) => exception = type;
	}

	public enum ExceptionType
	{
		ADAPTER_NOT_FOUND,
		OUTPUT_NOT_FOUND,
		MAXIMUM_REACHED,
		RELEASE_FAILED
	}
}
