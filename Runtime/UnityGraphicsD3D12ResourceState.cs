using TerraFX.Interop.DirectX;

namespace UnityEngine.NativeAPI
{
    public unsafe struct UnityGraphicsD3D12ResourceState
    {
        /// <summary>Resource to barrier.</summary>
        public ID3D12Resource* resource;

        /// <summary>Expected resource state before this command list is executed.</summary>
        public D3D12_RESOURCE_STATES expected;

        /// <summary>State this resource will be in after this command list is executed.</summary>
        public D3D12_RESOURCE_STATES current;
    }
}
