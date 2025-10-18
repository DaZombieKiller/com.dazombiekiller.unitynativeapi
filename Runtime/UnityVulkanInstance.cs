using TerraFX.Interop.Vulkan;

namespace UnityEngine.NativeAPI
{
    public unsafe struct UnityVulkanInstance
    {
        public VkPipelineCache pipelineCache;
        public VkInstance instance;
        public VkPhysicalDevice physicalDevice;
        public VkDevice device;
        public VkQueue graphicsQueue;
        public delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>> getInstanceProcAddr;
        public uint queueFamilyIndex;
        public void* reserved0;
        public void* reserved1;
        public void* reserved2;
        public void* reserved3;
        public void* reserved4;
        public void* reserved5;
        public void* reserved6;
        public void* reserved7;
    }
}
