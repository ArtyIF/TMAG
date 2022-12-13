using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using XNodeEditor;

[CustomNodeGraphEditor(typeof(TMAGGraph), "TMAGGraph.Settings")]
public class TMAGGraphEditor : NodeGraphEditor
{
    public override NodeEditorPreferences.Settings GetDefaultPreferences()
    {
        return new NodeEditorPreferences.Settings()
        {
            typeColors = new Dictionary<string, Color>() {
                { typeof(CustomRenderTexture).PrettyName(), new Color(255 / 255.0f, 192 / 255.0f, 64 / 255.0f) }
            }
        };
    }

    public override string GetPortTooltip(NodePort port)
    {
        return $"{port.node.name}: {port.fieldName}";
    }

    public override string GetNodeMenuName(System.Type type)
    {
        if (base.GetNodeMenuName(type).StartsWith("TMAG/"))
        {
            return base.GetNodeMenuName(type).Replace("TMAG/", "");
        }
        return null;
    }
}