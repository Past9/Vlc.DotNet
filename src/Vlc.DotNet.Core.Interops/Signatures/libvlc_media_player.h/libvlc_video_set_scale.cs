using System;
using System.Runtime.InteropServices;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    /// <summary>
    /// Set video scaling factor.
    /// </summary>
    [LibVlcFunction("libvlc_video_set_scale")]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SetVideoScale(IntPtr mediaPlayerInstance, float scale);
}
