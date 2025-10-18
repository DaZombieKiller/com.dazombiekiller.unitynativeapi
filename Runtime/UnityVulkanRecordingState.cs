using TerraFX.Interop.Vulkan;

namespace UnityEngine.NativeAPI
{
    public unsafe struct UnityVulkanRecordingState
    {
        public VkCommandBuffer commandBuffer;
        public VkCommandBufferLevel commandBufferLevel;
        public VkRenderPass renderPass;
        public VkFramebuffer framebuffer;
        public int subPassIndex;
        public ulong currentFrameNumber;
        public ulong safeFrameNumber;
        public void* reserved0;
        public void* reserved1;
        public void* reserved2;
        public void* reserved3;
    }
}
