using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UnityVulkanPluginEventConfig
    {
        public UnityVulkanEventRenderPassPreCondition renderPassPrecondition;
        public UnityVulkanGraphicsQueueAccess graphicsQueueAccess;
        public uint flags;
    }
}
