#if UNITY_EDITOR
using Aili.LightsOut.Game;
using UnityEditor;
using UnityEngine;

namespace Aili.LightsOut.CustomEditors
{
    [CustomEditor(typeof(CameraBounds))]
    internal class CameraBoundsEditor : Editor
    {
        CameraBounds cameraBounds => (CameraBounds)target;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            GUILayout.Space(5);

            if (GUILayout.Button("Match Camera Height"))
                cameraBounds.MatchCameraHeight();
        }
    }
}
#endif // UNITY_EDITOR
