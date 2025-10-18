namespace UnityEngine.NativeAPI
{
    public enum UnityVulkanEventRenderPassPreCondition
    {
        /// <summary>Don't care about the state on Unity's current command buffer</summary>
        /// <remarks>This is the default precondition</remarks>
        kUnityVulkanRenderPass_DontCare,

        /// <summary>Make sure that there is currently RenderPass in progress.</summary>
        /// <remarks>
        /// There are no guarantees about the currently bound descriptor sets, vertex buffers, index buffers and pipeline objects
        /// Unity does however set dynamic pipeline set VK_DYNAMIC_STATE_VIEWPORT, VK_DYNAMIC_STATE_SCISSOR based on the current settings
        /// If used in combination with the SRP RenderPass API the resuls is undefined
        /// </remarks>
        kUnityVulkanRenderPass_EnsureInside,

        /// <summary>Make sure that there is currently no RenderPass in progress.</summary>
        /// <remarks>
        /// This allows e.g. resource uploads.
        /// Ends the current render pass (and resumes it afterwards if needed)
        /// If used in combination with the SRP RenderPass API the resuls is undefined.
        /// </remarks>
        kUnityVulkanRenderPass_EnsureOutside
    }
}
