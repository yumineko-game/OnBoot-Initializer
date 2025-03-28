#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Yumineko.InitializeOnBoot.Editor
{
    public class OnBootInitializerSettingsWindow : EditorWindow
    {
        private const string MenuPath = "Tools/Yumineko/OnBoot Initializer";
        private const string EnableKey = "Yumineko.OnBootInitializer.Enable";
        private static bool _isEnabled;

        [MenuItem(MenuPath)]
        private static void ShowWindow()
        {
            var window = GetWindow<OnBootInitializerSettingsWindow>("OnBoot Initializer");
            window.Show();
        }

        private void OnEnable()
        {
            _isEnabled = EditorUserSettings.GetConfigValue(EnableKey) != "false";
        }

        private void OnGUI()
        {
            EditorGUILayout.Space(10);
            using (new EditorGUILayout.VerticalScope(EditorStyles.helpBox))
            {
                EditorGUILayout.LabelField("OnBoot Initializer Settings", EditorStyles.boldLabel);
                EditorGUILayout.Space(5);

                using (var check = new EditorGUI.ChangeCheckScope())
                {
                    _isEnabled = EditorGUILayout.Toggle("Enable OnBoot Initializer", _isEnabled);

                    if (check.changed)
                    {
                        EditorUserSettings.SetConfigValue(EnableKey, _isEnabled.ToString().ToLower());
                    }
                }

                EditorGUILayout.Space(5);
                EditorGUILayout.HelpBox("このオプションを有効にすると、プレイモード開始時に自動的にブートシーン（ビルドインデックス0）をロードして初期化します。", MessageType.Info);
            }
        }

        internal static bool IsEnabled() => EditorUserSettings.GetConfigValue(EnableKey) == "true";
    }
}
#endif