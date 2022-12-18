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
    public CustomRenderTexture input;
    
    public override object GetValue(NodePort port)
    {
        return GetInputValue<CustomRenderTexture>("input");
    }
}