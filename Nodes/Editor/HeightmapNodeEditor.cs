using UnityEditor;
using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(HeightmapNode))]
public class HeightmapNodeEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        base.OnBodyGUI();
        HeightmapNode node = target as HeightmapNode;

        if (!node.hidePreview)
        {
            Rect rect = GUILayoutUtility.GetAspectRect(1, GUILayout.ExpandWidth(true));
            RenderTexture nodeValue = node.GetValue(node.GetOutputPort("output")) as RenderTexture;
            if (nodeValue)
            {
                EditorGUI.DrawPreviewTexture(rect, nodeValue);
            }
            else
            {
                GUIStyle errorStyle = new(EditorStyles.label)
                {
                    alignment = TextAnchor.UpperCenter,
                    fontStyle = FontStyle.Bold,
                    fontSize = 18,
                    padding = new(8, 8, 8, 8)
                };
                GUIStyle errorExplanationStyle = new(EditorStyles.label)
                {
                    alignment = TextAnchor.LowerCenter,
                    fontSize = 10,
                    wordWrap = true,
                    padding = new(8, 8, 8, 8)
                };

                EditorGUI.DrawRect(rect, Color.black);
                EditorGUI.LabelField(rect, "No output!", errorStyle);
                EditorGUI.LabelField(rect, "Check that you connected all the input ports and filled all the fields on this or connected nodes. If that doesn't help, check the Console panel for an error.", errorExplanationStyle);
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