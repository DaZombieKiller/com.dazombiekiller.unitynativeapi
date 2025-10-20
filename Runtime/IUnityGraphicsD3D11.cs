using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    [Guid("AAB37EF8-7A87-D748-BF76-967F07EFB177")]
    public unsafe struct IUnityGraphicsD3D11 : IUnityInterface
    {
        public delegate* unmanaged[Stdcall]<ID3D11Device*> GetDevice;
        public delegate* unmanaged[Stdcall]<UnityRenderBuffer*, ID3D11Resource*> TextureFromRenderBuffer;
        public delegate* unmanaged[Stdcall]<uint, ID3D11Resource*> TextureFromNativeTexture;
        public delegate* unmanaged[Stdcall]<UnityRenderBuffer*, ID3D11RenderTargetView*> RTVFromRenderBuffer;
        public delegate* unmanaged[Stdcall]<uint, ID3D11ShaderResourceView*> SRVFromNativeTexture;
        public delegate* unmanaged[Stdcall]<IDXGISwapChain*> GetSwapChain;
        public delegate* unmanaged[Stdcall]<uint> GetSyncInterval;
        public delegate* unmanaged[Stdcall]<uint> GetPresentFlags;

        readonly void IUnityInterface.InternalImplementationOnly()
        {
        }
    }
}
