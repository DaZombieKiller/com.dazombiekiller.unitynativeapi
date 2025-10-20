using System.Runtime.InteropServices;
using TerraFX.Interop.Vulkan;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UnityVulkanImage
    {
        public UnityVulkanMemory memory;
        public VkImage image;
        public VkImageLayout layout;
        public VkImageAspectFlags aspect;
        public VkImageUsageFlags usage;
        public VkFormat format;
        public VkExtent3D extent;
        public VkImageTiling tiling;
        public VkImageType type;
        public VkSampleCountFlags samples;
        public int layers;
        public int mipCount;
        public void* reserved0;
        public void* reserved1;
        public void* reserved2;
        public void* reserved3;
    }
}
