using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Vulkan;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UnityVulkanBuffer
    {
        public UnityVulkanMemory memory;
        public VkBuffer buffer;
        public UIntPtr sizeInBytes;
        public VkBufferUsageFlags usage;
        public void* reserved0;
        public void* reserved1;
        public void* reserved2;
        public void* reserved3;
    }
}
