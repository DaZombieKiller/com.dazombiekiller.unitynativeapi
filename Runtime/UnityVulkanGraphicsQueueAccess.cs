namespace UnityEngine.NativeAPI
{
    public enum UnityVulkanGraphicsQueueAccess
    {
    #pragma warning disable CA1707 // Identifiers should not contain underscores
        /// <summary>No queue acccess, no work must be submitted to UnityVulkanInstance::graphicsQueue from the plugin event callback</summary>
        kUnityVulkanGraphicsQueueAccess_DontCare,

        /// <summary>Make sure that Unity worker threads don't access the Vulkan graphics queue</summary>
        /// <remarks>This disables access to the current Unity command buffer</remarks>
        kUnityVulkanGraphicsQueueAccess_Allow,
    #pragma warning restore CA1707 // Identifiers should not contain underscores
    }
}
