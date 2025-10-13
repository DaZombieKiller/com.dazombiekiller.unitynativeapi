using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace UnityEngine.NativeAPI
{
    // IUnityGraphicsD3D12v7

    [Guid("4624B0DA-41B6-4AAC-915A-ABCB9BC3F0D3")]
    public unsafe struct IUnityGraphicsD3D12 : IUnityInterface
    {
        public delegate* unmanaged[Stdcall]<ID3D12Device*> GetDevice;
        public delegate* unmanaged[Stdcall]<IDXGISwapChain*> GetSwapChain;
        public delegate* unmanaged[Stdcall]<uint> GetSyncInterval;
        public delegate* unmanaged[Stdcall]<uint> GetPresentFlags;
        public delegate* unmanaged[Stdcall]<ID3D12Fence*> GetFrameFence;
        public delegate* unmanaged[Stdcall]<ulong> GetNextFrameFenceValue;
        public delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList*, int, UnityGraphicsD3D12ResourceState*, ulong> ExecuteCommandList;
        public delegate* unmanaged[Stdcall]<UnityGraphicsD3D12PhysicalVideoMemoryControlValues*, void> SetPhysicalVideoMemoryControlValues;
        public delegate* unmanaged[Stdcall]<ID3D12CommandQueue*> GetCommandQueue;
        public delegate* unmanaged[Stdcall]<UnityRenderBuffer*, ID3D12Resource*> TextureFromRenderBuffer;
        public delegate* unmanaged[Stdcall]<uint, ID3D12Resource*> TextureFromNativeTexture;
        public delegate* unmanaged[Stdcall]<int, UnityD3D12PluginEventConfig*, void> ConfigureEvent;
        public delegate* unmanaged[Stdcall]<UnityGraphicsD3D12RecordingState*, byte> CommandRecordingState;

        readonly void IUnityInterface.InternalImplementationOnly()
        {
        }
    }
}
