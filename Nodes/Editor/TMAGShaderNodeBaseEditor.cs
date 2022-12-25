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
            GUI.DrawTexture(rect, node.GetValue(node.GetOutputPort("output")) as RenderTexture, ScaleMode.ScaleToFit);
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