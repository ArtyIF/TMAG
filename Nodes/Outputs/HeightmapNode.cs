using UnityEngine;
using XNode;

[CreateNodeMenu("TMAG/Outputs/Heightmap")]
public class HeightmapNode : TMAGNodeBase
{
    [Input(
        connectionType = ConnectionType.Override,
        typeConstraint = TypeConstraint.Strict,
        backingValue = ShowBackingValue.Never
    )]
    public RenderTexture input;
    [HideInInspector] public bool hidePreview = false;
    
    public override object GetValue(NodePort port)
    {
        return GetInputValue<RenderTexture>("input");
    }
}