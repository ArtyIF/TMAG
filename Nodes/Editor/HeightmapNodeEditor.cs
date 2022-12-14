using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

[CustomNodeEditor(typeof(HeightmapNode))]
public class HeightmapNodeEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        base.OnBodyGUI();
        HeightmapNode node = target as HeightmapNode;
        
        GUILayout.Space(NodeEditorResources.styles.nodeBody.padding.bottom);
        Rect rect = GUILayoutUtility.GetAspectRect(1, GUILayout.ExpandWidth(true));
        GUI.DrawTexture(rect, node.GetValue(null) as CustomRenderTexture, ScaleMode.ScaleToFit);
    }
}