using System.ComponentModel;

namespace UnityEngine.NativeAPI
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IUnityInterface
    {
        internal void InternalImplementationOnly();
    }
}
