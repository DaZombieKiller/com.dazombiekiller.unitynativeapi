namespace UnityEngine.NativeAPI
{
    public enum UnityVulkanResourceAccessMode
    {
    #pragma warning disable CA1707 // Identifiers should not contain underscores
        /// <summary>Does not imply any pipeline barriers, should only be used to query resource attributes</summary>
        kUnityVulkanResourceAccess_ObserveOnly,

        /// <summary>Handles layout transition and barriers</summary>
        kUnityVulkanResourceAccess_PipelineBarrier,

        /// <summary>Recreates the backing resource (VkBuffer/VkImage) but keeps the previous one alive if it's in use</summary>
        kUnityVulkanResourceAccess_Recreate,
    #pragma warning restore CA1707 // Identifiers should not contain underscores
    }
}
