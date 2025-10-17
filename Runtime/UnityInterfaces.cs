using System;
using System.Buffers.Binary;
using System.Runtime.InteropServices;

namespace UnityEngine.NativeAPI
{
    public static unsafe class UnityInterfaces
    {
        [DllImport("UnityNativeAPIPlugin", EntryPoint = "GetUnityInterfaces", ExactSpelling = true)]
        private static extern IUnityInterfaces* GetUnityInterfaces();

        public static void Register(Guid guid, void* ptr)
        {
            GetUnityInterfaceGuid(guid, out var high, out var low);
            GetUnityInterfaces()->RegisterInterfaceSplit(high, low, ptr);
        }

        public static T* Get<T>()
            where T : unmanaged, IUnityInterface
        {
            GetUnityInterfaceGuid(typeof(T).GUID, out var high, out var low);
            return (T*)GetUnityInterfaces()->GetInterfaceSplit(high, low);
        }

        public static void* Get(Guid guid)
        {
            GetUnityInterfaceGuid(guid, out var high, out var low);
            return GetUnityInterfaces()->GetInterfaceSplit(high, low);
        }

        private static void GetUnityInterfaceGuid(Guid guid, out ulong high, out ulong low)
        {
            Span<byte> bytes = stackalloc byte[16];
            guid.TryWriteBytes(bytes);

            if (BitConverter.IsLittleEndian)
            {
                bytes.Slice(0, 4).Reverse();
                bytes.Slice(4, 2).Reverse();
                bytes.Slice(6, 2).Reverse();
            }

            high = BinaryPrimitives.ReadUInt64BigEndian(bytes);
            low = BinaryPrimitives.ReadUInt64BigEndian(bytes.Slice(8, 8));
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct IUnityInterfaces
        {
            public void* GetInterface;
            public void* RegisterInterface;
            public delegate* unmanaged[Stdcall]<ulong, ulong, void*> GetInterfaceSplit;
            public delegate* unmanaged[Stdcall]<ulong, ulong, void*, void> RegisterInterfaceSplit;
        }
    }
}
