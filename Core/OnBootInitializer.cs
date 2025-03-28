#if UNITY_EDITOR
using Yumineko.InitializeOnBoot.Editor;
#endif

using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yumineko.InitializeOnBoot
{
    public static class OnBootInitializer
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void InitializeOnLoad()
        {
            Debug.Log("Initializing OnBoot Initializer");
#if UNITY_EDITOR
            if (!OnBootInitializerEditorHelper.IsEnabled()) return;
#endif
            LoadBootScene().Forget();
        }

        private static async UniTask LoadBootScene()
        {
            await SceneManager.LoadSceneAsync(0);
        }
    }
}

#if UNITY_EDITOR
namespace Yumineko.InitializeOnBoot.Editor
{
    public static class OnBootInitializerEditorHelper
    {
        public static bool IsEnabled()
        {
            return OnBootInitializerSettingsWindow.IsEnabled();
            
        }
    }
}
#endif