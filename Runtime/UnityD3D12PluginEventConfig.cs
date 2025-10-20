using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UnityD3D12PluginEventConfig
    {
        public UnityD3D12GraphicsQueueAccess graphicsQueueAccess;

        /// <summary>UnityD3D12EventConfigFlagBits to be used when invoking a native plugin</summary>
        public uint flags;

        /// <summary>If true, the actively bound render texture will be bound prior the execution of the native plugin method.</summary>
        public byte ensureActiveRenderTextureIsBound;
    }
}
