using System.Runtime.InteropServices;
using TerraFX.Interop.Vulkan;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UnityVulkanMemory
    {
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        public void* mapped;
        public VkMemoryPropertyFlags flags;
        public uint memoryTypeIndex;
        public void* reserved0;
        public void* reserved1;
        public void* reserved2;
        public void* reserved3;
    }
}
