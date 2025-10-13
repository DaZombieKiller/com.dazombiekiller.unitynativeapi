typedef void IUnityInterfaces;

static IUnityInterfaces *g_UnityInterfaces;

void __stdcall UnityPluginLoad(IUnityInterfaces *unityInterfaces)
{
    g_UnityInterfaces = unityInterfaces;
}

IUnityInterfaces *__stdcall GetUnityInterfaces()
{
    return g_UnityInterfaces;
}
