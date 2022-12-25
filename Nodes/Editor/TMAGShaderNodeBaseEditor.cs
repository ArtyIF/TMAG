using UnityEditor;
using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(TMAGComputeShaderNodeBase))]
public class TMAGComputeShaderNodeBaseEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        base.OnBodyGUI();
        TMAGComputeShaderNodeBase node = target as TMAGComputeShaderNodeBase;

        if (!node.hidePreview)
        {
            Rect rect = GUILayoutUtility.GetAspectRect(1, GUILayout.ExpandWidth(true));
            RenderTexture nodeValue = node.GetValue(node.GetOutputPort("output")) as RenderTexture;
            if (nodeValue) {
                EditorGUI.DrawPreviewTexture(rect, nodeValue);
            } else {
                GUIStyle errorStyle = new(EditorStyles.label)
                {
                    alignment = TextAnchor.MiddleCenter,
                    fontStyle = FontStyle.Bold,
                    fontSize = 18
                };

                EditorGUI.DrawRect(rect, Color.black);
                EditorGUI.LabelField(rect, "Missing value!", errorStyle);
            }
            if (GUILayout.Button("Hide Preview", GUILayout.ExpandWidth(true)))
            {
                node.hidePreview = true;
            }
        }
        else
        {
            if (GUILayout.Button("Show Preview", GUILayout.ExpandWidth(true)))
            {
                node.hidePreview = false;
            }
        }
    }
}