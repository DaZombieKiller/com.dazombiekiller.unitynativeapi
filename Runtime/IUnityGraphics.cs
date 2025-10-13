using System;
using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    [Guid("7CBA0A9C-A4DD-B544-8C5A-D4926EB17B11")]
    public unsafe struct IUnityGraphics : IUnityInterface
    {
        public delegate* unmanaged[Stdcall]<UnityGfxRenderer> GetRenderer;
        public delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<UnityGfxDeviceEventType, void>, void> RegisterDeviceEventCallback;
        public delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<UnityGfxDeviceEventType, void>, void> UnregisterDeviceEventCallback;
        public delegate* unmanaged[Stdcall]<int, int> ReserveEventIDRange;

        readonly void IUnityInterface.InternalImplementationOnly()
        {
        }
    }
}
