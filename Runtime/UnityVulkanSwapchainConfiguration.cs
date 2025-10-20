using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UnityVulkanSwapchainConfiguration
    {
        public UnityVulkanSwapchainMode mode;
    }
}
