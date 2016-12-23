using System;
using System.Runtime.InteropServices;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Get the current video scaling factor.
    /// </summary>
    [LibVlcFunction("libvlc_video_get_scale")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate float GetVideoScale(IntPtr mediaPlayerInstance);
}
