using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(HeightmapNode))]
public class HeightmapNodeEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        base.OnBodyGUI();
        HeightmapNode node = target as HeightmapNode;

        if (!node.HidePreview)
        {
            Rect rect = GUILayoutUtility.GetAspectRect(1, GUILayout.ExpandWidth(true));
            GUI.DrawTexture(rect, node.GetValue(node.GetOutputPort("output")) as CustomRenderTexture, ScaleMode.ScaleToFit);
            if (GUILayout.Button("Hide Preview", GUILayout.ExpandWidth(true)))
            {
                node.HidePreview = true;
            }
        }
        else
        {
            if (GUILayout.Button("Show Preview", GUILayout.ExpandWidth(true)))
            {
                node.HidePreview = false;
            }
        }
    }
}