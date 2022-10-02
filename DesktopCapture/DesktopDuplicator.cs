using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpDX.Mathematics.Interop;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using Device = SharpDX.Direct3D11.Device;
using Rectangle = System.Drawing.Rectangle;
using Resource = SharpDX.DXGI.Resource;

namespace DesktopDuplication
{

	/// <summary>
	/// Provides access to frame-by-frame updates of a particular desktop (i.e. one monitor), with image and cursor information.
	/// </summary>
	public class DesktopDuplicator
	{
		private readonly Device mDevice;
		private readonly OutputDuplication mDeskDupl;

		private readonly Texture2D desktopImageTexture = null;
		private readonly int width, height, pitch;
		readonly Bitmap backBuffer, halfBackBuffer;
		Rectangle boundsRect, halfBoundsRect;


		public DesktopDuplicator(int graphicsCard = 0, int outputFromGraphicsCard = 0)
		{
			Adapter1 adapter;
			try
			{
				adapter = new Factory1().GetAdapter1(graphicsCard);
			}
			catch (SharpDXException ex)
			{
				throw new DesktopDuplicationException(ExceptionType.ADAPTER_NOT_FOUND, ex);
			}
			mDevice = new Device(adapter);
			Output output;
			try
			{
				output = adapter.GetOutput(outputFromGraphicsCard);
			}
			catch (SharpDXException ex)
			{
				throw new DesktopDuplicationException(ExceptionType.OUTPUT_NOT_FOUND, ex);
			}
			var output1 = output.QueryInterface<Output1>();
			var mOutputDesc = output.Description;

			Texture2DDescription mTextureDesc = new()
			{
				CpuAccessFlags = CpuAccessFlags.Read,
				BindFlags = BindFlags.None,
				Format = Format.B8G8R8A8_UNorm,
				Width = GetWidth(mOutputDesc.DesktopBounds),
				Height = GetHeight(mOutputDesc.DesktopBounds),
				OptionFlags = ResourceOptionFlags.None,
				MipLevels = 1,
				ArraySize = 1,
				SampleDescription = { Count = 1, Quality = 0 },
				Usage = ResourceUsage.Staging
			};

			try
			{
				mDeskDupl = output1.DuplicateOutput(mDevice);
			}
			catch (SharpDXException ex)
			{
				if (ex.ResultCode.Code == SharpDX.DXGI.ResultCode.NotCurrentlyAvailable.Result.Code)
				{
					throw new DesktopDuplicationException(ExceptionType.MAXIMUM_REACHED, ex);
				}
			}

			desktopImageTexture = new Texture2D(mDevice, mTextureDesc);
			height = GetHeight(mOutputDesc.DesktopBounds);
			width = GetWidth(mOutputDesc.DesktopBounds);
			pitch = GetWidth(mOutputDesc.DesktopBounds);
			boundsRect = new(0, 0, width, height);
			halfBoundsRect = new(0, 0, width / 2, height / 2);
			backBuffer = new(width, height, PixelFormat.Format32bppRgb);
			halfBackBuffer = new(width / 2, height / 2, PixelFormat.Format32bppRgb);

			// First frame is blank - we catch it here and force JIT to run
			_ = GetLatestFrameHalfRes(out _);
		}

		static int GetHeight(RawRectangle rect) => rect.Bottom - rect.Top;
		static int GetWidth(RawRectangle rect) => rect.Right - rect.Left;

		/// <param name="isNew">Indicates wether the returned frame is fresh</param>
		/// <returns>The latest available frame in full resolution</returns>
		public Bitmap GetLatestFrame(out bool isNew)
		{
			isNew = !RetrieveFrame();
			if (isNew)
			{
				ProcessFrame();
				ReleaseFrame();
			}
			return backBuffer;
		}

		/// <param name="isNew">Indicates wether the returned frame is fresh</param>
		/// <returns>The latest available frame in half resolution</returns>
		public Bitmap GetLatestFrameHalfRes(out bool isNew)
		{
			isNew = !RetrieveFrame();
			if (isNew)
			{
				ProcessFrameHalfRes();
				ReleaseFrame();
			}
			return halfBackBuffer;
		}

		private bool RetrieveFrame()
		{
			Resource desktopResource;
			try
			{
				_ = mDeskDupl.TryAcquireNextFrame(0, out _, out desktopResource);
			}
			catch
			{
				return true;
			}
			if (desktopResource == null)
				return true;
			using (var tempTexture = desktopResource.QueryInterface<Texture2D>())
				mDevice.ImmediateContext.CopyResource(tempTexture, desktopImageTexture);
			desktopResource.Dispose();
			return false;
		}

		private void ProcessFrame()
		{
			var mapSource = mDevice.ImmediateContext.MapSubresource(desktopImageTexture, 0, MapMode.Read, SharpDX.Direct3D11.MapFlags.None);
			var mapDest = backBuffer.LockBits(boundsRect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
			unsafe
			{
				int* sourcePtr = (int*)mapSource.DataPointer.ToPointer();
				int* destPtr = (int*)mapDest.Scan0.ToPointer();
				_ = Parallel.For(0, height, (y) =>
				{
					int h = y * width, p = y * pitch;
					for (int i = 0; i < width; i++)
					{

						destPtr[h + i] = sourcePtr[p + i];
					}
				});
			}
			backBuffer.UnlockBits(mapDest);
			mDevice.ImmediateContext.UnmapSubresource(desktopImageTexture, 0);
		}

		private void ProcessFrameHalfRes()
		{
			var mapSource = mDevice.ImmediateContext.MapSubresource(desktopImageTexture, 0, MapMode.Read, SharpDX.Direct3D11.MapFlags.None);
			var mapDest = halfBackBuffer.LockBits(halfBoundsRect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
			int _width = width / 2;
			int _p = pitch * 2;
			unsafe
			{
				int* sourcePtr = (int*)mapSource.DataPointer.ToPointer();
				int* destPtr = (int*)mapDest.Scan0.ToPointer();
				_ = Parallel.For(0, height / 2, (y) =>
				{
					int h = y * _width, p = y * _p;
					for (int i = 0; i < _width; i++)
					{
						destPtr[h + i] = sourcePtr[p + (i * 2)];
					}
				});
			}
			halfBackBuffer.UnlockBits(mapDest);
			mDevice.ImmediateContext.UnmapSubresource(desktopImageTexture, 0);
		}

		private void ReleaseFrame()
		{
			try
			{
				mDeskDupl.ReleaseFrame();
			}
			catch (SharpDXException ex)
			{
				throw new DesktopDuplicationException(ExceptionType.RELEASE_FAILED, ex);
			}
		}

	}
}