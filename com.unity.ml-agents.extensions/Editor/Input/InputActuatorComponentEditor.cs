#if MLA_INPUT_SYSTEM && UNITY_2019_4_OR_NEWER
using Unity.MLAgents.Extensions.Input;
using UnityEditor;

namespace Unity.MLAgents.Extensions.Editor.Input
{
    [CustomEditor(typeof(InputActuatorActuatorComponent))]
    internal class InputActuatorComponentEditor : UnityEditor.Editor
    {
        const string k_ActionSpecName = "m_ActionSpec";

        public override void OnInspectorGUI()
        {
            var so = serializedObject;
            so.Update();
            InputActuatorActuatorComponent o = so.targetObject as InputActuatorActuatorComponent;
            _ = o.ActionSpec;
            EditorGUI.indentLevel++;
            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.PropertyField(so.FindProperty(k_ActionSpecName));
            EditorGUI.EndDisabledGroup();
            EditorGUI.indentLevel--;
        }
    }
}
#endif // MLA_INPUT_SYSTEM && UNITY_2019_OR_NEWER
