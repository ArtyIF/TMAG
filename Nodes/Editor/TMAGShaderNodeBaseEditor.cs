using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(TMAGShaderNodeBase))]
public class TMAGShaderNodeBaseEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        base.OnBodyGUI();
        TMAGShaderNodeBase node = target as TMAGShaderNodeBase;
        
        GUILayout.Space(NodeEditorResources.styles.nodeBody.padding.bottom);
        if (!node.hidePreview) {
            Rect rect = GUILayoutUtility.GetAspectRect(1, GUILayout.ExpandWidth(true));
            GUI.DrawTexture(rect, node.GetValue(node.GetOutputPort("output")) as CustomRenderTexture, ScaleMode.ScaleToFit);
            if (GUILayout.Button("Hide Preview", GUILayout.ExpandWidth(true))) {
                node.hidePreview = true;
            }
        } else {
            if (GUILayout.Button("Show Preview", GUILayout.ExpandWidth(true))) {
                node.hidePreview = false;
            }
        }
    }
}