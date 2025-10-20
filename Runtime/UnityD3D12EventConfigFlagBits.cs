using System;

namespace UnityEngine.NativeAPI
{
    [Flags]
    public enum UnityD3D12EventConfigFlagBits
    {
    #pragma warning disable CA1707 // Identifiers should not contain underscores
        /// <summary>default: (NOT SUPPORTED)</summary>
        kUnityD3D12EventConfigFlag_EnsurePreviousFrameSubmission = 1 << 0,

        /// <summary>submit existing command buffers, default: not set</summary>
        kUnityD3D12EventConfigFlag_FlushCommandBuffers = 1 << 1,

        /// <summary>wait for worker threads to finish, default: not set</summary>
        kUnityD3D12EventConfigFlag_SyncWorkerThreads = 1 << 2,

        /// <summary>should be set when descriptor set bindings, vertex buffer bindings, etc are changed (default: set)</summary>
        kUnityD3D12EventConfigFlag_ModifiesCommandBuffersState = 1 << 3,
    #pragma warning restore CA1707 // Identifiers should not contain underscores
    }
}
