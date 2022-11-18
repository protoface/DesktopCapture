# DesktopCapture

![Nuget](https://img.shields.io/nuget/dt/protoface.DesktopCapture)
![Nuget](https://img.shields.io/nuget/v/protoface.DesktopCapture)

A easy-to-use library to efficiently record a screen (Windows-only)

# Usage

```cs

using System.Drawing;
using DesktopCapture;

DesktopDuplicator dd = new();

Bitmap bmp = dd.GetLatestFrame(out bool isNew);


```

# Documentation

| Constructor | Description |
|-------------|-------------|
| new DesktopDuplicator() | Uses the primary screen as the capture-source |
| new DesktopDuplicator(int graphicsCard) | Uses the first output coming from that GPU |
| new DesktopDuplicator(int output) | Uses the nth output from the first GPU |
| new DesktopDuplicator(int graphicsCard, int output) | Uses the nth output from the nth GPU |

| Method | returns | Description |
|--------|---------|-------------|
| GetLatestFrame | Bitmap / bool | Retrieves the latest frame in full resolution and indicates wether the frame has been retrieved before
| GetLatestFrameHalfRes | Bitmap / bool | Retrieves the latest frame in full resolution and indicates wether the frame has been retrieved before
