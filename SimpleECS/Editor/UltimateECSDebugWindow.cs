using SimpleECS.Internal;
using UnityEditor;
using UnityEngine;

namespace SimpleECS.Example.Editor
{
    public class UltimateECSDebugWindow : EditorWindow
    {
        [MenuItem("Window/UltimateECS/Debug")]
        private static void ShowWindow()
        {
            var window = GetWindow<UltimateECSDebugWindow>();
            window.titleContent = new GUIContent("Ultimate ECS Debug");
            window.Show();
        }

        private Vector2 pos;

        private void OnGUI()
        {
            if (!Application.isPlaying)
            {
                GUILayout.Label("Game Paused~");   
                return;
            }
            World[] worlds = World.GetAll();
            foreach (var world in worlds)
            {
                GUILayout.Label($"Entity Free:{Entities.Free.Count}");
                pos = EditorGUILayout.BeginScrollView(pos);
                GUILayout.Label($"World:{world.Name},Entity Count:{world.EntityCount}");
                var entities = world.GetEntities();
                foreach (var entity in entities)
                {
                    GUILayout.Box($"--------{entity.Get<string>()}:{entity.index}----------");

                    ref var info = ref Entities.All[entity.index];
                    var componentCount = info.arch_info.component_count;
                    ref var componentBuffers = ref info.arch_info.component_buffers;
                    var infoArchIndex = info.arch_index;

                    for (int i = 0; i < componentCount; i++)
                    {
                        var component = componentBuffers[i].buffer.array[infoArchIndex];
                        if (component is string)
                        {
                            continue;
                        }

                        if (component != null)
                        {
                            GUILayout.Label($"{component.GetType().Name}:{component}");
                        }
                        else
                        {
                            GUILayout.Label($"NULL");
                        }
                    }
                }

                EditorGUILayout.EndScrollView();
            }

            this.Repaint();
        }
    }
}