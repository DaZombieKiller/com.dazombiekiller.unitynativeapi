using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Vulkan;

namespace UnityEngine.NativeAPI
{
    // IUnityGraphicsVulkanV2

    [Guid("329334C0-9DCA-4787-B347-DD92A0097FFC")]
    public unsafe struct IUnityGraphicsVulkan : IUnityInterface
    {
        public delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>>, void*, delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>>>, void*, byte> InterceptInitialization;
        public delegate* unmanaged[Stdcall]<sbyte*, delegate* unmanaged[Stdcall]<void>, delegate* unmanaged[Stdcall]<void>> InterceptVulkanAPI;
        public delegate* unmanaged[Stdcall]<int, UnityVulkanPluginEventConfig*, void> ConfigureEvent;
        public delegate* unmanaged[Stdcall]<UnityVulkanInstance> Instance;
        public delegate* unmanaged[Stdcall]<UnityVulkanRecordingState*, UnityVulkanGraphicsQueueAccess, byte> CommandRecordingState;
        public delegate* unmanaged[Stdcall]<void*, VkImageSubresource*, VkImageLayout, VkPipelineStageFlags, VkAccessFlags, UnityVulkanResourceAccessMode, UnityVulkanImage*, byte> AccessTexture;
        public delegate* unmanaged[Stdcall]<UnityRenderBuffer*, VkImageSubresource*, VkImageLayout, VkPipelineStageFlags, VkAccessFlags, UnityVulkanResourceAccessMode, UnityVulkanImage*, byte> AccessRenderBufferTexture;
        public delegate* unmanaged[Stdcall]<UnityRenderBuffer*, VkImageSubresource*, VkImageLayout, VkPipelineStageFlags, VkAccessFlags, UnityVulkanResourceAccessMode, UnityVulkanImage*, byte> AccessRenderBufferResolveTexture;
        public delegate* unmanaged[Stdcall]<void*, VkPipelineStageFlags, VkAccessFlags, UnityVulkanResourceAccessMode, UnityVulkanBuffer*, byte> AccessBuffer;
        public delegate* unmanaged[Stdcall]<void> EnsureOutsideRenderPass;
        public delegate* unmanaged[Stdcall]<void> EnsureInsideRenderPass;
        public delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<int, void*, void>, int, void*, byte, void> AccessQueue;
        public delegate* unmanaged[Stdcall]<UnityVulkanSwapchainConfiguration*, byte> ConfigureSwapchain;
        public delegate* unmanaged[Stdcall]<uint, VkImageSubresource*, VkImageLayout, VkPipelineStageFlags, VkAccessFlags, UnityVulkanResourceAccessMode, UnityVulkanImage*, byte> AccessTextureByID;
        public delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>>, void*, delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>>>, void*, int, byte> AddInterceptInitialization;
        public delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>>, void*, delegate* unmanaged[Stdcall]<VkInstance, sbyte*, delegate* unmanaged[Stdcall]<void>>>, byte> RemoveInterceptInitialization;

        readonly void IUnityInterface.InternalImplementationOnly()
        {
        }
    }
}
