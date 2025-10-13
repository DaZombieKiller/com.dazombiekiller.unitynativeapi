namespace UnityEngine.NativeAPI
{
    public enum UnityD3D12GraphicsQueueAccess
    {
        /// <summary>No queue acccess, no work must be submitted to UnityD3D12Instance::graphicsQueue from the plugin event callback</summary>
        kUnityD3D12GraphicsQueueAccess_DontCare,

        /// <summary>
        /// Make sure that Unity worker threads don't access the D3D12 graphics queue
        /// This disables access to the current Unity command buffer
        /// </summary>
        kUnityD3D12GraphicsQueueAccess_Allow,
    }
}
