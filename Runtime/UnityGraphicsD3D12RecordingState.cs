using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UnityGraphicsD3D12RecordingState
    {
        /// <summary>D3D12 command list that is currently recorded by Unity</summary>
        public ID3D12GraphicsCommandList* commandList;
    }
}
