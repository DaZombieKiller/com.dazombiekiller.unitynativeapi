namespace UnityEngine.NativeAPI
{
    public enum UnityGfxRenderer
    {
        /// <summary>Direct3D 11</summary>
        kUnityGfxRendererD3D11 = 2,

        /// <summary>"null" device (used in batch mode)</summary>
        kUnityGfxRendererNull = 4,

        /// <summary>OpenGL ES 2.0</summary>
        kUnityGfxRendererOpenGLES20 = 8,

        /// <summary>OpenGL ES 3.0</summary>
        kUnityGfxRendererOpenGLES30 = 11,

        /// <summary>PlayStation 4</summary>
        kUnityGfxRendererPS4 = 13,

        /// <summary>Xbox One</summary>
        kUnityGfxRendererXboxOne = 14,

        /// <summary>iOS Metal</summary>
        kUnityGfxRendererMetal = 16,

        /// <summary>OpenGL core</summary>
        kUnityGfxRendererOpenGLCore = 17,

        /// <summary>Direct3D 12</summary>
        kUnityGfxRendererD3D12 = 18,

        /// <summary>Vulkan</summary>
        kUnityGfxRendererVulkan = 21,

        /// <summary>Nintendo Switch NVN API</summary>
        kUnityGfxRendererNvn = 22,

        /// <summary>MS XboxOne Direct3D 12</summary>
        kUnityGfxRendererXboxOneD3D12 = 23,

        /// <summary>GameCore Xbox One</summary>
        kUnityGfxRendererGameCoreXboxOne = 24,

        /// <summary>GameCore XboxSeries</summary>
        kUnityGfxRendererGameCoreXboxSeries = 25,

        /// <summary>PS5</summary>
        kUnityGfxRendererPS5 = 26,

        /// <summary>PS5 NGGC</summary>
        kUnityGfxRendererPS5NGGC = 27,
    }
}
