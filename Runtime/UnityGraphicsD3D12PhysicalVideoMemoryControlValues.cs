using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    public struct UnityGraphicsD3D12PhysicalVideoMemoryControlValues
    {
        /// <summary>Minimum required physical memory for an application [default = 64MB].</summary>
        public ulong reservation;

        /// <summary>If free physical video memory drops below this threshold, resources will be allocated in system memory. [default = 64MB]</summary>
        public ulong systemMemoryThreshold;

        /// <summary>Minimum free physical video memory needed to start bringing evicted resources back after shrunken video memory budget expands again. [default = 128MB]</summary>
        public ulong residencyHysteresisThreshold;

        /// <summary>The relative proportion of the video memory budget that must be kept available for non-evictable resources. [default = 0.25]</summary>
        public float nonEvictableRelativeThreshold;
    }
}
