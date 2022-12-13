using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

[CustomNodeEditor(typeof(TMAGShaderNodeBase))]
public class TMAGShaderNodeBaseEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        base.OnBodyGUI();
        TMAGShaderNodeBase node = target as TMAGShaderNodeBase;
        
        GUILayout.Space(NodeEditorResources.styles.nodeBody.padding.bottom);
        Rect rect = GUILayoutUtility.GetAspectRect(1, GUILayout.ExpandWidth(true));
        GUI.DrawTexture(rect, node.GetValue(node.GetOutputPort("output")) as CustomRenderTexture, ScaleMode.ScaleToFit);
    }
}