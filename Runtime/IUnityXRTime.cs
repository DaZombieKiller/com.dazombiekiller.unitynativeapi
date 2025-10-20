using System;
using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    [StructLayout(LayoutKind.Sequential)]
    [Guid("650C79F9-6492-40B7-9F89-DF9F47DDD42F")]
    public unsafe struct IUnityXRTime : IUnityInterface
    {
        public delegate* unmanaged[Stdcall]<double, void> SetPredictedRenderTime;

        readonly void IUnityInterface.InternalImplementationOnly()
        {
        }
    }
}
